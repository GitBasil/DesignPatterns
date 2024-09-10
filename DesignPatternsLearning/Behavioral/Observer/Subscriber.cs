namespace DesignPatternsLearning.Behavioral.Observer
{
    public class Subscriber : IObserver
    {
        private string _name;
        private Blog _blog;

        public Subscriber(string name, Blog blog)
        {
            _name = name;
            _blog = blog;
        }

        public void Update()
        {
            Console.WriteLine($"{_name} received a blog update: {_blog.GetState()}");
        }
    }
}
