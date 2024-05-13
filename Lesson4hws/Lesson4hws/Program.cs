namespace Lesson4hws
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            int n = Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            if (n == 0 || n == 1) Console.WriteLine($"{n} is neither prime nor composite number");
            else
            {
                for (int i = 2; i < n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine($"{n} is composite number ");
                        flag = true;
                        break;
                    }
                }
                if (flag == false) { Console.WriteLine($"{n} is prime number"); }

            }

            //Task 2
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            do
            {
                num /= 10;
                count++;
            } while (num != 0);
            Console.WriteLine(count);

        }
    }
}
