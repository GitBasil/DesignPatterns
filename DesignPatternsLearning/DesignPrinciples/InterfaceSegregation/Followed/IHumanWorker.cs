namespace DesignPatternsLearning.InterfaceSegregation.DependencyInversion
{
    public interface IHumanWorker
    {
        void StartShift();
        void TakeBreak();
        void CompleteShift();
    }
}