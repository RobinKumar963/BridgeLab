// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Anagram.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------



namespace Bridgelabz.DesignPattern.CreationalDesignPattern.SingletonLink
{
    /// <summary>
    /// StaticBlockIntialization
    /// </summary>
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