using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.StructuralDesignPattern.ProxyDesignPattern
{
    class CommandExecutorProxy
    {
        CommandExecutor commandexecutorimpl = new CommandExecutorImpl();

        public  void RunCommand(string cmd)
        {
            commandexecutorimpl.RunCommand(cmd);
        }


    }
}
