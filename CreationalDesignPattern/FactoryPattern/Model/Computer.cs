using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.CreationalDesignPattern.FactoryPattern.Model
{
    public interface Computer
    {
        public string GetRAM();
        public string GetROM();
        public string GetHDD();
        public string GetCPU();
    }
}
