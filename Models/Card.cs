using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeckOfCards.Enumerables;

namespace DeckOfCards.Models
{
    public class Card
    {
        public int faceValue { get; set; }
        public Suits suit { get; set; }
        public Card(Suits suit, int value)
        {
            this.suit = suit;
            this.faceValue = value;
        }
        public override string ToString()
        {
            return DeckOfCards.Service.CardStringifier.CardToString(this);
        }
    }
}
