// --------------------------------------------------------------------------------------------------------------------
// <copyright file=MobileAdaptor.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------


namespace Bridgelabz.DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    /// <summary>
    /// Adapter connect two unrelated interface source and client.Use adaptee interface WallSocket
    /// </summary>
    /// <seealso cref="Bridgelabz.DesignPattern.StructuralDesignPattern.AdapterDesignPattern.WallSocket" />
    class MobileAdaptor : WallSocket
    {
        /// <summary>
        /// Client interface(target interface)
        /// </summary>
        MobileChargerSocket mobileCharger;

        public MobileAdaptor(MobileChargerSocket mobileCharger)
        {
            this.mobileCharger = mobileCharger;
        }

        
        

        public Voltage GetVolt()
        {
            return mobileCharger.GetVolt();
        }
    }
}
