namespace DesignPatternsLearning.Structural.Decorator
{
    public class AuthorizedWebPage : WebPageDecorator
    {
        public AuthorizedWebPage(WebPage page) : base(page) { }

        public void AuthorizeUser()
        {
            Console.WriteLine("Authorizing user...");
        }

        public override void Display()
        {
            AuthorizeUser();
            base.Display();
        }
    }
}
