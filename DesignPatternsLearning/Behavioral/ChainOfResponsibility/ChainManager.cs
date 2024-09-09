namespace DesignPatternsLearning.Behavioral.ChainOfResponsibility
{
    // ChainManager to internally set up the chain of handlers
    public class ChainManager
    {
        private readonly IHandler _firstHandler;

        public ChainManager()
        {
            // Internally setting up the chain of handlers
            _firstHandler = new LowLevelHandler();
            var midHandler = new MidLevelHandler();
            var highHandler = new HighLevelHandler();

            _firstHandler.SetNext(midHandler).SetNext(highHandler);
        }

        public void ProcessRequest(string request)
        {
            // Client only interacts with the first handler
            _firstHandler.Handle(request);
        }
    }
}
