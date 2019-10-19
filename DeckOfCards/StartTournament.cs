using System;



namespace Bridgelabz.ObjectOriented.DeckOfCards
{
    class StartTournament
    {
        enum Suit { Club, Heart, Diamond, Spade };

        enum Rank { two = 2, three = 3, four = 4, five = 5, six = 6, seven = 7, eight = 8, nine = 9, ten = 10, jack, queen, king, ace };

        public static void Main(String[] args)
        {
            ////Adding all card to deckofcard
            DeckOfCard deckOfCard = new DeckOfCard();

            foreach (var suit in Enum.GetNames(typeof(Suit)))
            {
                foreach (var rank in Enum.GetNames(typeof(Rank)))
                {
                    deckOfCard.Add(new Card(suit, rank));

                }
            }



            ////Time to shuffle card
            deckOfCard.Shuffle();



            ////Time to distribute card to 4 player
            Player[] player = new Player[4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    player[i].Add(deckOfCard.Pop()); 

                }

            }


            ////Time to put 4 players into Queue
            
            Tournament tournament = new Tournament();
            for (int i = 0; i < 4; i++)
            {
                
                tournament.Add(player[i]);

            }


            ////Time to display distributed card
            tournament.ShowPlayer();
 
        }
    }
}
