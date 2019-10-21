using System;
using System.Collections.Generic;

namespace Bridgelabz.DesignPattern.BehavioralDesignPatttern.MediatorDesignPatter
{
    public class ChatMediatorImpl : ChatMediator
    {
        private List<User> users;

        public ChatMediatorImpl()
        {
            this.users = new List<User>();
        }


        public void AddUser(User user)
        {
            this.users.Add(user);
        }


        public void SendMessage(String msg, User user)
        {
            foreach(User u in this.users)
            {
                //message should not be received by the user sending it
                if (u != user)
                {
                    u.Receive(msg);
                }
            }


        }
    }
}
