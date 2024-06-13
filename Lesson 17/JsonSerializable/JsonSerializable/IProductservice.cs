using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializable
{
    public interface IProductservice
    {
        void Create(Product product);
        Product Get(int id);
        List<Product> GetAllProducts();
        void Delete(int id);
    }
}
