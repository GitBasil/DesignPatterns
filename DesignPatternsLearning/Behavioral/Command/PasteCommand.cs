namespace DesignPatternsLearning.Behavioral.Command
{
    public class PasteCommand : ICommand
    {
        private Document _document;
        private int _position;
        private string _text;

        public PasteCommand(Document document, int position, string text)
        {
            _document = document;
            _position = position;
            _text = text;
        }

        public void Execute()
        {
            _document.InsertText(_position, _text);
        }

        public void Unexecute()
        {
            _document.DeleteText(_position, _text.Length);
        }

        public bool IsReversible()
        {
            return true;
        }
    }
}
