using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.FunctionalProgram
{
    class test
    {
        public static void Main(String[] args)
        {
            /*
            DateTime now = new DateTime();
            Console.WriteLine(now.Second);
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine(now.Second);
            */


            TimeSpan span = new TimeSpan();
            
            Console.WriteLine(span.Seconds);
            System.Threading.Thread.Sleep(10000);
            Console.WriteLine(span.TotalSeconds);

            Console.WriteLine(".......");

            Console.WriteLine(DateTime.Now.Second + ":" + DateTime.Now.Second + 1);
            

        }
    }
}
