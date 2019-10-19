// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Quadratic.cs" company="Bridgelabz">
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
    /// Compute root of quadratic Equation
    /// </summary>
    class Quadratic
    {
        /// <summary>
        /// Handle negative value exception,used when delta computes to neghative
        /// </summary>
        /// <seealso cref="System.Exception" />
        public class NegativeValueException : Exception
        {
            public NegativeValueException(string message) : base(message)
            {

            }
        }
        /// <summary>
        /// Finds the root of Quadratic Equation.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        /// <param name="delta">The delta.</param>
        public static void FindRoot(Double a,Double b,Double c,Double delta)
        {
            Double root1 = ((-1 * b) + Math.Sqrt(delta)) / (2 * a);
            Double root2 = ((-1 * b) - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("Root1 = " + root1);
            Console.WriteLine("Root2 = " + root2);

        }
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <exception cref="Bridgelabz.FunctionalProgram.Quadratic.NegativeValueException">Sqrt of delta cant be obtained</exception>
        public static void Main(String[] args)
        {
            Double a = Convert.ToDouble(Console.ReadLine());
            Double b = Convert.ToDouble(Console.ReadLine()); 
            Double c = Convert.ToDouble(Console.ReadLine());
            Double delta = (b * b) - (4 * a * c); 
            try
            {

                if (delta < 0)
                {
                    throw (new NegativeValueException("Sqrt of delta cant be obtained"));
                    
                }
                else
                    FindRoot(a, b, c, delta);
            }
            catch (NegativeValueException e)
            {
                Console.WriteLine("Delta is negative: {0}", e.Message);
            }
           




        }
    }
}
