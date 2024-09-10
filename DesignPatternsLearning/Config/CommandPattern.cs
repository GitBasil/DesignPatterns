using DesignPatternsLearning.Behavioral.Command;

namespace DesignPatternsLearning.Config
{
    public class CommandPattern : IPattern
    {
        public void Test()
        {
            Document document = new Document();
            CommandManager commandManager = CommandManager.GetInstance();

            // Create and Invoke the paste command
            ICommand pasteCommand = new PasteCommand(document, 0, "Hello, World!");
            commandManager.InvokeCommand(pasteCommand);
            Console.WriteLine("After paste: " + document.GetContent());

            // Create and Invoke the paste command
            ICommand pasteCommand1 = new PasteCommand(document, document.GetContent().Length, " You are welcome! ");
            commandManager.InvokeCommand(pasteCommand1);
            Console.WriteLine("After paste: " + document.GetContent());

            // Undo the paste command
            commandManager.Undo();
            Console.WriteLine("After undo: " + document.GetContent());
        }
    }
}
