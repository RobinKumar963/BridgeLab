// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Utility.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------





using System;
using System.Collections.Generic;

namespace Bridgelabz.Algorithm
{
    /// <summary>
    /// Utility class featuring commonly used operation
    /// </summary>
    public class Utility {


        public static bool AreAnagram(string str1, string str2)
        {
            // Get lengths of both strings 
            int n1 = str1.Length;
            int n2 = str2.Length;

            // If length of both strings is not same, then they 
            // cannot be anagram 
            if (n1 != n2)
                return false;

            // Sort both the strings 

            str1 = InsertionSort(str1);
            str2 = InsertionSort(str2);

            // Compare sorted strings 
            for (int i = 0; i < n1; i++)
                if (str1[i] != str2[i])
                    return false;

            return true;
        }




        /// <summary>
        /// Checks for anagram.
        /// This uses xor approach for checking even occurence i.e equality.
        /// </summary>
        /// <param name="str1">The STR1.</param>
        /// <param name="str2">The STR2.</param>
        /// <returns>true or false</returns>

        public static Boolean CheckForAnagram(string str1, string str2) {
            if (str1.Length != str2.Length) {
                return false;
            }
            int value = 0;
            for (int i = 0; i < str1.Length; i++) {
                value = value ^ (int)str1[i];
                value = value ^ (int)str2[i];
            }
            return value == 0;
        }


        /// <summary>
        /// Determines whether the specified string is palindrome.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>
        ///   <c>true</c> if the specified string is palindrome; otherwise, <c>false</c>.
        /// </returns>
        public static Boolean IsPalindrome(String str) {
            int flag = 1;
            for (int i = 0, j = str.Length - 1; i <= j; i++, j--) {
                if (str[i] != str[j])
                    flag = 0;

            }

            return flag == 1;
        }


        /// <summary>
        /// Checks the prime.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns>True or False</returns>
        public static Boolean CheckPrime(int n) {
            int flag = 1;

            if (n == 0 || n == 1)
                flag = 0;


            for (int i = 2; i <= n / 2; i++) {
                if (n % i == 0)
                    flag = 0;
            }
            return flag == 1;
        }


        /// <summary>
        /// Prints the prime number.
        /// </summary>
        /// <param name="range">The range.</param>
      public static void PrintPrimeNumber(int range) {
            for (int i = 2; i <= range; i++) {
                if (CheckPrime(i))
                    Console.WriteLine(i);
            }

        }


        /// <summary>
        /// Function to Return dayofweek for  date in d/m/y
        /// </summary>
        /// <param name="d">The d.</param>
        /// <param name="m">The m.</param>
        /// <param name="y">The y.</param>
        /// <returns>d1</returns>
        public static int DayOfWeek(int d, int m, int y)
        {
            int y1, x, m1, d1;
            y1 = y - (14 - m) / 12;
            x = y1 + y1 / 4 - y1 / 100 + y1 / 400;
            m1 = m + 12 * ((14 - m) / 12) - 2;
            d1 = (d + x + 31 * m1 / 12) % 7;
            return d1;
        }


        /// <summary>
        /// Genericbubbles the sort.
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <param name="arr">The arr.</param>
        public static void GenericbubbleSort<E>(E[] arr) where E : IComparable<E>  //working as ,string array are mutable
        {



            int n = arr.Length;


            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        // swap arr[j+1] and arr[i]
                        E temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }

        /// <summary>
        /// Genericinsertions the sort.
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <param name="arr">The arr.</param>
        public static void GenericinsertionSort<E>(E[] arr) where E : IComparable<E>
        {




            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                E key = arr[i];
                int j = i - 1;

                /* Move elements of arr[0..i-1], that are
				   greater than key, to one position ahead
				   of their current position */
                while (j >= 0 && arr[j].CompareTo(key) > 0)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }

        }

