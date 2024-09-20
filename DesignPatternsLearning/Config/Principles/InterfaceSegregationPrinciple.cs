using DesignPatternsLearning.InterfaceSegregation.DependencyInversion;

namespace DesignPatternsLearning.Config
{
    public class InterfaceSegregationPrinciple : IPattern
    {
        public void Test()
        {
            ICashier selfServeMachine = new SelfServeMachine();
            ICashier humanCashier = new HumanCashier();
            IHumanWorker humanWorker = new HumanCashier();

            // SelfServeMachine operations
            selfServeMachine.ScanItem();
            selfServeMachine.TakePayment();
            selfServeMachine.DispenseChange();

            Console.WriteLine();

            // HumanCashier as a Cashier operations
            humanCashier.ScanItem();
            humanCashier.TakePayment();
            humanCashier.DispenseChange();

            Console.WriteLine();

            // HumanCashier as a HumanWorker operations
            humanWorker.StartShift();
            humanWorker.TakeBreak();
            humanWorker.CompleteShift();
        }
    }
}