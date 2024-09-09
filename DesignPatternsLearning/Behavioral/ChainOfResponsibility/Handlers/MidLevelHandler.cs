namespace DesignPatternsLearning.Behavioral.ChainOfResponsibility
{
    // Concrete MidLevelHandler
    public class MidLevelHandler : Handler
    {
        public override void Handle(string request)
        {
            if (request == "mid")
            {
                System.Console.WriteLine("MidLevelHandler handled the request.");
            }
            else
            {
                System.Console.WriteLine("MidLevelHandler couldn't handle the request. Passing to the next handler...");
                base.Handle(request);
            }
        }
    }
}
