// --------------------------------------------------------------------------------------------------------------------
// <copyright file=MyTopic.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------


using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.BehavioralDesignPatttern.ObserverDesignPattern
{
    class MyTopic : Subject
    {
        private List<Observer> observers;
        private String message;
        private Boolean changed;
        private readonly Object padLock = new Object();


        
        public void PostMessage(String msg)
        {
            ////method to post message to the topic
            Console.WriteLine("Message Posted to Topic:" + msg);
            this.message = msg;
            this.changed = true;
            NotifyObservers();
        }

        public void Register(Observer obj)
        {
            //if (obj == null) throw new NullPointerException("Null Observer");
            lock(padLock) 
            {
                if (!observers.Contains(obj)) observers.Add(obj);
            }
        }

        public void Unregister(Observer obj)
        {
            lock(padLock)
            {
                observers.Remove(obj);
            }
            
        }

        public void NotifyObservers()
        {
            List<Observer> observersLocal = null;
            //synchronization is used to make sure any observer registered after message is received is not notified
            lock(padLock) 
            {
                if (!changed)
                    return;
                observersLocal = new List<Observer>(this.observers);
                this.changed = false;
            }
            foreach(Observer obj in observersLocal)
            {
                obj.Update();
            }


        }

        public object GetUpdate(Observer obj)
        {
            return this.message;
        
        }
    }
}










