namespace DesignPatternsLearning.Behavioral.ChainOfResponsibility
{
    // Base Handler interface
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        void Handle(string request);
    }
}
