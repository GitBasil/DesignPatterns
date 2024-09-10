namespace DesignPatternsLearning.Behavioral.State
{
    public class IdleState : IState
    {
        public void InsertDollar(VendingMachine vendingMachine)
        {
            Console.WriteLine("Dollar inserted");
            vendingMachine.SetState(vendingMachine.GetHasOneDollarState());
        }

        public void EjectMoney(VendingMachine vendingMachine)
        {
            Console.WriteLine("No money to return");
        }

        public void Dispense(VendingMachine vendingMachine)
        {
            Console.WriteLine("Payment required");
        }
    }

}
