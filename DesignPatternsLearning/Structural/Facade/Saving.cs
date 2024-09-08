namespace DesignPatternsLearning.Structural.Facade
{
    public class Saving : AccountBase
    {
        public Saving(decimal initAmount) : base(initAmount)
        {
            Console.WriteLine($"Created a new Saving account with account number {accountNumber}.");
        }

        // Additional behavior specific to Saving can go here
    }
}
