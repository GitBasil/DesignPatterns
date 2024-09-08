namespace DesignPatternsLearning.Structural.Adapter
{
    public class LegacyPaymentAdapter : IPaymentProcessor
    {
        private readonly LegacyPaymentGateway _legacyGateway;

        public LegacyPaymentAdapter(LegacyPaymentGateway legacyGateway)
        {
            _legacyGateway = legacyGateway;
        }

        public void ProcessPayment(string customerName, decimal amount)
        {
            _legacyGateway.MakePayment(customerName, amount);
        }
    }
}
