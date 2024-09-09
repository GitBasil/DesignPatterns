using DesignPatternsLearning.Behavioral.ChainOfResponsibility;

namespace DesignPatternsLearning.Config
{
    public class ChainOfResponsibilityPattern : IPattern
    {
        public void Test()
        {
            // Client only knows about the ChainManager, not individual handlers
            var chainManager = new ChainManager();

            System.Console.WriteLine("Client sends 'low' request:");
            chainManager.ProcessRequest("low");

            System.Console.WriteLine("\nClient sends 'mid' request:");
            chainManager.ProcessRequest("mid");

            System.Console.WriteLine("\nClient sends 'high' request:");
            chainManager.ProcessRequest("high");

            System.Console.WriteLine("\nClient sends 'unknown' request:");
            chainManager.ProcessRequest("unknown");
        }
    }
}
