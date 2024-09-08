namespace DesignPatternsLearning.Structural.Decorator
{
    public abstract class WebPageDecorator : WebPage
    {
        protected WebPage page;

        public WebPageDecorator(WebPage page)
        {
            this.page = page;
        }

        public virtual void Display()
        {
            page.Display();
        }
    }
}
