namespace DesignPatternsLearning.Behavioral.ChainOfResponsibility
{
    // Abstract base handler
    public abstract class Handler : IHandler
    {
        private IHandler? _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public virtual void Handle(string request)
        {
            if (_nextHandler != null)
            {
                _nextHandler.Handle(request);
            }
            else
            {
                System.Console.WriteLine($"No handler could handle the request: {request}");
            }
        }
    }
}
