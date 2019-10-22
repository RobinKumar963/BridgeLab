using System;
namespace Bridgelabz.DesignPattern.BehavioralDesignPatttern.MediatorDesignPatter
{
    public class UserImpl : User
    {
        public UserImpl(ChatMediator med, String name) : base(med,name)
        {
            
        }

      
        public override void Send(String msg)
        {
            Console.WriteLine(this.name + ": Sending Message=" + msg);
            mediator.SendMessage(msg, this);
        }
        
        public override void Receive(String msg)
        {
            Console.WriteLine(this.name + ": Received Message:" + msg);
        }


    }
}
