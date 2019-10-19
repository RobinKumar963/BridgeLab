using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.CreationalDesignPattern.SingletonLink
{
    class StaticBlockIntialization
    {
        private static readonly StaticBlockIntialization instance;


        private StaticBlockIntialization() 
        {

        }


        /// <summary>
        /// GAP(Global Access Point),creating a single instance <see cref="StaticBlockIntialization"/> class.
        /// </summary>
        static StaticBlockIntialization()
        {
            instance = new StaticBlockIntialization();
        }
        /// <summary>
        /// GAP(Global Access Point),returning a single instance
        /// </summary>
        /// <returns></returns>
        public static StaticBlockIntialization GetInstance()
        {
            ////Try using for Exceptional Handling
            return instance;
        }



    }

}