using DesignPatternsLearning.Structural.Adapter;

namespace DesignPatternsLearning.Config
{
    public class AdapterPattern : IPattern
    {
        public void Test()
        {
            // Using the legacy payment gateway directly
            LegacyPaymentGateway legacyGateway = new LegacyPaymentGateway();
            IPaymentProcessor legacyProcessor = new LegacyPaymentAdapter(legacyGateway);
            legacyProcessor.ProcessPayment("John Doe", 100.00m);

            // Now integrating with the modern payment gateway using the Adapter
            ModernPaymentGateway modernGateway = new ModernPaymentGateway();
            IPaymentProcessor modernProcessor = new ModernPaymentAdapter(modernGateway);
            modernProcessor.ProcessPayment("John Doe", 100); ;
        }
    }
}
