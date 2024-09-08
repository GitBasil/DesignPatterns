namespace DesignPatternsLearning.Structural.Proxy
{
    public class Warehouse : IOrder
    {
        public Dictionary<string, int> Stock { get; private set; }
        public string Address { get; private set; }

        public Warehouse(Dictionary<string, int> stock, string address)
        {
            Stock = stock;
            Address = address;
        }

        public void FulfillOrder(Order order)
        {
            // Assuming OrderFulfillment has already checked the stock
            Stock[order.Item] = Stock[order.Item] - order.Quantity;
            Console.WriteLine($"Order for {order.Quantity} {order.Item}(s) fulfilled by Warehouse at {Address}.");
        }

        public int CurrentInventory(string item)
        {
            if (Stock.ContainsKey(item))
            {
                return Stock[item];
            }
            return 0;
        }
    }
}
