// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Book.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.BehavioralDesignPatttern.VisitorPattern
{
    public class Book : ItemElement
    {
        private int price;
        private String isbnNumber;

        public Book(int cost, String isbn)
        {
            this.price = cost;
            this.isbnNumber = isbn;
        }

        public int getPrice()
        {
            return price;
        }

        public String getIsbnNumber()
        {
            return isbnNumber;
        }

        
    public int Accept(ShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }


    }
}
