using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.BehavioralDesignPatttern.ObserverDesignPattern
{
    class ObserverPatternTest
    {
        public static void main(String[] args)
        {
            ////create subject
            MyTopic topic = new MyTopic();

            ////create observers
            Observer obj1 = new MyTopicSubscriber("Obj1");
            Observer obj2 = new MyTopicSubscriber("Obj2");
            Observer obj3 = new MyTopicSubscriber("Obj3");

            ////Register observers to the subject
            topic.Register(obj1);
            topic.Register(obj2);
            topic.Register(obj3);

            ////attach observer to subject
            obj1.SetSubject(topic);
            obj2.SetSubject(topic);
            obj3.SetSubject(topic);

            ////check if any update is available
            obj1.Update();

            ////now send message to subject
            topic.PostMessage("New Message");
        }

    }
}
