using System;
using Bridgelabz.DataStructure;

namespace Bridgelabz.ObjectOriented.DeckOfCards
{
    internal class Player :IComparable
    {
       
        DataStructure.Utility.Queue<Card> PlayerdeckOfCards;

        public Player(Utility.Queue<Card> deckOfCards)
        {
            
            this.PlayerdeckOfCards = deckOfCards;
        }
        public Player()
        {
            PlayerdeckOfCards = new DataStructure.Utility.Queue<Card>();
        }
       
           
        

        public void SortByRank()
        {
            SortCard.SortQueue(ref PlayerdeckOfCards);
        }

        public void Add(Card card)
        {
            PlayerdeckOfCards.Enqueue(card);
        }

        public Card Pop()
        {
            return PlayerdeckOfCards.Dequeue();
        }

        public int CompareTo(object obj)
        {
            return 0;
        }

        public void ShowCard()
        {


            
            DataStructure.Utility.Queue<Card> temp = this.PlayerdeckOfCards;
            Card readCard;
            while (temp != null)
            {
                readCard = temp.Dequeue();
                

                Console.Write("\t\t");
                Console.Write(readCard.GetRank());
                Console.Write(readCard.GetRank());




            }


        }
    }
}
