namespace DesignPatternsLearning.Structural.Adapter
{
    public class ModernPaymentGateway
    {
        public void ExecuteTransaction(string fullName, decimal transactionAmount)
        {
            Console.WriteLine($"Executing transaction of {transactionAmount} for {fullName} using the modern payment gateway.");
        }
    }
}
