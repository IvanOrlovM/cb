using System;

namespace L1T3LibraryApp
{
    public class Author
    {
        private readonly string _name;

        public Author(string name)
        {
            _name = name;
        }

        public void Show()
        {
            Console.Write(_name);
        }
    }
}