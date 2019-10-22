using System;
namespace Bridgelabz.DesignPattern.BehavioralDesignPatttern.MediatorDesignPatter
{
    public interface ChatMediator
    {
        public void SendMessage(String msg, User user);

        void AddUser(User user);
    }
}
