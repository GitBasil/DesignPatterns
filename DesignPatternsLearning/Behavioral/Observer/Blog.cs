namespace DesignPatternsLearning.Behavioral.Observer
{
    public class Blog : Subject
    {
        private string? _state;

        public string? GetState()
        {
            return _state;
        }

        public void SetState(string state)
        {
            _state = state;
            Notify();
        }
    }
}
