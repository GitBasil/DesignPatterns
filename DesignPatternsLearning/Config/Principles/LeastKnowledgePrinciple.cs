
using DesignPatternsLearning.InterfaceSegregation.LeastKnowledge;

namespace DesignPatternsLearning.Config
{
    public class LeastKnowledgePrinciple : IPattern
    {
        public void Test()
        {
            Customer customer = new Customer(100m);
            Store store = new Store();

            bool canAfford = store.CanAfford(customer, 50m);
            Console.WriteLine($"Can the customer afford the item? {canAfford}");
        }
    }
}