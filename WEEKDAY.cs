// --------------------------------------------------------------------------------------------------------------------
// <copyright file=WEEKDAY.cs" company="Bridgelabz">
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
    /// Display Calendar Using Queue
    /// </summary>
    class WEEKDAY
    {
        /// <summary>
        /// Contains day and date(sun and 1,mon and 2)
        /// </summary>
        /// <seealso cref="System.IComparable" />
        internal class WeekDay : IComparable
        {
            string day;
            string date;
            
            public WeekDay()
            {
                day = " ";
                date = " ";
               
            }
            public WeekDay(string day,string date)
            {
                if (date == null)
                {
                    this.day = day;
                    this.date = " ";
                }

                else
                {
                    this.day = day;
                    this.date = date;
                }
                
                
            }

            public string Getday()
            {
                return this.day;
            }
            public string Getdate()
            {
                return date;
            }

            int IComparable.CompareTo(object obj)
            {
                return 0; ;
            }




        }

        /// <summary>
        /// Containns weekday object
        /// </summary>
        /// <seealso cref="System.IComparable" />
        internal class Week : IComparable
        {
            internal Utility.Queue<WeekDay> weekday;
            public Week()
            {
                weekday = new Utility.Queue<WeekDay>();
            }

            public int CompareTo(object obj)
            {
                throw new NotImplementedException();
            }

            internal void Add(WeekDay new_weekday)
            {
                weekday.Enqueue(new_weekday);
            }
            
        }
        /// <summary>
        /// Contains Week Object in Queue
        /// </summary>
        internal class WeekQueue 
       {
            internal Utility.Queue<Week> weekqueue;
            public WeekQueue()
            {
                weekqueue = new Utility.Queue<Week>(); 
            }
            internal void Add(Week new_week)
            {
                weekqueue.Enqueue(new_week);
            }

       }

        public static void Main(String[] args)
        {
            ////Intializing Month and year
            int month = 10;
            int year = 2019;
            int startDay = Algorithm.Utility.DayOfWeek(1, month, year);
            ////get month last date here
            int monthLastDate = DateTime.DaysInMonth(year, month);
            Week monthDetail = new Week();
            String[] week = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            int day = 0;int check = 0;
            ////Insertion in Week
            for (int date = 1;date <= monthLastDate;)
            {
                if (check < startDay)
                    monthDetail.Add(new WeekDay(week[day],null));
                else
                {
                    monthDetail.Add(new WeekDay(week[day],date.ToString()));
                    date++;
                }
                check++;
                day++;
                if (day > 6)
                    day = 0;
                
            }

            ////Displaying from Queue(monthDetail) which is an object in Week
            Console.WriteLine("sun\tmon\ttue\twed\tthu\tfri\tsat");
            int count = 0; 
            while(monthDetail != null)
            {
                Console.Write(monthDetail.weekday.Dequeue().Getdate()+"\t");
                count++;
                if(count>6)
                {
                    count = 0;
                    Console.WriteLine();
                }
               
            }
            

        }

            public int CompareTo(object obj)
            {
                throw new NotImplementedException();
            }
        }
}
