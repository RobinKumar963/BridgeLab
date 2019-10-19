// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Distance.cs" company="Bridgelabz">
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
    /// Prints Eucladeian distance from origin(0,0) to pointA(x,y)
    /// </summary>
    class Distance
    {
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(String[] args)
        {
            String[] argv = { "45", "54" };
            int x = Convert.ToInt32(args[0]);
            int y = Convert.ToInt32(args[1]);
            Double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            Console.WriteLine("Distance from origin(0,0) is " + distance);
        }
    }
}
