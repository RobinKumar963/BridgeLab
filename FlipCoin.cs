// --------------------------------------------------------------------------------------------------------------------
// <copyright file=FlipCoin.cs" company="Bridgelabz">
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
    /// Flip coin N times and calculate Percentage of head and tail
    /// </summary>
    class FlipCoin
    {

        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(String[] args)
        {
            int times;float headOrTail;Double headCount = 0, tailCount = 0;

            while(true)
            {
                Console.Clear();
                Console.WriteLine("Enter number of times to flip coin");
                times = Convert.ToInt32(Console.ReadLine());

                if(times < 0)
                {
                    Console.WriteLine("Number is negative:....Press any key to Enter again");
                    Console.ReadLine();
                    continue;
                }
                else
                {
                    break;
                }

            }

            Random rand = new Random();
            for(int i = 0; i < times; i++)
            {
                headOrTail = rand.Next(0, 2);

                if (headOrTail < 0.5)
                {
                    tailCount++;
                }
                else
                {
                    headCount++;
                }


            }

            Double percentageOfHead = (headCount/times) * 100;
            Double percentageOfTail = (tailCount/times) * 100;

            Console.WriteLine("Percntage of head: " + percentageOfHead + "%");
            Console.WriteLine("Percntage of tail: " + percentageOfTail + "%");




        }
    }
}
