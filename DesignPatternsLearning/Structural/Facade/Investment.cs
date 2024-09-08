namespace DesignPatternsLearning.Structural.Facade
{
    public class Investment : AccountBase
    {
        public Investment(decimal initAmount) : base(initAmount)
        {
            Console.WriteLine($"Created a new Investment account with account number {accountNumber}.");
        }

        // Additional behavior specific to Investment can go here
    }
}
