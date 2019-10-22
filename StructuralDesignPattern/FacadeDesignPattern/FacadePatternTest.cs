using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.StructuralDesignPattern.FacadeDesignPattern
{
    class FacadePatternTest
    {
        public static void Main(String[] args)
        {
            FacadeHelper SQLfacadeHelper = new FacadeHelper("SQL");
            FacadeHelper ORACLEfacadeHelper = new FacadeHelper("ORACLE");

            //generating MySql HTML report and Oracle PDF report using Facade
            SQLfacadeHelper.GenerateHTMLReport();
            SQLfacadeHelper.GeneratePDFReport();
            //generating Oracle HTML report and Oracle PDF report using Facade
            ORACLEfacadeHelper.GenerateHTMLReport();
            ORACLEfacadeHelper.GeneratePDFReport();

        }
    }
}
