namespace Lesson10hw_Class__Inheritance__Constructor_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            //int[] arr2 = Resize(arr, 10);
            //foreach (int i in arr2)
            //{
            //    Console.WriteLine(i);
            //}
            Car car=new Car();
            car.Brand = "BMW";
            car.Model = "M5";
            car.CurrentFuel = 350;
            car.FuelFor1Km = 3;
            car.Millage = 2000;
            car.Drive(50);
            car.ShowAllProperities();

        }
        //Task1
        static int[] Resize(int[] oldarr, int size)
        {
            int[] newarr = new int[size];
            if (size <= oldarr.Length)
            {
                for (int i = 0; i < size; i++)
                    newarr[i] = oldarr[i];
            }
            else
            {
                for (int i = 0; i < oldarr.Length; i++)
                    newarr[i] = oldarr[i];

            }
            return newarr;

        }
    }
}
