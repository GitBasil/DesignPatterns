namespace DesignPatternsLearning.Behavioral.ChainOfResponsibility
{
    // Concrete LowLevelHandler
    public class LowLevelHandler : Handler
    {
        public override void Handle(string request)
        {
            if (request == "low")
            {
                System.Console.WriteLine("LowLevelHandler handled the request.");
            }
            else
            {
                System.Console.WriteLine("LowLevelHandler couldn't handle the request. Passing to the next handler...");
                base.Handle(request);
            }
        }
    }
}
