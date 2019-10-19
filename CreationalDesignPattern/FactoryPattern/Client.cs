using Bridgelabz.DesignPattern.CreationalDesignPattern.FactoryPattern.Constants;
using Bridgelabz.DesignPattern.CreationalDesignPattern.FactoryPattern.Factory;
using Bridgelabz.DesignPattern.CreationalDesignPattern.FactoryPattern.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.CreationalDesignPattern.FactoryPattern
{
    class Client
    {
        public static void Main(String[] args)
        {
            Computer pc = ComputerFactory.CreateComputer(Constant.PC, "8 GB", "1 GB", "Inextgen", "1 TB");
            Computer laptop = ComputerFactory.CreateComputer(Constant.LAPTOP, "8 GB", "1 GB", "Inextgen", "1 TB");
        }
    }
}
