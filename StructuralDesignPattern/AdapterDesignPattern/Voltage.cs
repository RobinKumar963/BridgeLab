// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Voltage.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    class Voltage
    {
        private int volts;

        public Voltage(int v)
        {
            this.volts = v;
        }

        public int GetVolts()
        {
            return volts;
        }

        public void SetVolts(int volts)
        {
            this.volts = volts;
        }

    }
}
