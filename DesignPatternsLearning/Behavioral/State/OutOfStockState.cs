namespace DesignPatternsLearning.Behavioral.State
{
    public class OutOfStockState : IState
    {
        public void InsertDollar(VendingMachine vendingMachine)
        {
            Console.WriteLine("Out of stock. Can't insert dollar.");
        }

        public void EjectMoney(VendingMachine vendingMachine)
        {
            Console.WriteLine("No money to return.");
        }

        public void Dispense(VendingMachine vendingMachine)
        {
            Console.WriteLine("Out of stock. Can't dispense.");
        }
    }

}
