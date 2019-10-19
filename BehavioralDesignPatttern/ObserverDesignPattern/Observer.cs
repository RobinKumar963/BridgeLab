using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.DesignPattern.BehavioralDesignPatttern.ObserverDesignPattern
{
    interface Observer
    {
        ////method to update the observer, used by subject
        public void Update();

        ////attach with subject to observe
        public void SetSubject(Subject sub);
    }
}
