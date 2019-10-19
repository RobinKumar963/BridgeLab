// --------------------------------------------------------------------------------------------------------------------
// <copyright file=PalindromeChecker.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------


using System;
namespace Bridgelabz.DataStructure
{
    /// <summary>
    /// Illustration of dequee by performing palindrome check
    /// </summary>
    public class PalindromeChecker
    {

        public static void main(String[] args)
        {
            Utility.Dequeue<int> dequeue = new Utility.Dequeue<int>();
            String str = Console.ReadLine();
            for(int i=0;i<str.Length;i++)
            {
                dequeue.AddRear(str[i]);
            }

            int flag = 1;
            while(dequeue != null)
            {
                if (dequeue.RemoveFront() != dequeue.RemoveRear())
                    flag = 0;
            }
            if (flag == 1)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not palindrome");
        }

    }
}
