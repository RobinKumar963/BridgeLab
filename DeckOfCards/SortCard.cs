using System;



namespace Bridgelabz.ObjectOriented.DeckOfCards
{
    public class SortCard
    {
        static int MinIndex(ref DataStructure.Utility.Queue<Card> q,int sortedIndex)
        {
            int min_index = -1;
            Card minCard = new Card();
            int n = q.Size();
            for (int i = 0; i < n; i++)
            {
                Card curr = q.Dequeue();
                 
                ////Removing  
                             
                 

                //// we add the condition  
                //// i <= sortedIndex because 
                //// we don't want to traverse 
                //// on the sorted part of the  
                //// queue, which is the right part. 
                if (Convert.ToInt32(curr.GetRank()) <= Convert.ToInt32(minCard.GetRank()) && i <= sortedIndex)
                {
                    min_index = i;
                    minCard = curr;
                }
                q.Enqueue(curr); 
                //// This is enqueue()  
                 
            }
            return min_index;
        }

        //// Moves given minimum  
        //// element to rear of queue 
        static void InsertMinToRear(ref DataStructure.Utility.Queue<Card> q,int min_index)
        {
            
            Card minCard = new Card();
            int n = q.Size();
            for (int i = 0; i < n; i++)
            {
                Card currCard = q.Dequeue();
                int curr = Convert.ToInt32(currCard.GetRank());
                
                if (i != min_index)
                    q.Enqueue(currCard);
                else
                {
                    
                    minCard = currCard;
                }
                    
            }
            q.Enqueue(minCard);
        }

        internal static void SortQueue(ref DataStructure.Utility.Queue<Card> q)
        {
            for (int i = 1; i <= q.Size(); i++)
            {
                int min_index = MinIndex(ref q, q.Size() - i);
                InsertMinToRear(ref q,min_index);
            }
        }



       
    }
}
