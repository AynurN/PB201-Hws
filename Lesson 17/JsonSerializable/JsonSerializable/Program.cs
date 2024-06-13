namespace JsonSerializable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = "C:\\Users\\user\\Desktop\\PB201-hws\\Lesson 17\\";
            //if (!File.Exists(path+"example.txt"))
            //    File.Create(path+"example.txt");
            Product p1 = new Product("product1", 450, 600);
            Product p2 = new Product("product2", 500, 800);
            Product p3 = new Product("product3", 700, 600);
            Product p4 = new Product("product4", 200, 300);
            IProductservice productservice = new ProductService();
            //productservice.Create(p1);
            //productservice.Create(p2);
            //productservice.Create(p3);
            //productservice.Create(p4);
            //productservice.Delete(1);
            Console.WriteLine(productservice.Get(2).Name); 
            productservice.GetAllProducts().ForEach(p => Console.WriteLine(p.Name));
        }
    }
}
