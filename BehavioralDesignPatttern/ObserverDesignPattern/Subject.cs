// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Subject.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.BehavioralDesignPatttern.ObserverDesignPattern
{
    interface Subject
    {
        ////methods to register and unregister observers
        public void Register(Observer obj);
        public void Unregister(Observer obj);

        ////method to notify observers of change
        public void NotifyObservers();

        ////method to get updates from subject
        public Object GetUpdate(Observer obj);
    }
}
