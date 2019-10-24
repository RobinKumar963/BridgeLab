// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LowLevelModule.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.DependencyInjection
{
    /// <summary>
    /// Concrete implementation of Abstraction
    /// </summary>
    /// <seealso cref="Bridgelabz.DesignPattern.DependencyInjection.Abstraction" />
    public class LowLevelModule : Abstraction
    {
        public void ExecService()
        {
            Console.WriteLine("Service Executed");
        }

        public void LoadService()
        {
            Console.WriteLine("Service Loaded");
        }

        public void RemoveService()
        {
            Console.WriteLine("Service Removed"); 
        }
    }
}
