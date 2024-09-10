using DesignPatternsLearning.Behavioral.State;

namespace DesignPatternsLearning.Config
{
    public class StatePattern : IPattern
    {
        public void Test()
        {
            VendingMachine vendingMachine = new VendingMachine(2);

            vendingMachine.InsertDollar();
            vendingMachine.Dispense();
            vendingMachine.InsertDollar();
            vendingMachine.Dispense();
            vendingMachine.InsertDollar();
        }
    }
}
