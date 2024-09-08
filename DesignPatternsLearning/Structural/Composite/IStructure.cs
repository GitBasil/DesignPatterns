namespace DesignPatternsLearning.Structural.Composite
{
    // Interface IStructure
    public interface IStructure
    {
        void Enter();
        void Exit();
        void Location();
        string GetName();
    }
}
