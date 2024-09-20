namespace DesignPatternsLearning.InterfaceSegregation.LeastKnowledge
{
    public class Store
    {
        public bool CanAfford(Customer customer, decimal price)
        {
            // Store class only knows about Customer's capability, not Wallet or Money details
            return customer.CanAfford(price);
        }
    }
}