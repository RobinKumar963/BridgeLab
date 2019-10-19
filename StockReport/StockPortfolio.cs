using System;

using Bridgelabz.DataStructure;

namespace Bridgelabz.ObjectOriented.StockReport
{
    class StockPortfolio
    {
        public DataStructure.Utility.OrderedList<Stock> stockportfolio;
        public StockPortfolio()
        {
            stockportfolio = new DataStructure.Utility.OrderedList<Stock>();
        }

        public StockPortfolio(DataStructure.Utility.OrderedList<Stock> stocks)
        {
            this.stockportfolio = stocks;
        }

        public void Add(Stock obj)
        {
            stockportfolio.Add(obj);
        }
        public double GetTotalValue()
        {

            Console.WriteLine("Stock Detail:");
            DataStructure.Utility.OrderedList<Stock> tempStock = this.stockportfolio;
            Stock readStock;double totalValue = 0.0;
            while(tempStock!=null)
            {
                readStock = tempStock.Pop();
                totalValue = totalValue + readStock.GetValue();
               
                Console.WriteLine("\n\n\n");
                Console.WriteLine("Stock name:");Console.Write(readStock.GetName());
                Console.WriteLine("Stock share:");Console.Write(readStock.GetShare());
                Console.WriteLine("Stock price:");Console.Write(readStock.GetSharePrice());
                Console.WriteLine("Value Of Stock:"); Console.Write(readStock.GetValue());





            }

            return totalValue;
            

        }
        
    }
}
