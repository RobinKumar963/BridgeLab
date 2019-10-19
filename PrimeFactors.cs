// --------------------------------------------------------------------------------------------------------------------
// <copyright file=PrimeFactors.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------





using System;
namespace Bridgelabz.FunctionalProgram
{
    /// <summary>
    /// Compute prime fractor of N
    /// </summary>
    public class PrimeFactors
    {

        /// <summary>
        /// Checks if Number num is prime or not.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        public static Boolean CheckPrime(int n)
        {


            int flag = 1;

            if (n == 0 || n == 1)
            {
                flag = 0;
            }


            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    flag = 0;
            }
            return flag == 1;
        }

      
              
                 
        
        /// <summary>
        /// Generate number check if it is both prime number and factor of num
        /// </summary>
        /// <param name="num">The number.</param>
        
        public static void PrimeFactorization(int num)
        {

            if (num == 1)
                return;
            
            if (CheckPrime(num))
            {
                Console.WriteLine(num);
                return;
            }
            for (int i = 2; i <= num/2;)
            {


                if (CheckPrime(i))
                {
                    if (num % i == 0)
                    {

                        Console.WriteLine(i);
                        PrimeFactorization(num / i);
                        break;

                    }
                    else
                        i++;

                }
                else
                    i++;
            }

        }
        
    
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(String[] args)
        {


            Console.WriteLine("Enter num:");
            int num = Convert.ToInt32(Console.ReadLine());
            PrimeFactorization(num);

        }

    }
}

