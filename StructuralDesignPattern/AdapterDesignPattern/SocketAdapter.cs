using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    interface SocketAdapter
    {
        public Volt Get120Volt();

        public Volt Get12Volt();

        public Volt Get3Volt();
    }
}
