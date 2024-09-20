namespace DesignPatternsLearning.InterfaceSegregation.DependencyInversion.Violation
{
    public interface ICashier
    {
        void ScanItem();
        void TakePayment();
        void DispenseChange();
        void StartShift(); // Only humans 
        void TakeBreak(); // Only humans 
        void CompleteShift(); // Only humans 
    }
}