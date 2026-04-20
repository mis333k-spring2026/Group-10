using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Team10FinalProject.DAL;
using Team10FinalProject.Models;

namespace Team10FinalProject.Controllers
{
    [Authorize] //- TODO: uncomment after milestone 6
    public class CardController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public CardController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

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

            if (cleanNumber.Length < 15 || cleanNumber.Length > 16)
            {
                ModelState.AddModelError("CardNumber", "Card number must be 15 or 16 digits.");
                return View(card);
}

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
            if (cardNumber.Length == 15)
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

        public async Task<IActionResult> Edit(int id)
        {
            AppUser? user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return View("Error", new List<string> { "User not found." });
            }

            Card? card = _context.Cards.FirstOrDefault(c => c.CardID == id && c.CustomerID == user.Id && c.Status);

            if (card == null)
            {
                return View("Error", new List<string> { "Card not found." });
            }

            return View(card);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Card card)
        {
            AppUser? user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return View("Error", new List<string> { "User not found." });
            }

            Card? dbCard = _context.Cards.FirstOrDefault(c => c.CardID == card.CardID && c.CustomerID == user.Id && c.Status);

            if (dbCard == null)
            {
                return View("Error", new List<string> { "Card not found." });
            }

            if (string.IsNullOrWhiteSpace(card.CardNumber))
            {
                ModelState.AddModelError("CardNumber", "Card number is required.");
                return View(card);
            }

            string cleanNumber = new string(card.CardNumber.Where(char.IsDigit).ToArray());

            if (cleanNumber.Length < 15 || cleanNumber.Length > 16)
            {
                ModelState.AddModelError("CardNumber", "Card number must be 15 or 16 digits.");
                return View(card);
            }

            string? cardType = DetectCardType(cleanNumber);
            if (cardType == null)
            {
                ModelState.AddModelError("CardNumber", "Invalid card number. Use Visa, MasterCard, Discover, or American Express.");
                return View(card);
            }

            bool duplicateExists = _context.Cards.Any(c =>
                c.CustomerID == user.Id &&
                c.CardID != card.CardID &&
                c.CardNumber == cleanNumber &&
                c.Status);

            if (duplicateExists)
            {
                ModelState.AddModelError("CardNumber", "That card is already saved.");
                return View(card);
            }

            dbCard.CardNumber = cleanNumber;
            dbCard.CardType = cardType;

            _context.Update(dbCard);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            AppUser? user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return View("Error", new List<string> { "User not found." });
            }

            Card? card = _context.Cards.FirstOrDefault(c => c.CardID == id && c.CustomerID == user.Id && c.Status);

            if (card == null)
            {
                return View("Error", new List<string> { "Card not found." });
            }

            return View(card);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            AppUser? user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return View("Error", new List<string> { "User not found." });
            }

            Card? card = _context.Cards.FirstOrDefault(c => c.CardID == id && c.CustomerID == user.Id && c.Status);

            if (card == null)
            {
                return View("Error", new List<string> { "Card not found." });
            }

            card.Status = false;
            _context.Update(card);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}