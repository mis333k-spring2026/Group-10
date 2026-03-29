using System.Collections.Generic;
using Team_10_Final_Project.Models;

namespace Team_10_Final_Project.ViewModels
{
    public class ManageCreditCardsViewModel
    {
        public List<Card> Cards { get; set; } = new List<Card>();
        public AddCardViewModel NewCard { get; set; } = new AddCardViewModel();
    }
}