using System.Collections.Generic;
using Team10FinalProject.Models;

namespace Team10FinalProject.ViewModels
{
    public class ManageCreditCardsViewModel
    {
        public List<Card> Cards { get; set; } = new List<Card>();
        public AddCardViewModel NewCard { get; set; } = new AddCardViewModel();
    }
}