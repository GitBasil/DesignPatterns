namespace DesignPatternsLearning.Behavioral.Command
{
    public class Document
    {
        private string _content = string.Empty;

        public void InsertText(int position, string text)
        {
            if (position < 0 || position > _content.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(position));
            }
            _content = _content.Insert(position, text);
        }

        public void DeleteText(int position, int length)
        {
            if (position < 0 || position + length > _content.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            _content = _content.Remove(position, length);
        }

        public string GetContent()
        {
            return _content;
        }
    }
}
