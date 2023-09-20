using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.cs
{
    internal class Program
    {
        static IEnumerable<string> Suits()
        {
            yield return "clubs";
            yield return "diamonds";
            yield return "hearts";
            yield return "spades";
        }
        static IEnumerable<string> Ranks()
        {
            yield return "two";
            yield return "three";
            yield return "four";
            yield return "five";
            yield return "six";
            yield return "seven";
            yield return "eight";
            yield return "nine";
            yield return "ten";
            yield return "jack";
            yield return "queen";
            yield return "king";
            yield return "ace";
        }
        static void Main(string[] args)
        {
            var startingDeck = from s in Suits()
                               from r in Ranks()
                               select new { Suit = s, Rank = r };
            foreach (var card in startingDeck)
            {
                Console.WriteLine(card);
            }

            var top = startingDeck.Take(26); // top half of deck - take first 26 cards
            var bottom = startingDeck.Skip(26); // bottom half of deck - skip first 26 cards
            var shuffle = top.InterleaveSequenceWith(bottom);

            foreach (var c in shuffle)
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();


            string likes = "I like fruit";
            string[] fruit = { "apple", "banana", "orange", "strawberry" };
            int[] numbers = { 1, 2, 3, 4, 5 };
            var getNumbers = from number
                             in numbers
                             where number > 2
                             select number;
            Console.WriteLine(string.Join(", ", getNumbers));
            Console.ReadLine();
            var getGLen = from item
                          in fruit
                          where item.Contains("g")
                          where item.Length < 8
                          select item;
            Console.WriteLine(string.Join(", ", getGLen));
            Console.ReadLine();
            var getEvenNumbers = from number
                                 in numbers
                                 where number % 2 == 0
                                 select number;
            Console.WriteLine(string.Join(", ", getEvenNumbers));
            Console.ReadLine();

        }
    }
}
