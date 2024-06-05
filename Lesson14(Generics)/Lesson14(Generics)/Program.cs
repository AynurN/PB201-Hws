namespace Lesson14_Generics_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "J.K.Rawling", 400);
            Book book2 = new Book("My little orange tree", "Jose de Saramago", 200);
            Book book3 = new Book("Animal Farm", "Gorge Orwell", 100);
            Book book4 = new Book("Kite Runner", "Khalid Huseyn", 500);
            Book book5 = new Book("Little Women", "Louisa May", 300);
            Library library = new Library();
            library.AddBookToTheLibrary(book1);
            library.AddBookToTheLibrary(book2);
            library.AddBookToTheLibrary(book3);
            library.AddBookToTheLibrary(book4);
            library.AddBookToTheLibrary(book5);
            //library.RemoveBookByCode("MY2");
            //foreach (var item in library.FindAllBooksByName("potter"))
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(library[2]);
            foreach(var book in library.SearchBooks("400"))
            {
                Console.WriteLine(book);
            }
            //}
            //Console.WriteLine(library.FindBookByCode("AN3"));

            //    foreach(var book in library.FindAllBooksByPageCountRange(200, 400))
            //{
            //    Console.WriteLine(book);
            //}



            //library.ShowLibraryInfo();
        }
    }
}
