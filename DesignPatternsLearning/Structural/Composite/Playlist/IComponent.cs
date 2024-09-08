namespace DesignPatternsLearning.Structural.Composite
{
    public interface IComponent
    {
        public void play();
        public void setPlaybackSpeed(double speed);
        public string getName();
    }
}