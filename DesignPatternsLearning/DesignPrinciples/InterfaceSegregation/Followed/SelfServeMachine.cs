namespace DesignPatternsLearning.InterfaceSegregation.DependencyInversion
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
    }
}