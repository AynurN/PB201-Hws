namespace Lesson_3hws
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            for (int i = 1; i <= 100; i++)
                if (i % 3 == 0 && i % 5 == 0) Console.WriteLine(i);

            //Task2
            int x;
            x = 80;
            if (x < 65)
                Console.WriteLine("Kesildin");
            else if (x >= 65 && x < 85)
                Console.WriteLine("Adi Diplom");
            else if (x >= 85 && x < 95)
                Console.WriteLine("Sheref Diplomu");
            else
                Console.WriteLine("Yuksek sheref Diplomu");
        }
    }
}

    


