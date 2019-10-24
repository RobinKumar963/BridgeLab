// --------------------------------------------------------------------------------------------------------------------
// <copyright file=MyTopicSubscriber.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.BehavioralDesignPatttern.ObserverDesignPattern
{
    /// <summary>
    /// Concrete Observer
    /// </summary>
    /// <seealso cref="Bridgelabz.DesignPattern.BehavioralDesignPatttern.ObserverDesignPattern.Observer" />
    class MyTopicSubscriber : Observer
    {
        
        private String name;
        private Subject topic;

        public MyTopicSubscriber(String nm)
        {
            this.name = nm;
        }

        public void SetSubject(Subject sub)
        {
            this.topic = sub;
        }

        public void Update()
        {
            ////This method called by observer to get notified about changes
            String msg = (String)topic.GetUpdate(this);
            if (msg == null)
            {
                Console.WriteLine(name + ":: No new message");
            }
            else
                Console.WriteLine(name + ":: Consuming message::" + msg);
        }
    }
}
