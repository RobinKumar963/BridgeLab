// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ChatClient.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------


using System;
namespace Bridgelabz.DesignPattern.BehavioralDesignPatttern.MediatorDesignPatter
{
    /// <summary>
    /// Test mediator pattern
    /// </summary>
    public class ChatClient
    {
        public static void Main(String[] args)
        {
            ChatMediator mediator = new ChatMediatorImpl();
            User user1 = new UserImpl(mediator, "Pankaj");
            User user2 = new UserImpl(mediator, "Lisa");
            User user3 = new UserImpl(mediator, "Saurabh");
            User user4 = new UserImpl(mediator, "David");
            mediator.AddUser(user1);
            mediator.AddUser(user2);
            mediator.AddUser(user3);
            mediator.AddUser(user4);

            user1.Send("Hi All");

        }

    }
}
