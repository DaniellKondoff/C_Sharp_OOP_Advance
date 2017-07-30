using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CardRank
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] cardNames = Enum.GetNames(typeof(CardRank));

            Console.WriteLine($"Card Ranks:");
            foreach (var card in cardNames)
            {
                int number = (int)(CardRank)Enum.Parse(typeof(CardRank), card);
                Console.WriteLine($"Ordinal value: {number}; Name value: {card}");
            }
        }
    }
}
