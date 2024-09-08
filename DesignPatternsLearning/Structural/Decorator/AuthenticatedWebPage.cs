namespace DesignPatternsLearning.Structural.Decorator
{
    public class AuthenticatedWebPage : WebPageDecorator
    {
        public AuthenticatedWebPage(WebPage page) : base(page) { }

        public void AuthenticateUser()
        {
            Console.WriteLine("Authenticating user...");
        }

        public override void Display()
        {
            AuthenticateUser();
            base.Display();
        }
    }
}
