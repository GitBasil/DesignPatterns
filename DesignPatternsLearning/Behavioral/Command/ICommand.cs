namespace DesignPatternsLearning.Behavioral.Command
{
    public interface ICommand
    {
        void Execute();
        void Unexecute();
        bool IsReversible();
    }
}
