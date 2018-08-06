using System;

namespace L1T3LibraryApp
{
    public class Title
    {
        private readonly string _title;

        public Title(string title)
        {
            _title = title;
        }

        public void Show()
        {
            Console.Write(_title);
        }
    }
}