// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LeapYear.cs" company="Bridgelabz">
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
    /// Check if year is leap year or not
    /// </summary>
    class LeapYear
    {

        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(String[] args)
        {
            String year;
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Enter year");
                year = Console.ReadLine();
                if (year.Length < 4)
                {
                    Console.WriteLine("Not a year....Min of 4 length.........press any key to enter again");
                    Console.ReadKey();
                    continue;
                }
                else
                    break;
            }

            if (Convert.ToInt32(year) % 4 == 0)
                Console.WriteLine("Leap year");
            else
                Console.WriteLine("Not a leap year");
            
        }
    }
}
