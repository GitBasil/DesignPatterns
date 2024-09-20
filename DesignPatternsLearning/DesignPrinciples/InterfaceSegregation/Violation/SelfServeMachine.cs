namespace DesignPatternsLearning.InterfaceSegregation.DependencyInversion.Violation
{
    public class SelfServeMachine : ICashier
    {
        public void ScanItem()
        {
            Console.WriteLine("Self-serve machine scans the item.");
        }

        public void TakePayment()
        {
            Console.WriteLine("Self-serve machine takes payment.");
        }

        public void DispenseChange()
        {
            Console.WriteLine("Self-serve machine dispenses change.");
        }

        public void StartShift()
        {
            Console.WriteLine("Self-serve machine starts shift.");
        }

        public void TakeBreak()
        {
            Console.WriteLine("Self-serve machine takes a break.");
        }

        public void CompleteShift()
        {
            Console.WriteLine("Self-serve machine completes shift.");
        }
    }
}