using System;

namespace L1T3LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            Title title = new Title("title");
            book.AddTitle(title);

            Author author = new Author("author");
            book.AddAuthor(author);

            Content content = new Content("content");
            book.AddContent(content);

            book.Show();

            Console.ReadKey();
        }
    }
}
