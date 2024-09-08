namespace DesignPatternsLearning.Structural.Facade
{
    public class Chequing : AccountBase
    {
        public Chequing(decimal initAmount) : base(initAmount)
        {
            Console.WriteLine($"Created a new Chequing account with account number {accountNumber}.");
        }

        // Additional behavior specific to Chequing can go here
    }
}
