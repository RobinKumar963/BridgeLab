// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ChatMediatorImpl.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;

namespace Bridgelabz.DesignPattern.BehavioralDesignPatttern.MediatorDesignPatter
{
    /// <summary>
    /// Concrete mediator
    /// </summary>
    /// <seealso cref="Bridgelabz.DesignPattern.BehavioralDesignPatttern.MediatorDesignPatter.ChatMediator" />
    public class ChatMediatorImpl : ChatMediator
    {
        private List<User> users;

        public ChatMediatorImpl()
        {
            this.users = new List<User>();
        }

        /// <summary>
        /// Adds the user in list.
        /// </summary>
        /// <param name="user">The user.</param>
        public void AddUser(User user)
        {
            this.users.Add(user);
        }

        /// <summary>
        /// Sends the message. 'msg' to User user through user.recieve()
        /// </summary>
        /// <param name="msg">The MSG.</param>
        /// <param name="user">The user.</param>
        public void SendMessage(String msg, User user)
        {
            foreach(User u in this.users)
            {
                ////message should not be received by the user sending it
                if (u != user)
                {
                    u.Receive(msg);
                }
            }


        }
    }
}
