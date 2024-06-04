using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_Generics_
{
    public class Library
    {
        Book[] books=Array.Empty<Book>();
        private void AddBook<T>(T book, ref T[] booksarr)
        {
            Array.Resize(ref booksarr, booksarr.Length + 1);
            booksarr[^1]=book;

        }
        private void RemoveBook<T>(T book, ref T[] booksarr)
        {
            int count = 0;
            foreach (var item in booksarr)
            {
                if (!item.Equals(book))
                {
                    count++;
                }
            }
            T[] newBooks = new T[count];
            int index = 0;
            foreach (var item in booksarr)
            {
                if (!item.Equals(book))
                {
                    newBooks[index++] = item;
                }
            }
            booksarr = newBooks;
        }
        public void AddBookToTheLibrary(Book book)
        {
            AddBook(book, ref books);
        }
        public Book[] FindAllBooksByName(string name)
        {  
            Book[] booksWithName = Array.Empty<Book>();
            foreach (Book book in books)
            {
                if (book.Name.Contains(name.Trim(),StringComparison.OrdinalIgnoreCase))
                {
                    AddBook(book,ref booksWithName);

                }
            }
            return booksWithName;

        }
        public Book? FindBookByCode(string code)
        {
            code=code.Trim();
            foreach (Book book in books)
            {
                if(book.Code==code)
                    return book;
            }
            return null;

        }
        public Book[] FindAllBooksByPageCountRange(int min, int max)
        {
            Book[] bookInTheRange = Array.Empty<Book>();
            foreach (var book in books)
            {
                if (book.PageCount >= min && book.PageCount <= max)
                    AddBook(book,ref bookInTheRange);
            }
            return bookInTheRange;
        }

        public void RemoveBookByCode(string code)
        {
            foreach (var book in books)
            {
                if (book.Code == code)
                    RemoveBook(book,ref books);
            }
        }
        public void ShowLibraryInfo()
        {
            foreach (var item in books)
            {
                Console.WriteLine(item);
            }
        }
    }
}
