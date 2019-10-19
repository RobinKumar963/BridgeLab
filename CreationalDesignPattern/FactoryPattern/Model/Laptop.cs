using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.CreationalDesignPattern.FactoryPattern.Model
{
    class Laptop : Computer
    {
        string CPU;
        string ROM;
        string RAM;
        string HDD;

        public Laptop(string CPU, string ROM, string RAM, string HDD)
        {
            this.CPU = CPU;
            this.ROM = ROM;
            this.RAM = RAM;
            this.HDD = HDD;
        }

        public string GetCPU()
        {
            return CPU;
        }

        public string GetHDD()
        {
            return ROM;
        }

        public string GetRAM()
        {
            return RAM;
        }

        public string GetROM()
        {
            return HDD;
        }
    }
}
