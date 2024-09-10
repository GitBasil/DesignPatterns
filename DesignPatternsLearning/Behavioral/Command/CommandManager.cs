namespace DesignPatternsLearning.Behavioral.Command
{
    public class CommandManager
    {
        private static CommandManager? _instance;
        private Stack<ICommand> _commandHistory = new Stack<ICommand>();

        private CommandManager() { }

        public static CommandManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CommandManager();
            }
            return _instance;
        }

        public void InvokeCommand(ICommand command)
        {
            command.Execute();
            if (command.IsReversible())
            {
                _commandHistory.Push(command);
            }
        }

        public void Undo()
        {
            if (_commandHistory.Count > 0)
            {
                var command = _commandHistory.Pop();
                command.Unexecute();
            }
        }
    }
}
