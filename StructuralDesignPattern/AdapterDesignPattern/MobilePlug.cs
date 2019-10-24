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
    /// <summary>
    /// Concrete implementation of client
    /// </summary>
    /// <seealso cref="Bridgelabz.DesignPattern.StructuralDesignPattern.AdapterDesignPattern.MobileChargerSocket" />
    class MobilePlug : MobileChargerSocket
    {
        public Voltage GetVolt()
        {
            return new Voltage(3);
        }
    }
}
