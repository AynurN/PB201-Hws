using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolERP.Core.Models
{
    public class Teacher : BaseModels
    {   private static int _id=0;
        public Teacher()
        {
            ++_id;
            ID = _id;
        }
        public string FullName { get; set; }
        public double Salary { get; set; }
        public List<Student>? students { get; set; }
        public override string ToString()
        {
            return $"{FullName}- {Salary}";
        }
    }
}
