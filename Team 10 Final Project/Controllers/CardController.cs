using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team10FinalProject.DAL;
using Team10FinalProject.Models;

namespace Team10FinalProject.Controllers
{
    [Authorize] // re-protect normal card pages
    public class CardController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public CardController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // normal user-specific page
        public async Task<IActionResult> Index()
        {
            AppUser? user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return View("Error", new List<string> { "User not found." });
            }

            var cards = _context.Cards
                .Where(c => c.CustomerID == user.Id && c.Status)
                .ToList();

            return View(cards);
        }

        // public seeded-data page
        [AllowAnonymous]
        public async Task<IActionResult> SeedIndex()
        {
            var cards = await _context.Cards
                .Include(c => c.Customer)
                .Where(c => c.Status)
                .ToListAsync();

            return View("Index", cards);
        }

        public async Task<IActionResult> Create()
        {
            AppUser? user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return View("Error", new List<string> { "User not found." });
            }

            int cardCount = _context.Cards.Count(c => c.CustomerID == user.Id && c.Status);
            if (cardCount >= 2)
            {
                return View("Error", new List<string> { "You may only store up to two cards." });
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Card card)
        {
            AppUser? user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return View("Error", new List<string> { "User not found." });
            }

            int cardCount = _context.Cards.Count(c => c.CustomerID == user.Id && c.Status);
            if (cardCount >= 2)
            {
                return View("Error", new List<string> { "You may only store up to two cards." });
            }

            if (string.IsNullOrWhiteSpace(card.CardNumber))
            {
                ModelState.AddModelError("CardNumber", "Card number is required.");
                return View(card);
            }

            string cleanNumber = new string(card.CardNumber.Where(char.IsDigit).ToArray());

            string? cardType = DetectCardType(cleanNumber);
            if (cardType == null)
            {
                ModelState.AddModelError("CardNumber", "Invalid card number. Use Visa, MasterCard, Discover, or American Express.");
                return View(card);
            }

            bool alreadyExists = _context.Cards.Any(c => c.CustomerID == user.Id && c.CardNumber == cleanNumber && c.Status);
            if (alreadyExists)
            {
                ModelState.AddModelError("CardNumber", "That card is already saved.");
                return View(card);
            }

            card.CardNumber = cleanNumber;
            card.CardType = cardType;
            card.CustomerID = user.Id;
            card.Customer = user;
            card.Status = true;

            _context.Cards.Add(card);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        private string? DetectCardType(string cardNumber)
        {
            if (cardNumber.Length == 15 && cardNumber.StartsWith("3"))
            {
                return "American Express";
            }

            if (cardNumber.Length == 16 && cardNumber.StartsWith("54"))
            {
                return "MasterCard";
            }

            if (cardNumber.Length == 16 && cardNumber.StartsWith("4"))
            {
                return "Visa";
            }

            if (cardNumber.Length == 16 && cardNumber.StartsWith("6"))
            {
                return "Discover";
            }

            return null;
        }
    }
}