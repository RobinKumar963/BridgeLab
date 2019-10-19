using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Bridgelabz.ObjectOriented.ExtendedInventory
{
    class InventoryManager
    {
        public static void Main(String[] args)
        {
            ////taking number of inventory
            Console.WriteLine("Enter Invetory Number:");
            int N = Convert.ToInt32(Console.ReadLine());
            String name;float weight;float price;
            Inventory.Inventory inventory;
            ////Writing N inventory object(JSON format) to file
            StreamWriter sw = new StreamWriter("inventoryLog.json");
            for (int i = 1; i <= N; i++)
            {
                Console.Clear();
                Console.WriteLine("enter detail for inventory" + i);
                Console.WriteLine("Enter inventory name;");
                name = Console.ReadLine();
                Console.WriteLine("Enter weight");
                weight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter price");
                price = Convert.ToInt32(Console.ReadLine());
                inventory = new Inventory.Inventory(name, weight, price);
                ////Serialization
                string inventoryJSON = JsonConvert.SerializeObject(inventory);


                sw.WriteLine(inventoryJSON);
            }

            sw.Close();

            ////Reading inventory objects from file(inventoryLog.json) and entering to InventoryFactory class

            StreamReader sr = new StreamReader("inventoryLog.json");
            string JsonFileData;
            InventoryFactory inventoryFactory = new InventoryFactory(); 
            while ((JsonFileData = sr.ReadLine()) != null)
            {
                Console.WriteLine();
                Inventory.Inventory read = JsonConvert.DeserializeObject<Inventory.Inventory>(JsonFileData);
                inventoryFactory.Add(read);
            }


            ////Displaying stockportfolio detail(stock value and total value)
            ////Method GetTotalValue not only return totalvalue of stock
            ////it also display value of each inventory object using getValue() defined in inventory

            Double totalValue = inventoryFactory.GetTotalValue();

            Console.WriteLine("\nTotal value:" + totalValue);

        }



    }
}
