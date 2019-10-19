// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Stopwatch.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------




using System;

namespace Bridgelabz.FunctionalProgram
{
    /// <summary>
    /// Facilates implementation of stopwatch
    /// </summary>
    public class Stopwatch
    {
        
        
        private int startHour;
        private int startMinute;
        private int startSecond;





        /// <summary>
        /// Initializes a new instance of the <see cref="Stopwatch"/> class.
        /// </summary>
        public Stopwatch()
        {
            startHour = Convert.ToInt32(DateTime.Now.Hour);
            startMinute = Convert.ToInt32(DateTime.Now.Minute);
            startSecond = Convert.ToInt32(DateTime.Now.Second);
            

        }


        /// <summary>
        /// Returns the time elapsed since object has been created and this function is called..
        /// </summary>
        /// <returns></returns>
        public void ElapsedTime()
        {

                    Console.WriteLine
                (
                     Convert.ToInt32(DateTime.Now.Second) - startSecond

                );

            
        }


    


            public static void Main(String[] args)
            {
                   
                int hr = 0, min = 0, sec = 0;
                Console.WriteLine("press any key to start the stop watch");
                Console.ReadKey();
                
                Console.Clear();
                Console.WriteLine("Stopwatch Started");
                Stopwatch watch = new Stopwatch();
                while(true)
                {
                    sec++;
                    if (sec > 59)
                    {
                        sec = 0;
                        min++;
                    }
                    if (min > 59)
                    {
                        min = 0;
                        hr++;
                    }

                    Console.WriteLine("\n\npress any key to end the stop watch");
                    System.Threading.Thread.Sleep(1000);
                    ////after 1 second  display new hr,min,sec
                    
                    Console.Clear();
                    Console.WriteLine("{0}:{1}:{2}",hr.ToString().PadLeft(2,'0'), min.ToString().PadLeft(2, '0'), sec.ToString().PadLeft(2, '0'));
                    if (Console.KeyAvailable)
                    break;
                
                
                   
                
                }

          



                watch.ElapsedTime();

            }

        

    }

}