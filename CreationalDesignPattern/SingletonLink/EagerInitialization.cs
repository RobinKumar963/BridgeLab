// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EagerInitialization.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------


namespace Bridgelabz.DesignPattern.CreationalDesignPattern.SingletonLink
{
    public class EagerInitialization
    {
        /// <summary>
        /// A instance to be created once and assigned once with Keyword readonly
        /// </summary>
        private static readonly EagerInitialization instance = new EagerInitialization();
        /// <summary>
        /// Prevents a default instance of the <see cref="EagerInitialization"/> class from being created.
        /// </summary>
        private EagerInitialization() { }
        ////GAP(Global Access Point),returns an instance
        public static EagerInitialization GetInstance()
        {
            return instance;
        }



    }
}
