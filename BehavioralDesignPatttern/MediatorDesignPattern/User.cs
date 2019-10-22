﻿using System;
namespace Bridgelabz.DesignPattern.BehavioralDesignPatttern.MediatorDesignPatter
{
    public abstract class User
    {
        protected ChatMediator mediator;
        protected String name;

        public User(ChatMediator med, String name)
        {
            this.mediator = med;
            this.name = name;
        }

        public abstract void Send(String msg);

        public abstract void Receive(String msg);
    }
}

