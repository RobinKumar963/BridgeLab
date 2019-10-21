
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.StructuralDesignPattern.ProxyDesignPattern
{
    interface CommandExecutor
    {
        public void RunCommand(String cmd);
        public void RemoveCommand(string cmd);
    }
}
