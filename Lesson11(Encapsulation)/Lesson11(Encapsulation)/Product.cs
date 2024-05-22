using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_Encapsulation_
{
    internal class Product
    {    private  double _price;
        private int _count;
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price {
            get {  return _price; }

            set { 
            if (value > 0) { _price = value; }

            }
        }
        public int Count { 
            get {
                return _count;
            } 
            set { 
                if (value > 0) _count = value;
            } 
        }
        public Product(string name)
        {
            this.Name = name;
        }
        public Product(string name, int ID):this(name)
        {
            this.ID = ID;
        }
        public Product(string name, int ID, double Price):this(name, ID)
        {
            this.Price = Price;
        }
    }
}
