// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ItemElement.cs" company="Bridgelabz">
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
    /// Contract for items
    /// </summary>
    public interface ItemElement
    {
        public int Accept(ShoppingCartVisitor visitor);
    }
}
