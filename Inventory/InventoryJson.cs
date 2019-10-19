// --------------------------------------------------------------------------------------------------------------------
// <copyright file=InventoryJson.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------



using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Bridgelabz.ObjectOriented
{
    class InventoryJson
    {
        

        public static void Main(String[] args)
        {
            ////Creating rice,wheat and pulses object
            Inventory.Inventory Wheat = new Inventory.Inventory("Wheat", 20, 1000);
            Inventory.Inventory Rice = new Inventory.Inventory("Rice", 20, 900);
            Inventory.Inventory Pulses = new Inventory.Inventory("Pulses", 10, 500);

            ////JSON serialization
            string RiceData = JsonConvert.SerializeObject(Rice);
            Console.WriteLine("Serialized JSON Object: " + RiceData);
            string WheatData = JsonConvert.SerializeObject(Wheat);
            Console.WriteLine("Serialized JSON Object: " + WheatData);
            string PulsesData = JsonConvert.SerializeObject(Pulses);
            Console.WriteLine("Serialized JSON Object: " + PulsesData);


            ////Writing serialized Object to file
            StreamWriter sw = new StreamWriter("inventory.json");
            sw.WriteLine(RiceData);
            sw.WriteLine(WheatData);
            sw.WriteLine(PulsesData);
            sw.Close();

            ////JSON Deserialization.Using streamReader to read JSON object from file
            StreamReader sr = new StreamReader("inventory.json");
            string JsonFileData;
            while((JsonFileData = sr.ReadLine()) != null)
            {
                Console.WriteLine();
                Inventory.Inventory read = JsonConvert.DeserializeObject<Inventory.Inventory>(JsonFileData);
                Console.Write(" Name:" + read.Get_name());
                Console.Write(" Weight:" + read.Get_weight());
                Console.Write(" Price:" + read.Get_price());
                
            }
            


        }
    }
}

