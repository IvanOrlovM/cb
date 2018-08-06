using System;

namespace L1T3LibraryApp
{
    public class Content
    {
        private readonly string _content;

        public Content(string content)
        {
            _content = content;
        }

        public void Show()
        {
            Console.Write(_content);
        }
    }
}