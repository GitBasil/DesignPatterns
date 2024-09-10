using DesignPatternsLearning.Behavioral.Mediator;

namespace DesignPatternsLearning.Config
{
    public class MediatorPattern : IPattern
    {
        public void Test()
        {
            // Create mediator (chat room)
            IChatRoomMediator chatRoom = new ChatRoom();

            // Create users
            User user1 = new User(chatRoom, "Alice");
            User user2 = new User(chatRoom, "Bob");
            User user3 = new User(chatRoom, "Charlie");

            // Add users to the chat room
            chatRoom.AddUser(user1);
            chatRoom.AddUser(user2);
            chatRoom.AddUser(user3);

            // Users send messages
            user1.Send("Hello everyone!");
            user2.Send("Hi Alice!");
            user3.Send("Hey folks!");
        }
    }
}
