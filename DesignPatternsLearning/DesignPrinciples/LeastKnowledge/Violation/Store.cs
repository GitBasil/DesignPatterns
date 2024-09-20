namespace DesignPatternsLearning.InterfaceSegregation.LeastKnowledge.Violation
{
    public class Store
    {
        public bool CanAfford(Customer customer, decimal price)
        {
            // Violating the Principle of Least Knowledge by reaching into nested properties
            return customer.Wallet.Money.Amount >= price;
        }
    }
}