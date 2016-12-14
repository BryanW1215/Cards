using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeckOfCards.Enumerables;
using DeckOfCards.Models;
using DeckOfCards.ExtensionMethods;
namespace DeckOfCards.Models
{
    public class Deck
    {

        private List<Card> Cards { get; set; }
        public Deck(bool shuffled = true)
        {
            this.Cards = new List<Card>();
            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                for (var i = 1; i <= 13; i++)
                {
                    Cards.Add(new Card(suit, i));
                }
            }
            if (shuffled)
            {
                this.Shuffle();
            }
        }
        public Card Draw()
        {
            var card = this.Cards[0];
            this.Cards.RemoveAt(0);
            return card;
        }
        public int Count { get
            {
                return this.Cards.Count;
            }
        }
        public void Shuffle()
        {
            this.Cards = this.Cards.Shuffle();
        }
    }
}
