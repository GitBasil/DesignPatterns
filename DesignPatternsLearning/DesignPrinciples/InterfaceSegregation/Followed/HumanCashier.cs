namespace DesignPatternsLearning.InterfaceSegregation.DependencyInversion
{
    public class HumanCashier : ICashier, IHumanWorker
    {
        // Implementation of ICashier methods
        public void ScanItem()
        {
            Console.WriteLine("Human cashier scans the item.");
        }

        public void TakePayment()
        {
            Console.WriteLine("Human cashier takes payment.");
        }

        public void DispenseChange()
        {
            Console.WriteLine("Human cashier dispenses change.");
        }

        // Implementation of IHumanWorker methods
        public void StartShift()
        {
            Console.WriteLine("Human cashier starts shift.");
        }

        public void TakeBreak()
        {
            Console.WriteLine("Human cashier takes a break.");
        }

        public void CompleteShift()
        {
            Console.WriteLine("Human cashier completes shift.");
        }
    }
}