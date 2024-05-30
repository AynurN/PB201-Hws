using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Static__extension
{
    internal class User : Account
    {
        private string _email;
        private string _password;
        private static int count = 0;
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password {
            get { return _password;  }


                set {
                if (PasswordChecker(value)) _password = value;
            
            } }


        public bool PasswordChecker(string password)
        {
            if (password.Length >= 8)
                if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit)) 
                    return true;
            return false;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"{FullName}, {ID}, {Email}, {Password} ");

        }
        public User(string Email, string Password)
        {
            this.Email = Email;
            this.Password = Password;
            count++;
            ID = count;
        }
    }
}

