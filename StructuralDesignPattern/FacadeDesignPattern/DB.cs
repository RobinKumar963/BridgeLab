using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.StructuralDesignPattern.FacadeDesignPattern
{
    interface DB
    {
        public Connection GetConnection();
        public void GenerateHTMLReport();
        public void GeneratePDFReport();
    }
}
