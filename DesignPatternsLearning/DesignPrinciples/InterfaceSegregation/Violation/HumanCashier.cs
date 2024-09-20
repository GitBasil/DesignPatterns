namespace DesignPatternsLearning.InterfaceSegregation.DependencyInversion.Violation
{
    public class HumanCashier : ICashier
    {
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