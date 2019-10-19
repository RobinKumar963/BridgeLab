using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.BehavioralDesignPatttern.VisitorPattern
{
    public interface ItemElement
    {
        public int accept(ShoppingCartVisitor visitor);
    }
}
