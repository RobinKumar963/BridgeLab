using System;


namespace Bridgelabz.ObjectOriented.DeckOfCards
{
    public class DistributeCard
    {
        enum Suit { Club, Heart, Diamond, Spade };

        enum Rank { two = 2, three = 3, four = 4, five = 5, six = 6, seven = 7, eight = 8, nine = 9, ten = 10, jack, queen, king, ace };

        public static void Main(String[] args)
        {
            ////Adding all card to deckofcard
            DeckOfCard deckOfCard = new DeckOfCard();

            foreach(var suit in Enum.GetNames(typeof(Suit)))
            {
                foreach(var rank in Enum.GetNames(typeof(Rank)))
                {
                    deckOfCard.Add(new Card(suit, rank));

                }
            }


                        
            ////Time to shuffle card
            deckOfCard.Shuffle();

            ////Time to distribute card

            Card[,] playercard = new Card[4, 9];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    playercard[i,j]=deckOfCard.Pop();

                }
                
            }

            ////Time to display distributed card

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write("\t\t" + playercard[i, j].GetSuit() + playercard[1, j].GetRank());
                    
                }
                Console.WriteLine();
            }


        }
    }
}



        
    
    

