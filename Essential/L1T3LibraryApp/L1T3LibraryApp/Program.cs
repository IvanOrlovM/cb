using System;

namespace L1T3LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            Title title = new Title("The Great Gatsby ");
            book.AddTitle(title);

            Author author = new Author("by F. Scott Fitzgerald ");
            book.AddAuthor(author);

            Content content = new Content("\n CONTENT... ");
            book.AddContent(content);

            book.Show();

            Console.ReadKey();
        }
    }
}
