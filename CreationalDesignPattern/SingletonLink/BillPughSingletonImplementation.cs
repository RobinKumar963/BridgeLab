// --------------------------------------------------------------------------------------------------------------------
// <copyright file=BillPughSingletonImplementation.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Bridgelabz.DesignPattern.CreationalDesignPattern.SingletonLink
{
    class BillPughSingletonImplementation
    {
        private BillPughSingletonImplementation() { }

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
