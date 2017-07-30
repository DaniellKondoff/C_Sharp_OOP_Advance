using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CardPower
{
    class StartUp
    {
        private static Card biggest;
        private static string winner;
        static void Main(string[] args)
        {
            //CardPower();
            //CardsCamapres();
            //PrintAttribute();
            //DeckOfCards();
            //PlayCards();
        }

        private static void PlayCards()
        {
            var firstPlayer = Console.ReadLine();
            var secondPlayer = Console.ReadLine();

            List<Card> deck = GenerateDeck();

            List<Card> firstDeck = new List<Card>();
            List<Card> secondDeck = new List<Card>();



            while (firstDeck.Count < 5 || secondDeck.Count < 5)
            {
                var inputArgs = Console.ReadLine().Split();
                try
                {
                    Suit cardSuit = (Suit)Enum.Parse(typeof(Suit), inputArgs[inputArgs.Length-1]);
                    Rank cardRank = (Rank)Enum.Parse(typeof(Rank), inputArgs[0]);
                    var card = new Card(cardRank, cardSuit);
                    if (deck.Contains(card))
                    {
                        deck.Remove(card);
                        if (firstDeck.Count < 5)
                        {
                            firstDeck.Add(card);
                            WinnerCheck(card, firstPlayer);
                        }
                        else
                        {
                            secondDeck.Add(card);
                            WinnerCheck(card, secondPlayer);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Card is not in the deck.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("No such card exists.");
                }
            }
            Console.WriteLine($"{winner} wins with {biggest.Rank} of {biggest.Suit}.");
        }

        private static void WinnerCheck(Card card,string player)
        {
            if (card.CompareTo(biggest) > 0)
            {
                biggest = card;
                winner = player;
            }
        }

        private static List<Card> GenerateDeck()
        {
            List<Card> deck = new List<Card>();

            foreach (var suit in Enum.GetNames(typeof(Suit)))
            {
                Suit cardSuit = (Suit)Enum.Parse(typeof(Suit), suit);
                foreach (var rank in Enum.GetNames(typeof(Rank)))
                {
                    Rank cardRank = (Rank)Enum.Parse(typeof(Rank), rank);
                    deck.Add(new Card(cardRank, cardSuit));
                }
            }

            return deck;
        }
        private static void DeckOfCards()
        {
            string[] suits = Enum.GetNames(typeof(Suit));
            string[] ranks = Enum.GetNames(typeof(Rank));

            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    Console.WriteLine($"{rank} of {suit}");
                }
            }
        }

        private static void PrintAttribute()
        {
            var input = Console.ReadLine();
            Type type = null;
            if (input == "Rank")
            {
                type = typeof(Rank);
                var attributes = type.GetCustomAttributes(false);
                Console.WriteLine(attributes[0]);
            }
            else
            {
                type = typeof(Suit);
                var attributes = type.GetCustomAttributes(false);
                Console.WriteLine(attributes[0]);
            }
        }
        private static void CardPower()
        {
            string cardRankStr = Console.ReadLine();
            Rank cardRank = (Rank)Enum.Parse(typeof(Rank), cardRankStr);
            string cardSuitStr = Console.ReadLine();
            Suit cardSuit = (Suit)Enum.Parse(typeof(Suit), cardSuitStr);
            Card card = new Card(cardRank, cardSuit);
            Console.WriteLine(card);
        }

        private static void CardsCamapres()
        {
            string cardRankStr = Console.ReadLine();
            Rank cardRank = (Rank)Enum.Parse(typeof(Rank), cardRankStr);
            string cardSuitStr = Console.ReadLine();
            Suit cardSuit = (Suit)Enum.Parse(typeof(Suit), cardSuitStr);
            Card card = new Card(cardRank, cardSuit);

            string cardRankStr2 = Console.ReadLine();
            Rank cardRank2 = (Rank)Enum.Parse(typeof(Rank), cardRankStr2);
            string cardSuitStr2 = Console.ReadLine();
            Suit cardSuit2 = (Suit)Enum.Parse(typeof(Suit), cardSuitStr2);
            Card card2 = new Card(cardRank2, cardSuit2);

            int biggerOne = card.CompareTo(card2);
            if (biggerOne == 1)
            {
                Console.WriteLine(card);
            }
            else
            {
                Console.WriteLine(card2);
            }
        }
    }
}
