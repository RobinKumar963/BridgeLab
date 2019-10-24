// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ShoppingCartVisitor.cs" company="Bridgelabz">
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
    /// Contract for shopping visitor
    /// </summary>
    public interface ShoppingCartVisitor
    {
        int Visit(Book book);
        int Visit(Fruit fruit);

    }
}
