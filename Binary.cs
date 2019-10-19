// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Binary.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------



using System;
namespace Bridgelabz.Algorithm
{
    
    
    /// <summary>
    /// convert decimal to binary and Vice versa
    /// Consists of method to swap nibble and display modified value
    /// </summary>
    public class Binary 
    {

        /// <summary>
        /// Decimal To the binary.
        /// </summary>
        /// <param name="dec">The decimal.</param>
        /// <returns>binary</returns>
        static int ToBinary(int dec)
        {
            int rem; int binary = 0; int i = 0;


            while (dec != 0)
            {
                rem = dec % 2;
                dec = dec / 2;
                binary = rem * (int)Math.Pow(10, i) + binary;
                i++;
            }

            return binary;
        }





        /// <summary>
        ///Binary  To the decimal.
        /// </summary>
        /// <param name="binary">The binary.</param>
        /// <returns>dec</returns>
        static int ToDecimal(String binary)
        {
            int dec = 0;
            for (int i = 0, j = binary.Length - 1; i < binary.Length; i++, j--)
            {
                if (binary[j] == '1')
                    dec = dec + (int)Math.Pow(2, i);
            }
            return dec;
        }




        
        
        
        
        
        
        
        
        /// <summary>
        /// Swaps the nibble 
        /// </summary>
        /// <param name="x">The x.</param>
        /// <returns>Integer value obtained after swapping its Nibble.</returns>
        static int SwapNibble(int x)
        {
            ////bitwise operation
            ////x & 0x0F gives us last 4 bits of x
            ////x & 0xF0 gives us first four bits of x
            ////OR operator(|) places first nibble to the end and last nibble to first
            return ((x & 0x0F) << 4 | (x & 0xF0) >> 4);
        }





        /// <summary>
        /// Determines whether [is power of two] [the specified n].
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns>
        ///   <c>true</c> if [is power of two] [the specified n]; otherwise, <c>false</c>.
        /// </returns>
        static Boolean IsPowerOfTwo(int n)
        {
            if (n == 0)
                return false;

            while (n != 1)
            {
                if (n % 2 != 0)
                    return false;
                n = n / 2;
            }
            return true;
        }






        /// <summary>
        /// Mains the specified arguments.
        /// take decimal number from user through console and uses above method
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(String[] args) {

            
            ////Accept Decimal Number from User throgh Console
            Console.WriteLine("Enter num:");
            int num = Convert.ToInt32(Console.ReadLine());

            ////Obtain binary from ToBinary(Decimal)
            String binary = ToBinary(num).ToString().PadLeft(8,'0');
            Console.WriteLine("In binary - " + binary);
            Console.WriteLine("In decimal - " + ToDecimal(binary));

            ////Obtained resulting value obtained after swapping its Nibble
            int v = SwapNibble(num);
            Console.WriteLine("after swapping - " + v);
            Console.WriteLine("Number power of two - " + IsPowerOfTwo(v));
        }

    }
}