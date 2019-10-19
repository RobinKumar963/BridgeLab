// --------------------------------------------------------------------------------------------------------------------
// <copyright file=BinarySearchTree.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DataStructure
{
    /// <summary>
    /// Number of binary search tree (Using Catalan Formula)
    /// </summary>
    class BinarySearchTree
    {
        static int UniqueBSTs(int n)
        {
            int n1, n2, sum = 0;

            ////Base cases 
            if (n == 1 || n == 0)
                return 1;

            ////Find the nth Catalan number 
            for (int i = 1; i <= n; i++)
            {

                ////Recursive calls 
                n1 = UniqueBSTs(i - 1);
                n2 = UniqueBSTs(n - i);
                sum += n1 * n2;
            }

            ////Return the nth Catalan number 
            return sum;
        }

        
        public static void Main(String[] args)
        {
            ////Number of test cases
            int T = Convert.ToInt32(Console.ReadLine());

            int[] input = new int[T];
            //// T input
            for (int i = 0; i < T;i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());
            }
            ////T output
            for (int i = 0; i < T; i++)
            {
                Console.WriteLine(UniqueBSTs(input[i]));
            }

           

            return;
        }
    }
}
