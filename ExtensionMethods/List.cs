using System;
using System.Collections.Generic;
namespace DeckOfCards.ExtensionMethods
{
    static class ListExtensionMethods
    {
        public static List<T> Shuffle<T>(this List<T> target)
        {
            var retList = new List<T>();
            var randomizer = new Random();
            do
            {
                var selectedIndex = randomizer.Next(0, target.Count - 1);
                retList.Add(target[selectedIndex]);
                target.RemoveAt(selectedIndex);
            } while (target.Count > 0);
            return retList;
        }
    }
}