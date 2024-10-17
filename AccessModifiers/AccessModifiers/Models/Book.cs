namespace AccessModifiers.Models
{
    internal class Book
    {
        private string _name;
        private string _author;
        private bool _isAvailable;

        public string Name { get { return _name; } set { _name = value; } }
        public string Author { get { return _author; } set { _author = value; } }
        public bool IsAvailable { get { return _isAvailable; } set { _isAvailable = value; } }

        public Book(string name, string author, bool isavailable = true)
        {
            Name = name;
            Author = author;
            IsAvailable = isavailable;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}\nAuthor: {Author}\nIs Available: {IsAvailable}\n");
        }
    }
}
