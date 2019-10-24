// --------------------------------------------------------------------------------------------------------------------
// <copyright file=BillPughSingletonImplementation.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Bridgelabz.DesignPattern.CreationalDesignPattern.SingletonLink
{
    /// <summary>
    /// BillPughSingletonImplementation
    /// </summary>
    class BillPughSingletonImplementation
    {
        private BillPughSingletonImplementation() { }
        /// <summary>
        /// SingletonHelper(Doesnt load in memory till its property 'INSTANCE' is accessed)
        /// </summary>
        private static class SingletonHelper
        {

            public static readonly BillPughSingletonImplementation INSTANCE = new BillPughSingletonImplementation();
        }

        public static BillPughSingletonImplementation GetInstance()
        {
            return SingletonHelper.INSTANCE;
        }
    }
}
