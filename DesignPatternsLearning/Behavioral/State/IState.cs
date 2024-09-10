namespace DesignPatternsLearning.Behavioral.State
{
    public interface IState
    {
        void InsertDollar(VendingMachine vendingMachine);
        void EjectMoney(VendingMachine vendingMachine);
        void Dispense(VendingMachine vendingMachine);
    }
}
