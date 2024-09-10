namespace DesignPatternsLearning.Behavioral.Mediator
{
    public interface IChatRoomMediator
    {
        void SendMessage(string message, User user);
        void AddUser(User user);
    }
}
