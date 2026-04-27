# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

**BevosTunes** — an ASP.NET Core MVC music store (Team 10, MIS333K Final Project). Customers browse, purchase, and review songs/albums. Employees moderate reviews. Managers/Admins run reports and administer roles. Built on .NET 10, EF Core 10, ASP.NET Core Identity, and Azure SQL.

## Build & Run

```bash
# Build
dotnet build "Team 10 Final Project/Team 10 Final Project.csproj"

# Run (from repo root)
dotnet run --project "Team 10 Final Project/Team 10 Final Project.csproj"

# EF Core migrations (run from inside the project folder)
cd "Team 10 Final Project"
dotnet ef migrations add <MigrationName>
dotnet ef database update
```

The VS Code launch config (`.vscode/launch.json`) runs with `ASPNETCORE_ENVIRONMENT=Development` and opens the browser automatically on launch.

**Database:** The connection string in `Program.cs` (hardcoded) points to an Azure SQL database (`sp26nataliepang.database.windows.net`). `appsettings.json` has a LocalDB fallback string that is not wired up. To switch databases, update the `connectionString` variable in `Program.cs`.

## Database Seeding

Navigate to these routes after `dotnet ef database update` to seed in order:

1. `/Seed/SeedRoles`
2. `/Seed/SeedGenres`
3. `/Seed/SeedArtists`
4. `/Seed/SeedSongs`
5. `/Seed/SeedAlbums`
6. `/Seed/SeedCustomers`
7. `/Seed/SeedEmployees`
8. `/Seed/SeedManagers`
9. `/Seed/SeedCards`
10. `/Seed/SeedOrders`
11. `/Seed/SeedReviews`
12. `/Seed/SeedPromotions`

## Architecture

### Namespace & Project Root
- Namespace: `Team10FinalProject` (note: the `.csproj` `RootNamespace` is `Team_10_Final_Project` but all source files use `Team10FinalProject`)
- ViewModels live in `Models/ViewModels/` but use `namespace Team10FinalProject.ViewModels` — **not** `Team10FinalProject.Models.ViewModels`. Use `using Team10FinalProject.ViewModels;` when importing them.
- All source is under `Team 10 Final Project/`

### Key Layers

| Folder | Purpose |
|---|---|
| `Models/` | EF Core entity classes (`Song`, `Album`, `Artist`, `Genre`, `Order`, `OrderDetail`, `Card`, `Promotion`, `Review`, `AppUser`) |
| `Models/ViewModels/` | ViewModels for search forms, account pages, reports, and detail pages (namespace: `Team10FinalProject.ViewModels`) |
| `DAL/AppDbContext.cs` | EF Core DbContext — extends `IdentityDbContext<AppUser>`. All FK delete behaviors are set to `NoAction` globally. |
| `Controllers/` | Standard MVC controllers; each entity has its own controller |
| `Views/` | Razor views organized by controller name |
| `Seeding/` | One seeder class per entity type, invoked via `SeedController` |
| `Utilities/` | `EmailMessaging`, `ZipLookup`, `RatingHelper`, `AddUser` |

### Identity & Roles
Four roles: `Customer`, `Employee`, `Manager`, `Admin`. Role management is handled by `RoleAdminController` (Manager-only). Employees/Managers can add users via `AccountController.AddUser`. Registration auto-assigns `Customer` role. `AppUser` extends `IdentityUser` with `FirstName`, `LastName`, `Address`, `City`, `State`, `ZipCode`, and a `Status` bool (false = account disabled).

### Catalog Status Flag
`Song`, `Album`, and `Artist` each have a `Status` bool (default `true` = active/visible). This is separate from `AppUser.Status`.

### Order / Cart Flow
- A pending cart is an `Order` with `Status == true` and `IsRefunded == false`.
- A completed purchase is `Status == false` and `IsRefunded == false`.
- An `OrderDetail` has either a `SongID` or `AlbumID` (never both).
- Gift purchases: order has a `FriendID`; only individual songs (not albums) can be gifted.
- Order numbers start at 212000, assigned at checkout.
- Refunds set `IsRefunded = true`; a refund email is sent to both the purchaser and the gift recipient (if applicable).
- `MyMusicController` shows a customer's library: completed, non-refunded `OrderDetail` records where `SongID != null`.
- `OrderHistoryController` shows the customer's past completed orders.

### Review Moderation
The `Review` model has **three** status-related fields:
- `Status` (bool, default `false`) — legacy field; set to `true` when approved by some code paths
- `IsApproved` (bool, default `false`) — set by `ReviewModerationController.Approve`
- `IsRejected` (bool, default `false`) — set by `ReviewModerationController.Reject`

`ReviewModerationController` queries for pending reviews as `IsApproved == false && IsRejected == false`. `RatingHelper` recalculates `AvgRating` on `Song`, `Album`, or `Artist` whenever a review is approved, edited, or deleted. A customer can only review a song they have purchased (completed, non-refunded order). Editing a review resets it to pending.

### Promotions
`Promotion` applies a flat `DiscountAmount` to one entity (Song, Album, or Artist). Active promotions have `PromotionStatus == true`. `AlbumController.Details` reads the active promotion and passes discounted price via `AlbumDetailsViewModel`. `PromotionType` is a free-text string field describing the promotion.

### Email
`EmailMessaging` (in `Utilities/`) sends all emails via Gmail SMTP. For grading purposes, all emails are redirected to a single inbox (`KindKGroup10@gmail.com`) regardless of the intended recipient; the intended address is noted in the body.

### Zip Code Lookup
`ZipLookup.LookupAsync` calls `api.zippopotam.us` to resolve city/state from a zip code. Results are in-memory cached. Called on registration and profile edits.

### Search
`SearchController` supports three independent search forms (Song, Album, Artist) using `IQueryable` with optional filters for name, genre (multi-select), artist name, and rating comparison (greater/less than). ViewModels for each search are in `Models/ViewModels/`.

### Reports (Admin/Manager only)
`ReportsController` exposes three reports:
- **AllSongsSold** — direct song purchases (`AlbumID == null`) grouped by song, ordered by revenue
- **AllAlbumsSold** — album purchases grouped by album, ordered by revenue  
- **TopSellingBands** — one top-revenue artist per genre, with song/album breakdown

Many-to-many (Albums↔Artists) prevents SQL-side grouping for AllAlbumsSold and TopSellingBands; those queries pull into memory first.
