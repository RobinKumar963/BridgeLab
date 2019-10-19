using System;
using System.Collections.Generic;
using System.Text;

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
