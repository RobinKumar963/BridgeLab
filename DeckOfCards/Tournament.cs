using System;

using Bridgelabz.DataStructure;

namespace Bridgelabz.ObjectOriented.DeckOfCards
{
    class Tournament
    {
        DataStructure.Utility.Queue<Player> playerDetail;

        public Tournament(Utility.Queue<Player> playerDetail)
        {
            this.playerDetail = playerDetail;
        }
        public Tournament()
        {
            playerDetail = new DataStructure.Utility.Queue<Player>();
        }
       
        public void Add(Player player)
        {
            playerDetail.Enqueue(player);
        }
        public void ShowPlayer()
        {
            DataStructure.Utility.Queue<Player> temp = this.playerDetail;
            Player readPlayer;
            while (temp != null)
            {
                Console.WriteLine();
                readPlayer = temp.Dequeue();
                readPlayer.ShowCard();




            }
        }

    }
}
