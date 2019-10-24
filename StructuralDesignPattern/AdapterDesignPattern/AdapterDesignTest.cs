// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AdapterDesignTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
namespace Bridgelabz.DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    /// <summary>
    /// Test the Adapter
    /// </summary>
    class AdapterDesignTest
    {
        public static void Main(String[] args)
        {
            ////Creating a new mobile charger
            MobileChargerSocket mobileCharger = new MobilePlug();

            ////Client uses this charger which is implemented by mobileAdaptor.
            ////Client make request on adaptor with target interface
            WallSocket charger = new MobileAdaptor(mobileCharger);
            
            ////Adaptor uses adaptee interface
            charger.GetVolt();
        }

    }
}
