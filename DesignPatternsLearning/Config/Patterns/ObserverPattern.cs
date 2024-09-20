using DesignPatternsLearning.Behavioral.Observer;

namespace DesignPatternsLearning.Config
{
    public class ObserverPattern : IPattern
    {
        public void Test()
        {
            // Create a blog (subject)
            Blog blog = new Blog();

            // Create subscribers (observers)
            Subscriber sub1 = new Subscriber("Alice", blog);
            Subscriber sub2 = new Subscriber("Bob", blog);

            // Register subscribers to the blog
            blog.RegisterObserver(sub1);
            blog.RegisterObserver(sub2);

            // Blog publishes a new post
            blog.SetState("New blog post: Observer Pattern in C#!");

            // Unregister a subscriber
            blog.UnregisterObserver(sub2);

            // Blog publishes another post
            blog.SetState("New blog post: Command Pattern in C#!");
        }
    }
}
