using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolERP.Core.Models
{
    public class Student : BaseModels
    {
        private static int _id = 0;
        public Student()
        {
            ++_id;
            ID = _id;
        }
       
        public string FullName { get; set; }
        public double Grade { get; set; }
        public Teacher teacher { get; set; }
           public int TeacherID { get
            {
               return  teacher.ID;
            } }
        public override string ToString()
        {
            if(teacher is not null)
            return $"{FullName}- {Grade}- {teacher.FullName}";
            return $"{FullName}- {Grade}-Teacher hasn't been assigned";
        }
    }
}
