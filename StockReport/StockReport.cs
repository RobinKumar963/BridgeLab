using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Bridgelabz.ObjectOriented.StockReport
{
    class StockReport
    {
        public static void Main(String[] args)
        {
            ////taking number of stock
            Console.WriteLine("Enter Number of Stock:");
            int N = Convert.ToInt32(Console.ReadLine());
            String name;int share;double price;
            Stock stock;
            ////Writing N stock object(JSON format) to file
            StreamWriter sw = new StreamWriter("stockLog.json");
            for (int i=1;i<=N;i++)
            {
                Console.Clear();
                Console.WriteLine("enter detail for stock"+i);
                Console.WriteLine("Enter stock name;");
                name = Console.ReadLine();
                Console.WriteLine("Enter number of share");
                share = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter price");
                price = Convert.ToDouble(Console.ReadLine());
                stock = new Stock(name, share, price);
                ////Serialization
                string stockJSON = JsonConvert.SerializeObject(stock);

                
                sw.WriteLine(stockJSON);
            }

            sw.Close();

            ////Reading stock objects from file(stockLog.json) and entering to StockPortofolio class

            StreamReader sr = new StreamReader("stockLog.json");
            string JsonFileData;
            StockPortfolio stockPortfolio = new StockPortfolio();
            while ((JsonFileData = sr.ReadLine()) != null)
            {
                Console.WriteLine();
                Stock read = JsonConvert.DeserializeObject<Stock>(JsonFileData);
                stockPortfolio.Add(read);
            }


            ////Displaying stockportfolio detail(stock value and total value)
            ////Method GetTotalValue not only return totalvalue of stock
            ////it also display value of each stock using getValue() defined in stock

            Double totalValue = stockPortfolio.GetTotalValue();

            Console.WriteLine("\nTotal value:" + totalValue);




        }

    }
}
