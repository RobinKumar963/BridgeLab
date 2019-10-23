// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AdapterDesignTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------using System;

using System;
namespace Bridgelabz.DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    class AdapterDesignTest
    {
        public static void Main(String[] args)
        {
            MobileChargerSocket mobileCharger = new MobilePlug();
            WallSocket charger = new MobileAdaptor(mobileCharger);
            

            charger.GetVolt();
        }

    }
}
