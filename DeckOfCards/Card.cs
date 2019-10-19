using System;


namespace Bridgelabz.ObjectOriented.DeckOfCards
{
    internal class Card : IComparable
    {
        String Suit;
        String Rank;

        public Card(string suit, string rank)
        {
            this.Suit = suit;
            this.Rank = rank;
        }
        public Card()
        {
            this.Suit = "";
            this.Rank = "";
        }

        public String GetSuit()
        {
            return this.Suit;
        }
        public String GetRank()
        {
            return this.Rank;
        }

        public int CompareTo(object obj)
        {
            return 0;
        }
    }
}
