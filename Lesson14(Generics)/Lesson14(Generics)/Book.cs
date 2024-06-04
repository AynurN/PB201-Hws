using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_Generics_
{
    public class Book
    { private static int _count { get; set; }
        private string _code { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Code {
            get;
            private set;
           
                
                }
        static Book()
        {
            _count = 0;
        }
        public Book(string name, string authorName, int pageCount)
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            ++_count;
            Code = $"{Char.ToUpper(Name[0])}{Char.ToUpper(Name[1])}{_count}";
        }

        public override string ToString()
        {
            return $"{Name}-{AuthorName}-{PageCount}- {Code}";
        }

    }
}
