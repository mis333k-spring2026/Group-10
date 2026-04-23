using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Team_10_Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class AddIsRefunded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRefunded",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRefunded",
                table: "Orders");
        }
    }
}
