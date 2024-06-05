using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyHelperClassLibrary;

namespace Lesson14_Generics_
{
    public class Library
    {
        Book[] books=Array.Empty<Book>();
        public Book this[int index] {
            get { return books[index]; }
            private set { }
        }

        public void AddBookToTheLibrary(Book book)
        {
            Helper.Add(book, ref books);
        }
        public Book[] FindAllBooksByName(string name)
        {  
            Book[] booksWithName = Array.Empty<Book>();
            foreach (Book book in books)
            {
                if (book.Name.Contains(name.Trim(),StringComparison.OrdinalIgnoreCase))
                {
                    Helper.Add(book,ref booksWithName);

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
                    Helper.Add(book,ref bookInTheRange);
            }
            return bookInTheRange;
        }

        public void RemoveBookByCode(string code)
        {
            foreach (var book in books)
            {
                if (book.Code == code)
                    Helper.Remove(book,ref books);
            }
        }
        public Book[] SearchBooks(string searched)
        {
            Book[] searchedBooks = Array.Empty<Book>();
            searched = searched.ToLower().Trim();
            foreach (var book in books)
            {
               if(book.Name.ToLower().Contains(searched) || book.AuthorName.ToLower().Contains(searched) || book.PageCount.ToString().Contains(searched))
                {
                    Helper.Add(book, ref searchedBooks);
                }
            }
            return searchedBooks;
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
