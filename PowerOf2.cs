// --------------------------------------------------------------------------------------------------------------------
// <copyright file=PowerOf2.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------





using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.FunctionalProgram
{
    /// <summary>
    /// Print table of powers of two till N.
    /// </summary>
    class PowerOf2
    {
        /// <summary>
        /// Exception to handle if N > 31
        /// </summary>
        /// <seealso cref="System.Exception" />
        public class OutOfRangeException : Exception
        {
            public OutOfRangeException(string message) : base(message)
            {

            }
        }


        /// <summary>
        /// Prints the power table of 2 till N.
        /// </summary>
        /// <param name="N">The n.</param>
        public static void printPowerTable(int N)
        {

            for (int i = 1; i <= N; i++)
                Console.WriteLine(Math.Pow(2, i));
        }
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <exception cref="Bridgelabz.FunctionalProgram.PowerOf2.OutOfRangeException">N out of Range..( > 31)</exception>
        public static void Main(String[] args)
        {
            String[] argv = {"32"};

            try
            {
                if(Convert.ToInt32(args[0]) > 31)
                {
                    throw (new OutOfRangeException("N out of Range..( > 31)"));
                }
                else
                    printPowerTable(Convert.ToInt32(args[0]));

            }
            catch (OutOfRangeException e)
            {
                Console.WriteLine("N is bigger than 31: {0}", e.Message);
            }
           

        }
    }
}
