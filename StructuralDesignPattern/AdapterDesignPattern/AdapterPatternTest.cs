// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Binary.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------



using System;


namespace Bridgelabz.DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    class AdapterPatternTest
    {
        public static void Main(String[] args)
        {

            TestClassAdapter();
           
        }

        

        private static void TestClassAdapter()
        {
            SocketAdapter sockAdapter = new SocketClassAdapterImpl();
            Volt v3 = GetVolt(sockAdapter, 3);
            Volt v12 = GetVolt(sockAdapter, 12);
            Volt v120 = GetVolt(sockAdapter, 120);
            Console.WriteLine("v3 volts using Class Adapter=" + v3.GetVolts());
            Console.WriteLine("v12 volts using Class Adapter=" + v12.GetVolts());
            Console.WriteLine("v120 volts using Class Adapter=" + v120.GetVolts());
        }

        private static Volt GetVolt(SocketAdapter sockAdapter, int i)
        {
            switch (i)
            {
                case 3: return sockAdapter.Get3Volt();
                case 12: return sockAdapter.Get12Volt();
                case 120: return sockAdapter.Get120Volt();
                default: return sockAdapter.Get120Volt();
            }
        }
    }
}
