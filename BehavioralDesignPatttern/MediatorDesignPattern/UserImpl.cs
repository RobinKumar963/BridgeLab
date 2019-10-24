// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UserImpl.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------


using System;
namespace Bridgelabz.DesignPattern.BehavioralDesignPatttern.MediatorDesignPatter
{
    /// <summary>
    /// Concrete user
    /// </summary>
    /// <seealso cref="Bridgelabz.DesignPattern.BehavioralDesignPatttern.MediatorDesignPatter.User" />
    public class UserImpl : User
    {
        public UserImpl(ChatMediator med, String name) : base(med,name)
        {
            
        }

        /// <summary>
        /// Sends the specified MSG.Used by user to send message in mediator 
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public override void Send(String msg)
        {
            Console.WriteLine(this.name + ": Sending Message=" + msg);
            mediator.SendMessage(msg, this);
        }
        /// <summary>
        /// Receives the specified MSG.by user with a mediator
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public override void Receive(String msg)
        {
            Console.WriteLine(this.name + ": Received Message:" + msg);
        }


    }
}
