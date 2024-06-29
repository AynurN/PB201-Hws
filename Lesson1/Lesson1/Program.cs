using System.Threading.Channels;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int age = 16;
            //if (age <= 18)
            //{ Console.WriteLine($"{age} is under 18"); }
            //else if (age >= 65)
            //{ Console.WriteLine("Too old"); }

            //else
            //{
            //    Console.WriteLine("Not pass");
            //}

            //string a="akdhsak";
            //switch (a) {
            //    case "Monday":
            //        Console.WriteLine("Monday");
            //        break;
            //   case "Tuesday":
            //        Console.WriteLine( "Tuesday");
            //        break;
            //   case "Wednday":
            //        Console.WriteLine("Wednseday");
            //        break;
            //    default:
            //        Console.WriteLine("There is no such a day");
            //        break;

            //}

            //int a = 5;
            //    string b = (a < 10) ? "It is ok" : (a>20)? "No ok" : "Ok" ;
            //Console.WriteLine(b);

            int[] a = { 1, 2, 3, 10 };
            foreach (int num in a)
            {
                Console.WriteLine(num);
            }

        }
    }
}
