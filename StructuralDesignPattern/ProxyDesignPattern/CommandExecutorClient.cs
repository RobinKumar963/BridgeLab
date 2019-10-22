using System;


namespace Bridgelabz.DesignPattern.StructuralDesignPattern.ProxyDesignPattern
{
    class CommandExecutorClient
    {
        public static void Main(String[] args)
        {
            CommandExecutorProxy executor = new CommandExecutorProxy();

            CommandExecutorProxy adminExecutor = new CommandExecutorProxy("Robbie", "HelloCmdExecutor");

            executor.RunCommand("System.Console.Clear()");
            executor.RemoveCommand("System.Console.Clear()");
            adminExecutor.RunCommand("System.Console.Clear()");
            adminExecutor.RemoveCommand("System.Console.Clear()");

        }
        

    }
    
}
