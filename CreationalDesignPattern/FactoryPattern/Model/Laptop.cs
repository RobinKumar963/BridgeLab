﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Laptop.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.CreationalDesignPattern.FactoryPattern.Model
{
    /// <summary>
    /// A Concrete computer type
    /// </summary>
    /// <seealso cref="Bridgelabz.DesignPattern.CreationalDesignPattern.FactoryPattern.Model.Computer" />
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
