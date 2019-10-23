// --------------------------------------------------------------------------------------------------------------------
// <copyright file=MobilePlug.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    class MobilePlug : MobileChargerSocket
    {
        public Voltage GetVolt()
        {
            return new Voltage(3);
        }
    }
}
