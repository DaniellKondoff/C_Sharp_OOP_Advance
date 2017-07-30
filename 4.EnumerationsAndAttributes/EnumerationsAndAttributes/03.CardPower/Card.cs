using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CardPower
{
    public class Card : IComparable<Card>
    {
        public Card(Rank rank, Suit suit)
        {
            this.Rank = rank;
            this.Suit = suit;
        }
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }

        public override string ToString()
        {
            return $"Card name: {Rank} of {Suit}; Card power: {(int)Rank + (int)Suit}";
        }

        public int CompareTo(Card other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return ((int)this.Rank + (int)this.Suit).CompareTo(((int)other.Rank + (int)other.Suit));
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Card card = obj as Card;
            
            return ((int)this.Rank + (int)this.Suit).Equals(((int)card.Rank + (int)card.Suit));
        }
    }
}
