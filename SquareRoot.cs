// --------------------------------------------------------------------------------------------------------------------
// <copyright file=SquareRoot.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------





using System;
namespace Bridgelabz.Algorithm
{
    /// <summary>
    /// Calculate square root of non negative number using Newton's Method
    /// </summary>
    public class SquareRoot 
    {
        /// <summary>
        /// Used to handle negative value exception
        /// </summary>
        /// <seealso cref="System.Exception" />
        public class NegativeValueException : Exception
        {
            public NegativeValueException(string message) : base(message)
            {

            }
        }
        /// <summary>
        /// Calculates the square root using newton method.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns></returns>
        public static Double CalculateSquareRoot(Double c)
        {
            double t = c;
            double epsilon = 1 / Math.Exp(15);
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                //replace t with the average of c/t and t

                t = (c / t + t) / 2;

            }

            return t;

        }

        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <exception cref="Bridgelabz.Algorithm.SquareRoot.NegativeValueException">Sqrt of delta cant be obtained</exception>
        public static void Main(String[] args) 
        {
            ////Accept number from user through console,for which square root has to be calculated
            Double c = Convert.ToDouble(Console.ReadLine());
            ////Detect for negative value of c exception
            try
            {

                if (c < 0)
                    throw (new NegativeValueException("Sqrt of negative number cant be obtained"));
                else
                    Console.WriteLine("Square root is:"+ CalculateSquareRoot(c));
            }
            catch (NegativeValueException e)
            {
                Console.WriteLine("Negative Value Exception: {0}", e.Message);
            }
            finally
            {
                CalculateSquareRoot(c);
            }


        }

    }
}
