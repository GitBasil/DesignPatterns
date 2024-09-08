namespace DesignPatternsLearning.Structural.Adapter
{
    public class ModernPaymentAdapter : IPaymentProcessor
    {
        private readonly ModernPaymentGateway _modernGateway;

        public ModernPaymentAdapter(ModernPaymentGateway modernGateway)
        {
            _modernGateway = modernGateway;
        }

        public void ProcessPayment(string customerName, decimal amount)
        {
            // Adapts the ModernPaymentGateway's interface to match IPaymentProcessor
            _modernGateway.ExecuteTransaction(customerName, amount);
        }
    }
}