        /// <summary>
        /// Generic binaries the search.
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <param name="arr">The arr.</param>
        /// <param name="key">The key.</param>
        /// <returns>m</returns>
        public static int GenericbinarySearch<E>(E[] arr, E key) where E : IComparable<E>
        {


            int low = 0, high = arr.Length - 1, m = -1, flag = -1;
            int comparisonResult;
            while (low <= high)
            {
                m = (low + high) / 2;
                comparisonResult = key.CompareTo(arr[m]);

                if (comparisonResult == 0)
                {
                    flag = 1;
                    break;
                }
                else if (comparisonResult > 0)
                    low = m + 1;
                else
                    high = m - 1;
            }

            if (flag == 1)
                return m;
            else
                return -1;
        }


        /// <summary>
        /// Non generic Binaries the search for integer array.
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public static int BinarySearch(int[] arr, int key)
        {

            int low = 0, high = arr.Length, flag = 0, m = -1;

            while (low <= high)
            {
                m = (low + high) / 2;
                if (arr[m] == key)
                {
                    flag = 1;
                    break;
                }
                else if (key > arr[m])
                    low = m + 1;
                else
                    high = m - 1;
            }

            if (flag == 1)
                return m;
            else
                return -1;
        }

        /// <summary>
        /// Non generic Binaries the search for string array.
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public static int BinarySearch(String[] arr, String key)
        {
            int low = 0, high = arr.Length - 1, m = -1, flag = 0, comparisonResult;
            while (low <= high)
            {
                m = (low + high) / 2;

                comparisonResult = key.CompareTo(arr[m]);
                if (comparisonResult == 0)
                {
                    flag = 1;
                    break;
                }
                else if (comparisonResult > 0)
                    low = m + 1;
                else
                    high = m - 1;
            }

            if (flag == 1)
                return m;
            else
                return -1;

        }

        /// <summary>
        /// Non Generic Method For BinarySearch(character)
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public static int BinarySearch(String str, char key)
        {
            int low = 0, high = str.Length - 1, m = -1, flag = 0;
            while (low <= high)
            {
                m = (low + high) / 2;

                if (key == str[m])
                {
                    flag = 1;
                    break;
                }
                else if (key > str[m])
                    low = m + 1;
                else
                    high = m - 1;
            }

            if (flag == 1)
                return m;
            else
                return -1;

        }


