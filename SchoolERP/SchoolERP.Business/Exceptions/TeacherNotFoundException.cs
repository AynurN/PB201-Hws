using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolERP.Business.Exceptions
{
    public class TeacherNotFoundException : Exception
    {
        public TeacherNotFoundException()
        {
        }

        public TeacherNotFoundException(string? message) : base(message)
        {
        }
    }
}
