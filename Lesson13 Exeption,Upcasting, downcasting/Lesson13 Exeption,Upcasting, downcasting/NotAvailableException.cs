using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_Exeption_Upcasting__downcasting
{
    public class NotAvailableException : Exception
    {
        public NotAvailableException()
        {
        }

        public NotAvailableException(string? message) : base(message)
        {
            
         
           
        }
    }
}
