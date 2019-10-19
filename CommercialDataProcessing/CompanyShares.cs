 using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.ObjectOriented.CommercialDataProcessing
{
    public class CompanyShares : IComparable
    {
        public String stockSymbol;
        public int stockShare;
        public double stockSharePrice;
        public String transaction;

        public CompanyShares(string stockSymbol, int stockShare,double stockSharePrice,string transaction)
        {
            this.stockSymbol = stockSymbol;
            this.stockShare = stockShare;
            this.stockSharePrice = stockSharePrice;
            this.transaction = transaction;
        }
        public CompanyShares()
        {
            this.stockSymbol = "";
            this.stockShare = 0;
            this.stockSharePrice = 0;
            this.transaction = "";
        }
        public String GetStockSymbol()
        {
            return this.stockSymbol;
        }
        public void AddShare(int amount)
        {
            this.stockShare += amount;
        }
        public void SubtractShare(int amount)
        {
            this.stockShare -= amount;
        }
        public string GetSymbol()
        {
            return this.stockSymbol;
        }

        public int GetStockShare()
        {
            return this.stockShare;
        }
        public double GetStockSharePrice()
        {
            return this.stockSharePrice;
        }
        public string GetTransaction()
        {
            return this.transaction;
        }









        public int CompareTo(object obj)
        {
            return 0; 
        }
    }
}
