using AccessModifiers.Models;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookLibrary bookLibrary = new BookLibrary("Axundov");

            Book book1 = new Book("Harry Potter", "Rowling");
            Book book2 = new Book("Harry Potter 2", "Rowling");

            Book book3 = new Book("Dedektiv", "Elxan");
            Book book4 = new Book("Kriminal", "Elxan");

            book1.GetInfo();

            bookLibrary.AddBook(book1);
            bookLibrary.AddBook(book2);
            bookLibrary.AddBook(book3);
            bookLibrary.AddBook(book4);
            bookLibrary.ShowAll();


            bookLibrary.RemoveBook(book2);
            bookLibrary.ShowAll();


            bookLibrary.BorrowBook("Harry Potter");
            bookLibrary.ShowAll();


            bookLibrary.ReturnBook("Harry Potter");
            bookLibrary.ShowAll();


            bookLibrary.SearchByAuthor("Elxan");
        }
    }
}
