namespace DesignPatternsLearning.Behavioral.State
{
    public class HasOneDollarState : IState
    {
        public void InsertDollar(VendingMachine vendingMachine)
        {
            Console.WriteLine("Already have one dollar");
            vendingMachine.DoReturnMoney();
            vendingMachine.SetState(vendingMachine.GetIdleState());
        }

        public void EjectMoney(VendingMachine vendingMachine)
        {
            Console.WriteLine("Returning money");
            vendingMachine.DoReturnMoney();
            vendingMachine.SetState(vendingMachine.GetIdleState());
        }

        public void Dispense(VendingMachine vendingMachine)
        {
            Console.WriteLine($"Releasing product, Count: {vendingMachine.GetCount()}");
            if (vendingMachine.GetCount() > 1)
            {
                vendingMachine.DoReleaseProduct();
                vendingMachine.SetState(vendingMachine.GetIdleState());
            }
            else
            {
                vendingMachine.DoReleaseProduct();
                vendingMachine.SetState(vendingMachine.GetOutOfStockState());
            }
        }
    }

}
