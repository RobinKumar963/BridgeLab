// --------------------------------------------------------------------------------------------------------------------
// <copyright file=MyAttributes.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.Annotation
{
    [AttributeUsage(AttributeTargets.All)]
    class MyAttributes : Attribute
    {

        // Provides name of the member 
        private string name;

        // Provides description of the member 
        private string action;

        // Constructor 
        public MyAttributes(string name, string action)
        {
            this.name = name;
            this.action = action;
        }

        // property to get name 
        public string Name
        {
            get { return name; }
        }

        // property to get description 
        public string Action
        {
            get { return action; }
        }
    }
}
