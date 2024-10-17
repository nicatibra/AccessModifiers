namespace AccessModifiers.Models
{
    class BookLibrary
    {
        public string _name;
        public Book[] _books = new Book[0];
        public BookLibrary(string name)
        {
            _name = name;
        }

        public string Name { get { return _name; } set { _name = value; } }

        public Book[] Books { get { return _books; } set { _books = value; } }

        public void AddBook(Book book)
        {
            Array.Resize(ref _books, _books.Length + 1);
            _books[_books.Length - 1] = book;
        }

        public void RemoveBook(Book book)
        {
            int findIndex = Array.IndexOf(_books, book);

            if (findIndex != -1)
            {
                Console.WriteLine($"{book.Name} removed from the library.");
                _books[findIndex] = _books[_books.Length - 1];
                Array.Resize(ref _books, _books.Length - 1);
            }
            else
            {
                Console.WriteLine($"{book.Name} not found in the library.");
            }
        }

        public void ShowAll()
        {
            Console.WriteLine("Books in library:");
            for (int i = 0; i < _books.Length; i++)
            {

                Console.WriteLine($"Name: {Books[i].Name}, Author: {Books[i].Author}, Available: {Books[i].IsAvailable}");
            }
            Console.WriteLine("");

        }

        public void BorrowBook(string name)
        {
            for (int i = 0; i < _books.Length; i++)
            {
                if (_books[i].Name == name && _books[i].IsAvailable)
                {
                    _books[i].IsAvailable = false;
                    Console.WriteLine($"{name} has been borrowed.");
                    return;
                }
            }
            Console.WriteLine($"{name} is not available or just does not exist.");
        }

        public void ReturnBook(string name)
        {
            for (int i = 0; i < _books.Length; i++)
            {
                if (_books[i].Name == name && !_books[i].IsAvailable)
                {
                    _books[i].IsAvailable = true;
                    Console.WriteLine($"{name} has been returned.");
                    return;
                }
            }
            Console.WriteLine($"{name} is already available or just does not exist.");
        }

        public void SearchByAuthor(string author)
        {
            bool found = false;
            Console.WriteLine($"Books by {author}:");

            for (int i = 0; i < _books.Length; i++)
            {
                if (_books[i].Author.ToLower() == author.ToLower())
                {
                    Console.WriteLine($"- {_books[i].Name}");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine($"No books found by {author}.");
            }
        }
    }
}
