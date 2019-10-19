using Newtonsoft.Json;
using System;
using System.IO;


namespace Bridgelabz.ObjectOriented.CommercialDataProcessing
{
    public class StockAccount : AnyDataType
    {
        DataStructure.Utility.UnOrderedList<CompanyShares> companyshares;


        public StockAccount(String filename)
        {
            companyshares = new DataStructure.Utility.UnOrderedList<CompanyShares>();
           
            StreamReader sr = new StreamReader("StockReport.stockLog.json");
            string JsonFileData;
            
            while ((JsonFileData = sr.ReadLine()) != null)
            {
                Console.WriteLine();
                StockReport.Stock read = JsonConvert.DeserializeObject<StockReport.Stock>(JsonFileData);
                companyshares.Add(new CompanyShares(read.GetName(), read.GetShare(), read.GetSharePrice(), DateTime.Now.ToString()));
            }
        }


        public void Buy(int amount, string symbol)
        {
            CompanyShares readCompanyShares = new CompanyShares();

            for(int i=0;i<companyshares.Size();i++)
            {
                readCompanyShares = companyshares.Pop(i);
                companyshares.Add(readCompanyShares);
                if (readCompanyShares.GetStockSymbol() == symbol)
                {
                    readCompanyShares.AddShare(amount);
                }
                else
                {
                    Console.WriteLine("Symbol not found");
                    return;
                }
                    

            }

            TransactionStatus transactionStatus = new TransactionStatus();
            TransactionTime transactionTime = new TransactionTime();

            transactionStatus.Add(new StockStatus(symbol,true));
            transactionTime.Add(DateTime.Now.ToString());
            
        }

        public void PrintReport()
        {

            Console.WriteLine("Company share Detail:");
            DataStructure.Utility.UnOrderedList<CompanyShares> temp = this.companyshares;
            CompanyShares readCompanyShare;
            while (temp != null)
            {
                readCompanyShare = temp.Pop();
                

                Console.WriteLine("\n\n\n");
                Console.WriteLine("Company Share symbol:"); Console.Write(readCompanyShare.GetSymbol());
                Console.WriteLine("Stock share :"); Console.Write(readCompanyShare.GetStockShare());
                Console.WriteLine("Stock share price:"); Console.Write(readCompanyShare.GetStockSharePrice());
                Console.WriteLine("Transaction time:"); Console.Write(readCompanyShare.GetTransaction());
                Console.WriteLine("Value:"); Console.Write(readCompanyShare.GetStockShare()*readCompanyShare.GetStockSharePrice());





            }

            Console.WriteLine("Total value: {0}",ValueOf());

        }

        public void Save(string filename)
        {
            
          
            ////Writing this StockAccount to file
            StreamWriter sw = new StreamWriter("stockAccount.json");
            
            
            ////Serialization
            string stockAccountJSON = JsonConvert.SerializeObject(this.companyshares);
            sw.WriteLine(stockAccountJSON);
            sw.Close();


        }

        public void Sell(int amount, string symbol)
        {
            CompanyShares readCompanyShares = new CompanyShares();

            for (int i = 0; i < companyshares.Size(); i++)
            {
                readCompanyShares = companyshares.Pop(i);
                companyshares.Add(readCompanyShares);
                if (readCompanyShares.GetStockSymbol() == symbol)
                {
                    readCompanyShares.SubtractShare(amount);
                }
                else
                {
                    return;
                }
                    Console.WriteLine("Symbol not found");

            }
            TransactionStatus transactionStatus = new TransactionStatus();
            TransactionTime transactionTime = new TransactionTime();

            transactionStatus.Add(new StockStatus(symbol, false));
            transactionTime.Add(DateTime.Now.ToString());

        }

        public double ValueOf()
        {
           
            DataStructure.Utility.UnOrderedList<CompanyShares> temp = this.companyshares;
            CompanyShares readCompanyShare;
            double value = 0;
            while (temp != null)
            {
                readCompanyShare = temp.Pop();
                value += readCompanyShare.GetStockShare() * readCompanyShare.GetStockSharePrice();
            }

            return value;

        }

    }
        
    
}
