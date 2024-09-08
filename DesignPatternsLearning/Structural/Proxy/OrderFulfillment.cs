namespace DesignPatternsLearning.Structural.Proxy
{
    public class OrderFulfillment : IOrder
    {
        private List<Warehouse> warehouses;

        public OrderFulfillment()
        {
            this.warehouses = new List<Warehouse>();
        }

        public void addWarehouse(Warehouse warehouse)
        {
            this.warehouses.Add(warehouse);
        }

        public void FulfillOrder(Order order)
        {
            foreach (var warehouse in warehouses)
            {
                int inventory = warehouse.CurrentInventory(order.Item);
                if (inventory >= order.Quantity)
                {
                    warehouse.FulfillOrder(order);
                    return;
                }
            }
            Console.WriteLine("Order cannot be fulfilled, insufficient stock across all warehouses.");
        }
    }
}
