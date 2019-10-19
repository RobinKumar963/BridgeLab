// --------------------------------------------------------------------------------------------------------------------
// <copyright file=QuestionFindingNumber.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------



using System;
namespace Bridgelabz.Algorithm
{
    /// <summary>
    /// Guesses user answer within range 'n' with n question
    /// </summary>
    public class QuestionFindingNumber {

        /// <summary>
        /// Determines whether [is power of two] [the specified n].
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns>
        ///   <c>true</c> if [is power of two] [the specified n]; otherwise, <c>false</c>.
        /// </returns>
        static Boolean IsPowerOfTwo(int n)
        {
            if (n == 0)
                return false;

            while (n != 1)
            {
                if (n % 2 != 0)
                    return false;
                n = n / 2;
            }
            return true;
        }

        /// <summary>
        /// Questions to find user guessed number.
        /// </summary>
        /// <param name="n">The n.</param>
        static void questionFindingAnswer(int n)
        {
            ////Checking number of guesses that can be allowed
            int guessAllowed = 0;int temp = n;
            while(temp != 1)
            {
                temp = temp / 2;
                guessAllowed++;
            }

            
            ////Ask user to choose number within 'n'
            Console.WriteLine("Choose a number from 0 to {0} and press any key to see Guesses ",(n - 1));
            Console.ReadKey();

            int low = 0;
            int high = n - 1;
            int guessValue; 
            int choice;
            int guessCount = 0;
            ////uses binary search to find guessed number by user
            while (low <= high)
            {
                Console.Clear();
                if (guessCount == guessAllowed)
                {

                    Console.WriteLine("{0}, is the number you choosed", n - 1);
                    Console.ReadKey();
                    break;
                }

                guessValue = (low + high) / 2;
                Console.WriteLine("Guess left: {0} \n ",guessAllowed - guessCount);
                Console.WriteLine("\n\n1. Is " + guessValue + " is the number you choosed");
                Console.WriteLine("2. Is " + guessValue + " is the number less than you choosed");
                Console.WriteLine("3. Is " + guessValue + " is the number larger than you choosed");
                Console.WriteLine("Ur reply here:");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)//if value found
                {
                    Console.WriteLine("found");
                    break;

                }
                else if (choice == 2)//guess value small
                    low = guessValue + 1;

                else if (choice == 3) //guess value larger
                    high = guessValue - 1;
                else
                {
                    Console.WriteLine("wrong  choice:");
                    continue;
                }


                guessCount++;

                



            }
            
        }

        public static void Main(String[] args)
        {
            int n;
            ////Accept range 'n'
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Enter number(only in power of two)");
                n = Convert.ToInt32(Console.ReadLine());
                ////Check if range Is power Of 2
                if (IsPowerOfTwo(n))
                {
                    Console.WriteLine("\n Number is power of two");
                    questionFindingAnswer(n);
                    break;
                }

                else
                {
                    Console.WriteLine("Number is not power of two.....Press any key to try again");
                    Console.ReadKey();
                    
                }
            }
            


        }

    }
}
