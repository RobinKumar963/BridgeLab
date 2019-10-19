using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    class Volt
    {
        private int volts;

        public Volt(int v)
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
