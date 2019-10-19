using Bridgelabz.DesignPattern.CreationalDesignPattern.FactoryPattern.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.CreationalDesignPattern.FactoryPattern.Factory
{
    public class ComputerFactory
    {
        public static Computer CreateComputer(string computerType,string RAM,string ROM,string CPU,string HDD)
        {
            Computer computer = null;
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
