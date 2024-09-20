namespace DesignPatternsLearning.InterfaceSegregation.LeastKnowledge
{
    public class Customer
    {
        private Wallet Wallet { get; set; }

        public Customer(decimal amount)
        {
            Wallet = new Wallet(amount);
        }

        // Encapsulates the knowledge about the Wallet
        public bool CanAfford(decimal price)
        {
            return Wallet.CanAfford(price);
        }
    }
}