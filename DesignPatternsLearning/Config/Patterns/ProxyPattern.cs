using DesignPatternsLearning.Structural.Proxy;

namespace DesignPatternsLearning.Config
{
    public class ProxyPattern : IPattern
    {
        public void Test()
        {
            // Creating stock for warehouses using Dictionary instead of Hashtable
            Dictionary<string, int> warehouse1Stock = new Dictionary<string, int>
            {
                { "Laptop", 10 }
            };

            Dictionary<string, int> warehouse2Stock = new Dictionary<string, int>
            {
                { "Laptop", 5 }
            };

            // Creating warehouses
            Warehouse warehouse1 = new Warehouse(warehouse1Stock, "123 Main St");
            Warehouse warehouse2 = new Warehouse(warehouse2Stock, "456 Elm St");

            // Creating OrderFulfillment instance
            OrderFulfillment orderFulfillment = new OrderFulfillment();
            orderFulfillment.addWarehouse(warehouse1);
            orderFulfillment.addWarehouse(warehouse2);

            // Creating an order
            Order order = new Order("Laptop", 7);

            // Fulfilling the order via OrderFulfillment
            orderFulfillment.FulfillOrder(order);

            // Print remaining stock after fulfillment
            Console.WriteLine($"Remaining stock in {warehouse1.Address}: {warehouse1.CurrentInventory("Laptop")}");
            Console.WriteLine($"Remaining stock in {warehouse2.Address}: {warehouse2.CurrentInventory("Laptop")}");
        }
    }
}
