using System.ComponentModel.Design;

namespace Lesson9hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidatePassword("A2ynurab"));
            string s= "Code Academy";
            Console.WriteLine(Replace(s, 'a', 'b'));
            Console.Write(Trim("     Hello World   "));
            Console.WriteLine("new");
            Console.WriteLine(Substring(s,3));
            Console.WriteLine(Substring(s,5,3));
            Console.WriteLine(Replace(s, "code", "abc"));

        }

        //Task1
        static bool ValidatePassword(string password)
        {
            bool flag = false;
            if (password.Length >= 8)
            {
                if(StartWithCapital(password) && ContainDigit(password) && ContainsCharacter(password)) { flag = true; }

            }
            return flag;
        }
        static bool StartWithCapital(string pass)
        {
            if (Char.IsUpper(pass[0])) return true;
            return false;
        }
        static bool ContainDigit(string pass)
        {
            bool flag = false;
            foreach(char c in pass)
            {
                if (Char.IsDigit(c))
                { 
                    flag = true;
                    break;

                }
            }
            return flag;
        }
        static bool ContainsCharacter(string pass)
        {
            bool flag = false;
            foreach (char c in pass)
            {
                if (!Char.IsLetter(c) && !Char.IsDigit(c))
                {
                    flag = true;
                    break;

                }
            }
            return flag;

        }
        //Task2
        static string Replace(string word, char oldchar, char newchar)
        {
            string newword=string.Empty;
            for(int i=0; i<word.Length; i++)
            {
                if (word[i] == oldchar)
                {
                    newword += newchar;
                }
                else
                {
                    newword += word[i];
                }

            }
            return newword;

        }
        static string Trim(string word)
        {
            string newword = string.Empty;
            int start = 0, end=0;
            for(int i=0; i<word.Length; i++)
            {
                if (word[i] == ' ') start++;
                else if (word[i] != ' ') break;
            }
            for(int i=word.Length-1; i>=0; i--)
            {
                if (word[i] == ' ') end++;
                else if (word[i] != ' ') break;
            }
            for(int i=start; i<=word.Length-end-1; i++)
            {
                newword += word[i];
            }
            return newword;
          
        }
        static string Substring(string word, int startindex)
        {
            string sub = string.Empty;
            for(int i=startindex; i < word.Length; i++)
            {
                sub += word[i];
            }
            return sub;
        }
        static string Substring(string word, int startindex, int steps)
        {
            string sub=string.Empty;
            int count = 0;
            int i = startindex;
            while (count < steps)
            {
                sub += word[i];
                i++;
                count++;
            }
            return sub;
        }
        static string Replace(string word, string oldst, string newst)
        {
            string newword = string.Empty;
            for(int i=0; i<word.IndexOf(oldst); i++)
            {
                newword+= word[i];
            }
            newword += newst;
            for(int i= word.IndexOf(oldst)+oldst.Length+1; i<word.Length; i++)
            {
                newword+= word[i];
            }
            return newword;
        }


    }
}
