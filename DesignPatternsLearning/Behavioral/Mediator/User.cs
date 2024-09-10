using System;

namespace DesignPatternsLearning.Behavioral.Mediator
{
    public class User
    {
        private IChatRoomMediator _chatRoom;
        public string Name { get; }

        public User(IChatRoomMediator chatRoom, string name)
        {
            _chatRoom = chatRoom;
            Name = name;
        }

        public void Send(string message)
        {
            Console.WriteLine($"{Name} sends: {message}");
            _chatRoom.SendMessage(message, this);
        }

        public void Receive(string message)
        {
            Console.WriteLine($"{Name} receives: {message}");
        }
    }
}
