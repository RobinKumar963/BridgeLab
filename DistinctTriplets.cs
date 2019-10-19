// --------------------------------------------------------------------------------------------------------------------
// <copyright file=DistinctTriplets.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------





using System;

namespace Bridgelabz.FunctionalProgram
{

    /// <summary>
    /// Find distinct triplet which sum up to 0
    /// </summary>
    public class DistinctTriplets
    {


        /// <summary>
        /// Find all combination of 3 and check if its sum is 0.if 0 just print triplets
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <param name="data">The data.</param>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        /// <param name="index">The index.</param>
        /// <param name="r">The r.</param>
        public static void CombinationUtil(int[] arr, int[] data, int start,
                                    int end, int index, int r)
        {

            if (index == r)
            {
                int sum = 0;
                for (int j = 0; j < r; j++)
                    sum = sum + data[j];


                if (sum == 0)
                    for (int j = 0; j < r; j++)
                        Console.Write(data[j] + " ");

                return;
            }


            for (int i = start; i <= end && end - i + 1 >= r - index; i++)
            {

                data[index] = arr[i];
                CombinationUtil(arr, data, i + 1, end, index + 1, r);
            }

        }


        static void PrintCombination(int[] arr, int n, int r)
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
















        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(String[] args)
        {



            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            for (int i = 0; i < num; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());
            int r = 3;
            int n = arr.Length;
            PrintCombination(arr, n, r);


        }



    }
}