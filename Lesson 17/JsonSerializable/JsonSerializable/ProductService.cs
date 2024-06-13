using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonSerializable
{
    public class ProductService : IProductservice
    {
        public void Create(Product product)
        {
            string productJson = JsonSerializer.Serialize(product);
            using (StreamWriter writer = new StreamWriter("C:\\Users\\user\\Desktop\\PB201-hws\\Lesson 17\\example.txt", true))
            {
                writer.WriteLine(productJson);
            }
            
            
           
        }

        public void Delete(int id)
        {
            string[] jsonObj = File.ReadAllLines("C:\\Users\\user\\Desktop\\PB201-hws\\Lesson 17\\example.txt");
            Product? product = null;
            List<string> updatedJsonObj = new List<string>();


            foreach (var json in jsonObj)
            {
                 product=JsonSerializer.Deserialize<Product>(json);
                if(product != null)
                {
                    if (product.ID != id)
                    {
                        updatedJsonObj.Add(json);
                    }
                }
            }
            File.WriteAllLines("C:\\Users\\user\\Desktop\\PB201-hws\\Lesson 17\\example.txt", updatedJsonObj);
        }

        public Product? Get(int id)
        {
            string[] jsonObj = File.ReadAllLines("C:\\Users\\user\\Desktop\\PB201-hws\\Lesson 17\\example.txt");

            foreach (var json in jsonObj)
            {
                Product? product = JsonSerializer.Deserialize<Product>(json);
                if (product != null)
                {
                    if (product.ID == id)
                    {
                        return product;
                    }
                }
            }
            return null;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            string[] jsonObj = File.ReadAllLines("C:\\Users\\user\\Desktop\\PB201-hws\\Lesson 17\\example.txt");

            foreach (var json in jsonObj)
            {
                Product? product = JsonSerializer.Deserialize<Product>(json);
                if (product != null)
                {
                        products.Add(product);
                    
                }
            }
            return products;
        }
    }
}
