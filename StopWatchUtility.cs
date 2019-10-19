// --------------------------------------------------------------------------------------------------------------------
// <copyright file=StopWatchUtility.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------



using System;

namespace Bridgelabz.Algorithm
{
    /// <summary>
    /// A utility class to implement stopwatch
    /// </summary>
    public class StopWatchUtility 
    {
        private int startHour;
        private int startMinute;
        private int startSecond;
        private int startMilliSecond;




        /// <summary>
        /// Initializes a new instance of the <see cref="Stopwatch"/> class.
        /// </summary>
        public StopWatchUtility()
        {
            startHour = Convert.ToInt32(DateTime.Now.Hour);
            startMinute = Convert.ToInt32(DateTime.Now.Minute);
            startSecond = Convert.ToInt32(DateTime.Now.Second);
            startMilliSecond = Convert.ToInt32(DateTime.Now.Millisecond);

        }


        /// <summary>
        /// Returns the time elapsed since object has been created and this function is called..
        /// </summary>
        /// <returns></returns>
        public int ElapsedTime()
        {

            return Convert.ToInt32(DateTime.Now.Millisecond) - startMilliSecond;


        }




    }
}
