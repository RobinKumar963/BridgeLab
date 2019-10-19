using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.Algorithm
{
    class MergeSort
    {
        public static void Main(String[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter an array");
            for(int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Utility.Sort(arr, 0, arr.Length - 1);
            Utility.PrintArray(arr);
        }
    }
}
