// --------------------------------------------------------------------------------------------------------------------
// <copyright file=VendingMachine.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------






using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.Algorithm
{
    /// <summary>
    /// Render Change with minimum notes
    /// </summary>
    class VendingMachine
    {


        /// <summary>
        /// Finds the change recursively.
        /// </summary>
        /// <param name="change">The change.</param>
        /// <param name="demonition">The demonition.</param>
        /// <param name="renderChange">The render change.</param>
        /// <param name="capacity">The capacity.</param>
        /// <param name="cIndex">Index of the c.</param>
        /// <param name="count">The count.</param>
        public static void FindChange(int change, int[] demonition, int[] renderChange, int[] capacity, int cIndex, double count)
        {
            int n;

            if ((cIndex < 0) || (change == 0))  //base condn
            {
                ////base condition
                for (int i = 0; i < renderChange.Length; i++)
                {

                    if (renderChange[i] != 0)
                    {
                        Console.WriteLine("Rs." + demonition[i] + "   x     "  + renderChange[i] + "  =   RS." + renderChange[i] * demonition[i]);
                    }


                }
                  Console.WriteLine("Total notes:" + count);
                return;



            }
            else if (change >= demonition[cIndex])
            {

                n = change / demonition[cIndex];

                if (capacity[cIndex] >= n)
                {

                    renderChange[cIndex] = n;
                    capacity[cIndex] = capacity[cIndex] - n;
                    change = change - (n * demonition[cIndex]);


                    FindChange(change, demonition, renderChange, capacity, cIndex - 1, count + n);
                }
            }
            else
            {
                FindChange(change, demonition, renderChange, capacity, cIndex - 1, count);

            }

        }
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(String[] args)
        {

            int[] demonition = { 1, 2, 5, 10, 50, 100, 500, 1000 };
            int[] capacity = { 100, 100, 100, 100, 100, 100, 100, 100 };
            int[] renderChange = { 0, 0, 0, 0, 0, 0, 0, 0 };


            ////Accept the change to be rendered by user through console
            Console.WriteLine("Enter change to be rendered:");
            int change = Convert.ToInt32(Console.ReadLine()); 
           

            
            FindChange(change, demonition, renderChange, capacity, demonition.Length - 1, 0);



        }

    }
}
