// --------------------------------------------------------------------------------------------------------------------
// <copyright file=HarmonicSeries.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------





using System;

namespace Bridgelabz.FunctionalProgram
{
    /// <summary>
    /// Find harmonic series upto N
    /// </summary>
    public class HarmonicSeries
    {


        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(String[] args)
        {
            int num;
            while(true)
            {
                Console.Clear();
                Console.WriteLine("number here:");
                num = Convert.ToInt32(Console.ReadLine());
                if (num <= 0)
                {
                    Console.WriteLine("Invalid Value.....Press any key to continue");
                    Console.ReadKey();

                }
                else
                    break;

            }


            float sum = (float)0.0;
            Console.WriteLine();
            for (float i = 1; i <= num; i++)
            {

                Console.Write(" (1/{0}) ",i);
                if (i != num)
                    Console.Write(" + ");
                else
                    Console.Write(" = ");

                sum = (sum + 1 / i);

            }
            
            Console.Write(sum);

        }

    }
}
