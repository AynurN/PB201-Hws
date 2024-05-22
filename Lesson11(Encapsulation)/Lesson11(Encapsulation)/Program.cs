

namespace Lesson11_Encapsulation_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Lord of rings", 2582, 20, "Fantastic");
            Book book2 = new Book("Martin Eden", 1638, 10, "Dram");
            Book book3 = new Book("The Picture ofDorian Gray", 2873, 12, "Philosophical");
            Book book4 = new Book("Little Prince", 3381, 6, "Fantastic");
            Book book5 = new Book("Atomic Habits", 7893, 16, "Psicology");
            Library books=new Library();
            books.AddBook(book1);
            books.AddBook(book2);
            books.AddBook(book3);
            books.AddBook(book4);
            books.AddBook(book5);
            Console.WriteLine(books.GetBookById(1638).Name);
            Console.WriteLine(books.GetBookByName("Little Prince").Price);
            foreach (var book in books.GetFilteredBooks("fantastic"))
            {
                Console.WriteLine(book.Name);
            }
            foreach (var book in books.GetFilteredBooks(10, 20))
            {
                Console.WriteLine(book.Name);
            }
        }
    }
}
