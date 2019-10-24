// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LazyInitialization.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Bridgelabz.DesignPattern.CreationalDesignPattern.SingletonLink
{
    /// <summary>
    /// LazyInitialization
    /// </summary>
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
