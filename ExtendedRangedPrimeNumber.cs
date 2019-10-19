// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ExtendedRangedPrimeNumber.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DataStructure
{
    /// <summary>
    /// Print prime number within Range-1000
    /// </summary>
    class ExtendedRangedPrimeNumber
    {

        /// <summary>
        /// Generate different combination which are both prime number and anagram.
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <param name="data">The data.</param>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        /// <param name="index">The index.</param>
        /// <param name="r">The r.</param>
        public static void CombinationUtil(int[] arr,int[] data, int start,
                                    int end, int index, int r)
        {

            if (index == r)
            {
                
                if(Algorithm.Utility.CheckPrime(data[0]) && Algorithm.Utility.CheckPrime(data[1]) && Algorithm.Utility.AreAnagram(data[0].ToString(),data[1].ToString()))
                {
                    Console.Write("{0} {1}\t\t",data[0],data[1]);
                }

                return;
                
            }


            for (int i = start; i <= end && end - i + 1 >= r - index; i++)
            {

                data[index] = arr[i];
                CombinationUtil(arr, data, i + 1, end, index + 1, r);
            }
            
        }

        /// <summary>
        /// Prints the combination of n elements in r combination.
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <param name="n">The n.</param>
        /// <param name="r">The r.</param>
        public static void PrintCombination(int[] arr, int n, int r)
        {

            int[] data = new int[r];
            ////sorting here

            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                ////Move elements of arr[0..i-1], that are 
                ////greater than key, to one position ahead 
                ////of their current position 
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            ////end of sorting
            CombinationUtil(arr, data, 0, n - 1, 0, r);
        }














        public static void Main(String[] args)
        {
            int range = 1000;
            Nullable<int>[,] prime_Number = new Nullable<int>[range / 100, range / 10];


            ////Printing prime number in the range of 1000
            for (int i = 0; i < range / 100; i++)
            {
                for (int j = 100 * i, ind = 0; ind < range / 10; j++, ind++)
                {

                    if (Algorithm.Utility.CheckPrime(j))
                    {
                        prime_Number[i, ind] = j;
                    }
                    else
                        prime_Number[i, ind] = null;


                }

            }
            

            

            
            
            ////Printing Numbers anagram in the range 1000
            int[] currentRow = new int[range / 10]; 
            for(int k=0;k<range/100;k++)
            {
                for (int i = 0, value = 100 * k; i < range / 10; i++,value++)
                {
                    currentRow[i] = value;
                    
                    
                }
                PrintCombination(currentRow, currentRow.Length, 2);
                Console.WriteLine();
            }
            

           

            


        }
    }
}
