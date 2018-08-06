using System;

namespace L1T3LibraryApp
{
    public class Book
    {
        private Title _title;
        private Author _author;
        private Content _content;

        public void AddTitle(Title title)
        {
            _title = title;
        }

        public void AddAuthor(Author author)
        {
            _author = author;
        }

        public void AddContent(Content content)
        {
            _content = content;
        }

        public void Show()
        {
            _title.Show();
            Console.ForegroundColor = ConsoleColor.Green;
            _author.Show();
            Console.ForegroundColor = ConsoleColor.Red;
            _content.Show();
        }
    }
}