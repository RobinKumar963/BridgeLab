// --------------------------------------------------------------------------------------------------------------------
// <copyright file=PermutationWithRecursionAndIteration.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridgelabz.FunctionalProgram
{
    /// <summary>
    /// Find permutation of string
    /// </summary>
    class PermutationWithRecursionAndIteration
    {
        static int index = 0;
        public static void PermutationWithIteration(string s, String[] permutationWithIteration)
        {
            int n = s.Length,i,j;

            // Weight index control array initialized by 0
            int[] p = new int[n];
            for (i = 0; i < n; i++)
            {
                // p[i] == i controls iteration and index boundaries for i
                p[i] = 0;
            }

            // i, j represents upper and lower bound index respectively for swapping
            i = 1; j = 0;

            // Print given string, as only its permutations will be printed later
            permutationWithIteration[index] = s;
            index++;

            while (i < n)
            {
                if (p[i] < i)
                {
                    // if i is odd then j = p[i], otherwise j = 0
                    j = (i % 2) * p[i];

                    s = swap(s,j,i);

                    // Print current permutation
                    permutationWithIteration[index] = s;
                    index++;
                    p[i]++; // increase index "weight" for i by one
                    i = 1;  // reset index i to 1
                }
                // otherwise p[i] == i
                else
                {
                    // reset p[i] to zero
                    p[i] = 0;

                    // set new index value for i (increase by one)
                    i++;
                }
            }
            index = 0;

        }




        public static void PermutationWithRecursion(string a,String[]permutationWithRecursion,int l, int r)
        {
            // Base case  
            if(index > fact(a.Length)-1)
            {
                index = 0;
                return;
            }
            if (l == r)
            {
                permutationWithRecursion[index] = a;
               
                //Console.WriteLine(permutationWithRecursion[index]+ " " + index);
                index++;

            }
            else
            {
                // Permutations made  
                for (int i = l; i <= r; i++)
                {

                    // Swapping done  
                    a = swap(a,l,i);

                    // Recursion called  
                    PermutationWithRecursion(a,permutationWithRecursion,l + 1, r);

                    //backtrack  
                    a = swap(a,l,i);
                }
            }
        }
































        public static String swap(String a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }


        public static int fact(int N)
        {
            
            if (N == 0)
                return 1;

            return N * fact(N - 1);

        }
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter String:");
            String str = Console.ReadLine();
            Console.WriteLine();

            String[] permutationWithRecursion = new string[fact(str.Length)];
            String[] permutationWithIteration = new string[fact(str.Length)];
            PermutationWithRecursion(str,permutationWithRecursion,0,str.Length-1);
            index = 0;
            PermutationWithIteration(str,permutationWithIteration);
            Console.WriteLine("\nPermutation with recursion:");
            Algorithm.Utility.PrintArray(permutationWithRecursion);

            Console.WriteLine("\nPermutation with iteration:");
            Algorithm.Utility.PrintArray(permutationWithIteration);

            IEnumerable<String> differenceOfTwoPermutationResult = permutationWithRecursion.Except(permutationWithIteration);
            
            Array.Sort(permutationWithRecursion);
            Array.Sort(permutationWithIteration);

            int flag = 1;
            for(int i=0;i<permutationWithRecursion.Length;i++)
            {
                if (permutationWithRecursion[i] != permutationWithIteration[i])
                {
                    flag = 0;
                    break;
                }

            }





            if (flag == 1)
                Console.WriteLine("\nBoth Permutation are anagram i.e equal");
            else
                Console.WriteLine("\nBoth permutation are not equal");



        }
        
    }
}
