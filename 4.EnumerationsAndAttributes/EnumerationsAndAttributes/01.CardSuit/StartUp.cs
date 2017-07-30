using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CardSuit
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] cardNames = Enum.GetNames(typeof(CardSuit));

            Console.WriteLine($"Card Suits:");
            foreach (var card in cardNames)
            {
                int number = (int)(CardSuit)Enum.Parse(typeof(CardSuit), card);
                Console.WriteLine($"Ordinal value: {number}; Name value: {card}");
            }

        }
    }
}
