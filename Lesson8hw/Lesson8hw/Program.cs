namespace Lesson8hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfEven(10));
            PrintSumOfEven(10);

            Console.WriteLine(EraseTheSpaces("CodeAcademy"));
            PrintTheFirstLetters("Code Academy");



        }
        //Task1
        static int SumOfEven(int n)
        { int sum = 0;
            for (int i = 0; i < n; i++)
                if (i % 2 == 0) sum += i;
            return sum;
        }
        static void PrintSumOfEven(int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
                if (i % 2 == 0) sum += i;
            Console.WriteLine(sum);

        }
        //Task2
        static string EraseTheSpaces(string s)
        {
            string snew = "";
            for (int i = 0; i < s.Length; i++)
                if (s[i] != ' ') snew += s[i];
            return snew;
        }
        //Task3
        static void PrintTheFirstLetters(string s)
        {
            for(int i=0; i<s.Length; i++)
            {
                if (i==0 ||s[i - 1] == ' ') Console.WriteLine(s[i]);

            }
        }

    }
}
