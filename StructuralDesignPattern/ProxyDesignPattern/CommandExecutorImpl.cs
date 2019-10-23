// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CommandExecutorImpl.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------

using System;


namespace Bridgelabz.DesignPattern.StructuralDesignPattern.ProxyDesignPattern
{
    class CommandExecutorImpl : CommandExecutor
    {

        public void RunCommand(string cmd) 
        {
            //Runtime.getRuntime().exec(cmd);
            Console.WriteLine(" " + cmd + "' command executed.");
        }
        /// <summary>
        /// Removes the command.Crucial should not be used by client as he can remove crucial command
        /// </summary>
        /// <param name="cmd">The command.</param>
        public void RemoveCommand(string cmd)
        {
            //Runtime.getRuntime().exec(cmd);
            Console.WriteLine(" " + cmd + "' command removed."); 
        }
    }
}
