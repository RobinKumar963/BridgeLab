using System;



namespace Bridgelabz.ObjectOriented.StockReport
{
    class Stock : IComparable
    {
        public String stockName;
        public int share;
        public double sharePrice;

        Stock()
        {
            stockName = " ";
            share = 0;
            sharePrice = 0;
        }

        public Stock(string stockName, int share,double sharePrice)
        {
            this.stockName = stockName;
            this.share = share;
            this.sharePrice = sharePrice;
        }
        public String GetName()
        {
            return this.stockName;
        }
        public int GetShare()
        {
            return this.share;
        }
        public double GetSharePrice()
        {
            return this.sharePrice;
        }

        public double GetValue()
        {
            return (this.share * this.sharePrice);
        }

        public int CompareTo(object obj)
        {
            return 0;
        }
    }
}
