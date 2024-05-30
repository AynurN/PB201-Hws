using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Static__extension
{
    internal interface Account
    {
        public bool PasswordChecker(string password);
        public void ShowInfo();
    }
}
