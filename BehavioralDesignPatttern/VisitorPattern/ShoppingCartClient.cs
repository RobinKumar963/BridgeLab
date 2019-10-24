// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ShoppingCartClient.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------



using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.BehavioralDesignPatttern.VisitorPattern
{
    class ShoppingCartClient
    {
         public static void Main(String[] args)
        {
            ////Create item element---book,fruit
            ItemElement[] items = {new Book(20, "1234"),new Book(100, "5678"),
                new Fruit(10, 2, "Banana"), new Fruit(5, 5, "Apple")};
            ////Calculate total visiting each element
            int total = calculatePrice(items);
            Console.WriteLine("Total Cost = " + total);
        }

        private static int calculatePrice(ItemElement[] items)
        {
            ShoppingCartVisitor visitor = new ShoppingCartVisitorImpl();
            int sum = 0;
            ////Iterate all item element
            foreach(ItemElement item in items)
            {
                ////for each item calculate total
                sum += item.Accept(visitor);
            }
            return sum;
        }



    }
}
