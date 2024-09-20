namespace DesignPatternsLearning.InterfaceSegregation.LeastKnowledge.Violation
{
    public class Customer
    {
        public Wallet Wallet { get; private set; }

        public Customer(decimal amount)
        {
            Wallet = new Wallet(amount);
        }
    }
}