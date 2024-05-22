using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_Encapsulation_
{
    internal class Book: Product
    {  
        public string  Genre { get; set; }
        public Book(string name, int ID, double Price, string Genre):base(name,ID,Price)
        {
            this.Genre= Genre;
        }
    }
}
