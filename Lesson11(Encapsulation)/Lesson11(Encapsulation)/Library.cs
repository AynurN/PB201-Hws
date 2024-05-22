using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_Encapsulation_
{
    internal class Library
    {
        public Book[] Books=new Book[0];
        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length+1);
            Books[Books.Length-1]=book;
        }
        public Book GetBookById(int id)
        {
            foreach (var book in Books)
            {
                if (book.ID == id) return book;
            }
            return null;
        }
        public Book GetBookByName(string name)
        {
            foreach (var book in Books)
            {
                if (book.Name.ToLower() == name.ToLower()) return book;
            }
            return null;
        }
        public Book[] GetFilteredBooks(string genre)
        {
            Book[] filteredBooks = Array.Empty<Book>();
            foreach (var book in Books) { 
             if(book.Genre.ToLower() == genre.ToLower())
                {
                    Array.Resize(ref filteredBooks, filteredBooks.Length + 1);
                    filteredBooks[filteredBooks.Length - 1] = book;
                }
            
            }
            return filteredBooks;
        }
        public Book[] GetFilteredBooks(int minPrice, int maxPrice)
        {

            Book[] filteredBooks = Array.Empty<Book>();
            foreach (var book in Books)
            {
                if (book.Price>=minPrice && book.Price<=maxPrice)
                {
                    Array.Resize(ref filteredBooks, filteredBooks.Length + 1);
                    filteredBooks[filteredBooks.Length - 1] = book;
                }

            }
            return filteredBooks;

        }


    }
}
