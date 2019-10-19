// --------------------------------------------------------------------------------------------------------------------
// <copyright file=PrimeNumber.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------



using System;

namespace Bridgelabz.Algorithm
{

    /// <summary>
    /// Display prime number within range.Uses Algorithm.Utility.PrintPrimeNumber
    /// </summary>
    public class PrimeNumber {
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(String[] args)
        {
            
            ////Accept range till where prime number has to be displayed
            Console.WriteLine("Enter range:");
            int range = Convert.ToInt32(Console.ReadLine());
            ////print prime number within range
            Utility.PrintPrimeNumber(range);



        }

    }
}
