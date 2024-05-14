namespace Lesson5hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0; i<arr.Length; i++) arr[i]= Convert.ToInt32(Console.ReadLine());
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] > max) max = arr[i];
            Console.WriteLine("Max = " + max);
            //task2
            var product1 = new { Id = 123, name = "Samsungs24", price = 3300, stockCount = 300 };
            var product2 = new { Id = 452, name = "Honor90", price = 1000, stockCount = 100 };
            var product3 = new { Id = 120, name = "IPhone15", price = 2300, stockCount = 300 };
            var product4 = new { Id = 192, name = "Xiomi14", price = 2300, stockCount = 500 };
            var product5 = new { Id = 501, name = "Motorola40", price = 1900, stockCount = 50 };

            var products = new[] { product1, product2, product3, product4,product5 };
            double sum = 0;
            int count=0;
           for(int i=0; i<products.Length; i++)
            {
                if (products[i].Id %2 == 1)
                {
                    count++;
                    sum += products[i].price;
                }

            }
            Console.WriteLine(sum/count);

        }
    }
}
