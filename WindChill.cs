// --------------------------------------------------------------------------------------------------------------------
// <copyright file=WindChill.cs" company="Bridgelabz">
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
    /// Calculate wind chill
    /// </summary>
    class WindChill
    {
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(String[] args)
        {
            String[] argv = {"97","45"};

            Double t = Convert.ToDouble(args[0]);
            Double v = Convert.ToDouble(args[1]);

            double w = 35.74 + (0.6215 * t) + ((0.4275*t) - 35.75) * Math.Pow(v,0.16);

            Console.WriteLine(w);
         
        }
    }
}




















