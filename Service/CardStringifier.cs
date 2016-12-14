using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeckOfCards.Enumerables;
using DeckOfCards.Models;
namespace DeckOfCards.Service
{
    public static class CardStringifier
    {
        public static readonly string[] SuitNames  = { "Clubs", "Spades", "Hearts", "Diamonds" };
        public static readonly string[] valueNames = { "", "Ace", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Jack", "Queen", "King" };
        
        public static string SuitToString(Suits suit)
        {
            return SuitNames[(int)suit];
        }
        public static string ValueToString(int value)
        {
            return valueNames[value];
        }
        public static string CardToString(Card card)
        {
            return ValueToString(card.faceValue) + " of " + SuitToString(card.suit);
        }
    }
}
