namespace DesignPatternsLearning.Structural.Adapter
{
    public class LegacyPaymentGateway
    {
        public void MakePayment(string accountHolderName, decimal total)
        {
            Console.WriteLine($"Processing payment of {total} for {accountHolderName} using the legacy payment gateway.");
        }
    }
}
