using System;

using Bridgelabz.DataStructure;

namespace Bridgelabz.ObjectOriented.DeckOfCards
{
    class DeckOfCard
    {
        


        DataStructure.Utility.UnOrderedList<Card> cardDeck;

        public DeckOfCard()
        {
            cardDeck = new DataStructure.Utility.UnOrderedList<Card>();


        }

        public DeckOfCard(Utility.UnOrderedList<Card> cardDeck)
        {
            this.cardDeck = cardDeck;
        }

        public void Add(Card card)
        {
            cardDeck.Add(card);
        }
        public int Size()
        {
            return cardDeck.Size();
        }
        public Card Pop()
        {
            return cardDeck.Pop();
        }
        public Card Pop(int pos)
        {
           return cardDeck.Pop(pos);
        }
        public void Shuffle()
        {
            Card tempA,tempB;int posA, posB;
            Random rand = new Random();
            int time = rand.Next(0, cardDeck.Size() - 1);
            while(time > 0)
            {
                posA = rand.Next(0, cardDeck.Size() - 1);
                posB = rand.Next(0, cardDeck.Size() - 1);
                tempA = cardDeck.Pop(posA);
                tempB = cardDeck.Pop(posB);
                cardDeck.insert(posA, tempB);
                cardDeck.insert(posB, tempA);
                time--;
            }
            

        }
    }
}
