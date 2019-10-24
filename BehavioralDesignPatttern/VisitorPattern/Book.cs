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
    /// <summary>
    /// Book-A concrete item
    /// </summary>
    /// <seealso cref="Bridgelabz.DesignPattern.BehavioralDesignPatttern.VisitorPattern.ItemElement" />
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

        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        /// <returns></returns>
        public int Accept(ShoppingCartVisitor visitor)
        {
            ////Double dispatch solved
            return visitor.Visit(this);
        }


    }
}
