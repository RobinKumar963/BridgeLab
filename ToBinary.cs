// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ToBinary.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------



using System;
namespace Bridgelabz.Algorithm
{
    /// <summary>
    /// Convert Decimal to Binary
    /// </summary>
    public class ToBinary 
    {
        /// <summary>
        /// compute a^n.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="n">The n.</param>
        /// <returns>a</returns>
        static int Pow(int a, int n)
        {
            int pow = a;
            if (n == 0)
                return 1;
            for (int i = 1; i < n; i++)
            {
                a = a * pow;

            }
            return a;
        }
        /// <summary>
        /// To the binary.
        /// </summary>
        /// <param name="dec">The decimal.</param>
        /// <returns>binary</returns>
        static int ConvertToBinary(int dec)
        {
            int rem; int binary = 0; int i = 0;


            while (dec != 0)
            {
                ////gives reminder
                rem = dec % 2;
                ////gives next number to be divided by 2 and reminder to obtained
                dec = dec / 2;
                binary = rem * Pow(10, i) + binary;
                i++;
            }

            return binary;
        }

        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(String[] args) {


            Console.WriteLine("Enter num:");
            int num = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(ConvertToBinary(num).ToString().PadLeft(8,'0'));


        }
    }
}

	
