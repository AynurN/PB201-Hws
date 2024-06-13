using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializable
{
    public class Product
    {
        private static int _id;
        public int ID { get; set; }
        public string Name { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
        public Product( string name, double costPrice, double salePrice)
        {
            ++_id;
            ID = _id;
            Name = name;
            CostPrice = costPrice;
            SalePrice = salePrice;
        }
    }
}
