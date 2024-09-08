namespace DesignPatternsLearning.Structural.Decorator
{
    public class BasicWebPage : WebPage
    {
        private string html;
        private string styleSheet;
        private string scripts;

        public BasicWebPage(string html, string styleSheet, string scripts)
        {
            this.html = html;
            this.styleSheet = styleSheet;
            this.scripts = scripts;
        }

        public void Display()
        {
            Console.WriteLine($"Displaying basic web page with HTML: {html}, StyleSheet: {styleSheet}, Scripts: {scripts}");
        }
    }
}
