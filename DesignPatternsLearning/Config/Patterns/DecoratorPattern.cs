using DesignPatternsLearning.Structural.Decorator;

namespace DesignPatternsLearning.Config
{
    public class DecoratorPattern : IPattern
    {
        public void Test()
        {
            WebPage basicPage = new BasicWebPage("index.html", "style.css", "script.js");

            WebPage authenticatedPage = new AuthenticatedWebPage(basicPage);
            WebPage authorizedPage = new AuthorizedWebPage(authenticatedPage);

            authorizedPage.Display();
        }
    }
}
