// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ComputerFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------





using Bridgelabz.DesignPattern.CreationalDesignPattern.FactoryPattern.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.CreationalDesignPattern.FactoryPattern.Factory
{
    /// <summary>
    /// Creates instance of computer
    /// </summary>
    public class ComputerFactory
    {
        public static Computer CreateComputer(string computerType,string RAM,string ROM,string CPU,string HDD)
        {
            Computer computer = null;
            ////Check for type and create instance of that type
            switch(computerType)
            {
                case "PC":
                    computer = new PC(RAM, ROM, CPU, HDD);
                    break;
                case "Laptop":
                    computer = new Laptop(RAM, ROM, CPU, HDD);
                    break;
                default:
                    break;

            }
            return computer;
        }
    }
}
