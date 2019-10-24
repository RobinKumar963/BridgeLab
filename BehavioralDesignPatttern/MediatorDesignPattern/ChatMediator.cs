// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ChatMediator.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------


using System;
namespace Bridgelabz.DesignPattern.BehavioralDesignPatttern.MediatorDesignPatter
{
    /// <summary>
    /// Contract for mediator
    /// </summary>
    public interface ChatMediator
    {
        public void SendMessage(String msg, User user);

        void AddUser(User user);
    }
}
