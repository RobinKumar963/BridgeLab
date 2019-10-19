// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Calendar.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DataStructure
{

    /// <summary>
    /// Print calendar of given month and year
    /// </summary>
    class Calendar
    {
        public static void Main(String[] args)
        {
            ////Intialization
            int weekOfMonth = 7;
            int dayOfWeek = 7;
            int[,] calendar = new int[dayOfWeek ,weekOfMonth];
            //// Extracting input from Command Line Argument
            int month = Convert.ToInt32(args[0]);
            int year = Convert.ToInt32(args[1]);
            int startWeek = Algorithm.Utility.DayOfWeek(1, month, year);
            ////get month last date here
            int monthLastDate = DateTime.DaysInMonth(year, month);
            ////setting values in calendar
            int days = 1;
            for(int i = 0; i < dayOfWeek; i++)
            {
                for(int j = startWeek; j < weekOfMonth; j++)
                {
                    calendar[i, j] = days++;
                    
                    if (days > monthLastDate)
                        break;
                }
                startWeek = 0;
                if (days > monthLastDate)
                    break;
            }

            //// Displaying values in calendar
            Console.WriteLine("sun \t mon \t tue \t wed \t thu \t fri \t sat");
            for (int i = 0; i < dayOfWeek; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < weekOfMonth; j++)
                {
                    if(calendar[i,j] == 0)
                        Console.Write(" \t ");
                    else
                        Console.Write("{0} \t ",calendar[i,j]);
                }
                
            }
        }
    }
}
