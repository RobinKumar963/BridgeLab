// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Gambler.cs" company="Bridgelabz">
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
    /// 
    /// </summary>
    class Gambler
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Stake:");
            Double stake = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter goal:");
            int goal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter times:");
            int times = Convert.ToInt32(Console.ReadLine());
            int i = times;

            Double win = 0, loss = 0, baitAmount;
            float baitResult;
            Random rand = new Random();
            while (i != 0)
            {
                Console.Clear();
                Console.WriteLine("Enter amount to keep bait");
                baitAmount = Convert.ToInt32(Console.ReadLine());
                baitResult = rand.Next(0, 2);

                if (baitResult < 0.5)
                {
                    Console.WriteLine("loss");
                    Console.ReadKey();
                    loss++;
                    stake -= baitAmount;
                }
                else
                {
                    Console.WriteLine("Won");
                    Console.ReadKey();
                    win++;
                    stake += baitAmount;
                }
                if (stake <= 0)
                    break;
                if (stake >= goal)
                    break;
                
                i--;


            }
         

            Console.WriteLine("Number of time played:" + times);

            Console.WriteLine("Number of win:" + win);
            Console.WriteLine("Number of loss"+ loss);

            Console.WriteLine("Win percentage:{0}%", (win / times) * 100);
            Console.WriteLine("Loss percentage:{0}%", (loss / times) * 100);




        }
    }
}
