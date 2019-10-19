using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.ObjectOriented.CommercialDataProcessing
{
    public interface AnyDataType
    {
        double ValueOf();
        void Buy(int amount, String symbol);
        void Sell(int amount, String symbol);
        void Save(String filename);
        void PrintReport();
    }
}
