// --------------------------------------------------------------------------------------------------------------------
// <copyright file=inventory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------




using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.ObjectOriented.Inventory
{
    public class Inventory : IComparable
    {
        
            public String name;
            public float weight;
            public float price;

        public Inventory(string name, float weight, float price)
        {
            this.name = name;
            this.weight = weight;
            this.price = price;
        }

        public int CompareTo(object obj)
        {
            return 0; 
        }

        public String Get_name()
        {
            return name;
        }

        public float Get_price()
        {
            return price;
        }

        public float Get_weight()
        {
            return weight;
        }

        public double GetValue()
        {
            return (this.weight * this.price);

        }

            

    }
}
