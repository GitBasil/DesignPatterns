namespace DesignPatternsLearning.Structural.Adapter
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(string customerName, decimal amount);
    }
}
