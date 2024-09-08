namespace DesignPatternsLearning.Structural.Proxy
{
    public class Order
    {
        public string Item { get; set; }
        public int Quantity { get; set; }

        public Order(string item, int quantity)
        {
            Item = item;
            Quantity = quantity;
        }
    }
}
