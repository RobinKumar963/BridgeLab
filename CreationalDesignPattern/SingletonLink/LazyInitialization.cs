using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.CreationalDesignPattern.SingletonLink
{
    class LazyInitialization
    {
        private static  LazyInitialization instance;

        private LazyInitialization() { }

        /// <summary>
        /// GAP(Global Access Point),get instance
        /// </summary>
        /// <returns></returns>
        public static LazyInitialization GetInstance()
        {
            if (instance == null)
            {
                instance = new LazyInitialization();
            }
            return instance;
        }





    }
}
