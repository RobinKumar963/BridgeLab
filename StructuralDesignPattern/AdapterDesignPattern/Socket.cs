using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    class Socket
    {
        public Volt GetVolt()
        {
            return new Volt(120);
        }
    }
}
