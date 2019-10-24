// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CommandExecutorProxy.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------

using System;


namespace Bridgelabz.DesignPattern.StructuralDesignPattern.ProxyDesignPattern
{
    /// <summary>
    /// Proxy concrete implementation of CommandExecutor
    /// </summary>
    /// <seealso cref="Bridgelabz.DesignPattern.StructuralDesignPattern.ProxyDesignPattern.CommandExecutor" />
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
            ////Authorization for admin
            if (user.CompareTo("Robbie") == 0 && pwd.CompareTo("HelloCmdExecutor") == 0)
                isAdmin = true;
            else
                isAdmin = false;
        }
        
        public void RunCommand(string cmd)
        {
            ////If,admin mode than command run in admin mode
            ////else run in Guest mode
            if (isAdmin)
            {
                Console.WriteLine("Command running in Admin Mode");
            }
            else
                Console.WriteLine("Command running in Guest Mode");

            executor.RunCommand(cmd);
    
        }

        public void RemoveCommand(string cmd)
        {
            ////If,admin mode than command removed
            ////else request denied
            if (isAdmin)
                executor.RemoveCommand(cmd);
            else
                Console.WriteLine("Access Denied:::");


        }
    }
}
