// --------------------------------------------------------------------------------------------------------------------
// <copyright file=MobileAdaptor.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    class MobileAdaptor : WallSocket
    {
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
