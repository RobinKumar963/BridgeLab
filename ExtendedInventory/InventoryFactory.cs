using System;
using System.Collections.Generic;
using System.Text;
using Bridgelabz.DataStructure;
using Bridgelabz.ObjectOriented.Inventory;
using Newtonsoft.Json;

namespace Bridgelabz.ObjectOriented.ExtendedInventory
{
    class InventoryFactory
    {
        public DataStructure.Utility.OrderedList<Inventory.Inventory> inventoryfactory;
        public InventoryFactory()
        {
            inventoryfactory = new DataStructure.Utility.OrderedList<Inventory.Inventory>();
        }

        public InventoryFactory(Utility.OrderedList<Inventory.Inventory> inventoryfactory)
        {
            this.inventoryfactory = inventoryfactory;
        }

        public void Add(Inventory.Inventory obj)
        {
            inventoryfactory.Add(obj);
        }
        public double GetTotalValue()
        {

            Console.WriteLine("Inventory Detail:");
            DataStructure.Utility.OrderedList<Inventory.Inventory> tempInventory = this.inventoryfactory;
            Inventory.Inventory readInventory; double totalValue = 0.0;
            while (tempInventory != null)
            {
                readInventory = tempInventory.Pop();
                totalValue = totalValue + readInventory.GetValue();

                Console.WriteLine("\n\n\n");
                Console.WriteLine(JsonConvert.SerializeObject(readInventory));
                Console.WriteLine("Value Of inventory:"); Console.Write(readInventory.GetValue());





            }

            return totalValue;

        }
    }
}
