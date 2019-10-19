// --------------------------------------------------------------------------------------------------------------------
// <copyright file=PrimeNumberAnagramPalindrome.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------




using System;
namespace Bridgelabz.Algorithm
{

    /// <summary>
    /// Generate Prime number within range which is palindrome and anagram
    /// </summary>
    public class PrimeNumberAnagramPalindrome {
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(String[] args) {


            ////Accept range from user through Console
            Console.WriteLine("Enter range:");
            int range = Convert.ToInt32(Console.ReadLine());
            
            ////iterate through 1 to range. 
            ////Uses Utility.CheckPrime and Utility.IsPalindrome and Utility.AreAnagram
            ////Finally,Print each prime number,which is palindrome and are anagram
            for (int i = 1; i <= range; i++)
            {
               Console.WriteLine();

                if (Utility.CheckPrime(i))
                {
                    Console.Write(i);
                    if (Utility.IsPalindrome(i.ToString()))
                        Console.WriteLine("        This is Palindrome    ");
                }
            }

        }

    }
}
