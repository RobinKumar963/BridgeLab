using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.ObjectOriented.CommercialDataProcessing
{
    class StockStatus : IComparable
    {
        string symbol;
        Boolean Soldstatus;

        public StockStatus(string symbol, bool soldstatus)
        {
            this.symbol = symbol;
            Soldstatus = soldstatus;
        }

        public int CompareTo(object obj)
        {
            return 0;
        }
    }
}
