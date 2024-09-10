using System;
using System.Collections.Generic;

namespace DesignPatternsLearning.Behavioral.Mediator
{
    public class ChatRoom : IChatRoomMediator
    {
        private List<User> _users = new List<User>();

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public void SendMessage(string message, User user)
        {
            foreach (var u in _users)
            {
                // Ensure the message isn't sent to the sender
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }
}