        /// <summary>
        /// Non-generic method for insertion sort(integer).
        /// </summary>
        /// <param name="arr">The arr.</param>
        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }


        }

        /// <summary>
        /// Non-generic method for insertion sort(String)
        /// </summary>
        /// <param name="arr">The arr.</param>
        public static void InsertionSort(String[] arr) //working as ,string array are mutable
        {

            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                String key = arr[i];
                int j = i - 1;

                /* Move elements of arr[0..i-1], that are
				   greater than key, to one position ahead
				   of their current position */
                while (j >= 0 && arr[j].CompareTo(key) > 0)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
        //Non Generic Insertion sort for String
        
		public static String InsertionSort(String str)
		{
            char[] s = str.ToCharArray();
			int n = s.Length;
			for (int i = 1; i < n; ++i) 
            {
				char key = s[i];
				int j = i - 1;


				while (j >= 0 && s[j] > key) {
					s[j+1] = str[j];
					j = j - 1;
				}
				s[j+1] = key;
			}
            return new String(s);

		}

		


        /// <summary>
        /// Non generic method Bubble sort for Integer
        /// </summary>
        /// <param name="arr">The arr.</param>
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        // swap arr[j+1] and arr[i]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }

        /// <summary>
        /// Non generic method Bubble sort for String
        /// </summary>
        /// <param name="arr">The arr.</param>
        public static void BubbleSort(String[] arr)  //working as ,string array are mutable
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        // swap arr[j+1] and arr[i]
                        String temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }

        //Non generic method Bubble sort for String
        /*
            void bubbleSort(String str) //not working as ,string  are immutable
            {
                int n = str.length();
                for (int i = 0; i < n-1; i++)
                    for (int j = 0; j < n-i-1; j++)
                        if (str.charAt(j) > str.charAt(j+1))
                        {
                            // swap arr[j+1] and arr[i]
                            char temp = str.charAt(j);
                            str.charAt(j) = str.charAt(j+1);
                            str.charAt(j+1) = temp;
                        }
            }
        */
        /// <summary>
        /// Merge Sorting function that sorts arr[l..r] using merge().
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <param name="l">The l.</param>
        /// <param name="r">The r.</param>
        public static void Sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                ////Find the middle point
                int m = (l + r) / 2;

                ////Sort first and second halves
                Sort(arr, l, m);
                Sort(arr, m + 1, r);

                ////Merge the sorted halves
                Merge(arr, l, m, r);
            }
        }

        /// <summary>
        /// Function to merge sorted array.
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <param name="l">The l.</param>
        /// <param name="m">The m.</param>
        /// <param name="r">The r.</param>
        public static void Merge(int[] arr, int l, int m, int r)
        {
            ////Find sizes of two subarrays to be merged
            int n1 = m - l + 1;
            int n2 = r - m;
            int i, j;
            ////Create temp arrays
            int[] L = new int[n1];
            int[] R = new int[n2];

            ////Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];


            ////Merge the temp arrays

            ////Initial indexes of first and second subarrays
            i = 0; j = 0;

            ////Initial index of merged subarry array
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            ////Copy remaining elements of L[] if any 
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            ////Copy remaining elements of R[] if any 
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }



        /// <summary>
        /// Calculate Payment to incured in a month.
        /// </summary>
        /// <param name="P">The p.</param>
        /// <param name="Y">The y.</param>
        /// <param name="R">The r.</param>
        /// <returns>payment</returns>
        public static Double MonthlyPayment(Double P, Double Y, Double R)
        {
            Double n = 12 * Y;
            Double r = R / 1200;
            Double payment = (P * r) / (1 - (1 / Math.Pow(1 + r, n)));
            return payment;
        }


        /// <summary>
        /// convert temprature to celseis from farenheit or vice versa.
        /// </summary>
        /// <param name="temprature">The temprature.</param>
        /// <param name="type">The type.</param>
        /// <returns>new temprature</returns>
        public static Double TemperatureConversion(Double temprature, String type)
        {

            if (type.CompareTo("C") == 0)
                return (temprature * 9 / 5) + 32;

            else if (type.CompareTo("F") == 0)
                return (temprature - 32) * 5 / 9;
            else
                return -1.0;

        }


        /// <summary>
        /// generic method printArray
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <param name="inputArray">The input array.</param>
        public static void PrintArray<E>(E[] inputArray)
        {
            // Display array elements
            foreach (E element in inputArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }


        /// <summary>
        /// generic method print2DArray.
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <param name="inputArray">The input array.</param>
        /// <param name="rowLimit">The row limit.</param>
        /// <param name="colLimit">The col limit.</param>
        public static void Print2DArray<E>(E[,] inputArray, int rowLimit, int colLimit)
        {
            // Display array elements
            for (int i = 0; i < rowLimit; i++)
            {
                for (int j = 0; j < colLimit; j++)
                {

                    if (inputArray[i, j].Equals('\0'))
                        Console.Write(" _ " + "     ");
                    else
                        Console.Write(inputArray[i, j] + "     ");

                }
                Console.WriteLine();

                Console.WriteLine("_____________");
            }
            Console.WriteLine();
        }
        public static void Print2DimensionArray<E>(E[,] inputArray, int rowLimit, int colLimit)
        {
            Console.WriteLine();
            // Display array elements
            for (int i = 0; i < rowLimit; i++)
            {
                for (int j = 0; j < colLimit; j++)
                {

                    if(inputArray[i,j] != null)
                        Console.Write("{0} ",inputArray[i, j]);

                }
                Console.WriteLine();

                
            }
            return;
        }





        /*
            // non generic method to print array
            public static void printArray(int arr[])
            {

                for (int i=0; i<arr.length; ++i)
                    System.out.print(arr[i] + " ");
                System.out.println();
            }

            public static void printArray(String arr[])
            {

                for (int i=0; i<arr.length; ++i)
                    System.out.print(arr[i] + " ");
                System.out.println();
            }


         */



    }

}