using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.StructuralDesignPattern.ProxyDesignPattern
{
    public class CommandExecutorProxy : CommandExecutor
    {
        private Boolean isAdmin;
        private CommandExecutor executor;
        public CommandExecutorProxy()
        {
            isAdmin = false;
        }

        public CommandExecutorProxy(String user, String pwd)
        {
            if (user.CompareTo("Robbie") == 0 && pwd.CompareTo("HelloCmdExecutor") == 0)
                isAdmin = true;
            else
                isAdmin = false;
        }
        
        public void RunCommand(string cmd)
        {
            if (isAdmin)
            {
                Console.WriteLine("Command running in Admin Mode");
               
            }
            executor.RunCommand(cmd);
    
        }

        public void RemoveCommand(string cmd)
        {
            if (isAdmin)
                executor.RemoveCommand(cmd);
            else
                Console.WriteLine("Access Denied:::");


        }
    }
}
