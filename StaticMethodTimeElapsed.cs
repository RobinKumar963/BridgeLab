// --------------------------------------------------------------------------------------------------------------------
// <copyright file=StaticMethodTimeElapsed.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------




using System;
using System.Collections;
using System.Collections.Generic;

namespace Bridgelabz.Algorithm
{


    /// <summary>
    /// calls diiferent utility method and check the time elapsed between it
    /// </summary>
    public class StaticMethodTimeElapsed 
    {






        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(String[] args) 
        {
            ////Intialization of array to be sorted and key for binary search
            int[] arrToBeSortedUsingInsertion = { 9, 3, 7, 6, 1 };
            int[] arrToBeSortedUsingBubble = { 4, 2, 8, 7, 5 };

            String[] strarrToBeSortedUsingInsertion = { "Are", "Bat", "Ant", "Friends", "yay" };
            String[] strarrToBeSortedUsingBubble = { "Why", "hey", "tresme", "rook", "killer" };

            ArrayList elapsedTime = new ArrayList();

            

            int key1 = 5, posForIntegerBinarySearch, posForStringBinarySearch;
            String strKey1 = "Ant";
            
            ////Displaying above intialized arrays on which different sorting and binary search operation has to be performed
            Console.WriteLine();
            Console.WriteLine("Integers to be sorted with insertion");
            Utility.PrintArray(arrToBeSortedUsingInsertion);

            Console.WriteLine();
            Console.WriteLine("Integers to be sorted with bubble");
            Utility.PrintArray(arrToBeSortedUsingBubble);

            Console.WriteLine();
            Console.WriteLine("String to be sorted with bubble");
            Utility.PrintArray(strarrToBeSortedUsingBubble);

            Console.WriteLine();
            Console.WriteLine("String to be sorted with insertion");
            Utility.PrintArray(strarrToBeSortedUsingInsertion);

            Console.WriteLine();
            Console.WriteLine("Key for Integer Binary search " + key1);
            Console.WriteLine("Key for String Binary search " + strKey1);


            Console.WriteLine();
            Console.WriteLine(".............................");



            ////calling different method and saving the elapsed time in arralist elapsedTime
            StopWatchUtility watch = new StopWatchUtility();
            Utility.GenericinsertionSort(arrToBeSortedUsingInsertion);
            elapsedTime.Add(watch.ElapsedTime());





            Utility.GenericbubbleSort(arrToBeSortedUsingBubble);
            elapsedTime.Add(watch.ElapsedTime());


            Utility.GenericinsertionSort(strarrToBeSortedUsingInsertion);
            elapsedTime.Add(watch.ElapsedTime());

            Utility.GenericbubbleSort(strarrToBeSortedUsingBubble);
            elapsedTime.Add(watch.ElapsedTime());


            posForIntegerBinarySearch = Utility.GenericbinarySearch(arrToBeSortedUsingBubble, key1);
            elapsedTime.Add(watch.ElapsedTime());


            posForStringBinarySearch = Utility.GenericbinarySearch(strarrToBeSortedUsingInsertion, strKey1);
            elapsedTime.Add(watch.ElapsedTime());

            ////Displaying contents of Array After all sorting and binary search operation has performed
            Console.WriteLine();
            Console.WriteLine("Integers sorted with insertion");
            Utility.PrintArray(arrToBeSortedUsingInsertion);

            Console.WriteLine();
            Console.WriteLine("Integers sorted with bubble");
            Utility.PrintArray(arrToBeSortedUsingBubble);

            Console.WriteLine();
            Console.WriteLine("String sorted with bubble");
            Utility.PrintArray(strarrToBeSortedUsingBubble);

            Console.WriteLine();
            Console.WriteLine("String sorted with insertion");
            Utility.PrintArray(strarrToBeSortedUsingInsertion);


            Console.WriteLine();

            if (posForIntegerBinarySearch == -1)
                Console.WriteLine(key1 + " Not found");
            else
                Console.WriteLine("   " + key1 + " found at position: " + ++posForIntegerBinarySearch);

            Console.WriteLine();

            if (posForStringBinarySearch == -1)
                Console.WriteLine(strKey1 + " Not found");
            else
                Console.WriteLine("   " + strKey1 + " found at position: " + ++posForStringBinarySearch);


            Console.WriteLine();
            Console.WriteLine("Elapsed Time for each function calls in descending order");
            elapsedTime.Reverse();

            foreach (int time in elapsedTime)
            {
                Console.Write(" " + time + "ms" + " ");
            }















        }

    }
}

