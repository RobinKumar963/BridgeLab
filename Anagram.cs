// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Anagram.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------


using System;
namespace Bridgelabz.Algorithm
{
    /// <summary>
    /// Validate if Two String is anagram or not.Uses Algorithm.Utility.AreAnagram()
    /// </summary>
    public class Anagram
    {
        /// <summary>
        /// Mains the specified arguments.
        /// calls Algorithm.Utility.CheckForAnagram
        /// </summary>
        /// <param name="args">The arguments...</param>
        public static void Main(String[] args)
        {
            ////Accept two string from user through Console
            Console.WriteLine("Enter str1:");
            String str1 = Console.ReadLine();
            Console.WriteLine("Enter str2:");
            String str2 = Console.ReadLine();

            ////Check weather two strings are anagram or not
            if (Utility.AreAnagram(str1, str2))
                Console.WriteLine("The two strings are anagram of each other");
            else
                Console.WriteLine("The two strings are not anagram of each other");

        }

    }
}


