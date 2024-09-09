namespace DesignPatternsLearning.Behavioral.ChainOfResponsibility
{
    // Concrete HighLevelHandler
    public class HighLevelHandler : Handler
    {
        public override void Handle(string request)
        {
            if (request == "high")
            {
                System.Console.WriteLine("HighLevelHandler handled the request.");
            }
            else
            {
                System.Console.WriteLine("HighLevelHandler couldn't handle the request.");
                base.Handle(request);
            }
        }
    }
}
