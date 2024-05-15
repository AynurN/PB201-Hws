namespace Lesson6hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //for(int i=num1; i<=num2 ; i++) {
            //    if (i % 2 == 1) count++;
            //}
            //Console.WriteLine(count);

            //Task2
            string word= Console.ReadLine();
            string nword = word.ToLower();
            char[] letters = new char[26];
            int[] H = new int[26];
            for (int i = 0; i < nword.Length; i++)
                if (char.IsLetter(nword[i]))
                     H[nword[i] - 'a']++;
            for (char  i = 'a'; i < 'z'; i++)
            {
                if (H[i-'a'] > 0) Console.WriteLine($"{i} :" + H[i-'a']);

            }
        }
    }
}
