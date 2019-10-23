﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Fruit.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.BehavioralDesignPatttern.VisitorPattern
{
    public class Fruit : ItemElement 
    {
        private int pricePerKg;
        private int weight;
        private String name;

        public Fruit(int priceKg, int wt, String nm)
        {
            this.pricePerKg = priceKg;
            this.weight = wt;
            this.name = nm;
        }

        public int getPricePerKg()
        {
            return pricePerKg;
        }


        public int getWeight()
        {
            return weight;
        }

        public String getName()
        {
            return this.name;
        }

        
        public int Accept(ShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }

    }
}
