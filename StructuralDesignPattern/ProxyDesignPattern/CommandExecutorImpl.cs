// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CommandExecutorImpl.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------

using System;


namespace Bridgelabz.DesignPattern.StructuralDesignPattern.ProxyDesignPattern
{
    /// <summary>
    /// Concrete implementation of CommandExecutor
    /// </summary>
    /// <seealso cref="Bridgelabz.DesignPattern.StructuralDesignPattern.ProxyDesignPattern.CommandExecutor" />
    class CommandExecutorImpl : CommandExecutor
    {

        public void RunCommand(string cmd) 
        {
            ////Command Executed
            Console.WriteLine(" " + cmd + "' command executed.");
        }
    
        public void RemoveCommand(string cmd)
        {
            ////Command Removed
            Console.WriteLine(" " + cmd + "' command removed."); 
        }
    }
}
