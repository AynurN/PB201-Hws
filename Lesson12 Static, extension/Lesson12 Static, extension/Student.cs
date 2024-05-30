using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Static__extension
{
    internal class Student
    {   private  int _id;
        private static int count = 0;
        public int ID { get; set; }
        public string FullName { get; set; }
        public double Point { get; set; }
        public void StudentInfo()
        {
            Console.WriteLine($"{FullName}, {ID}, {Point}");
        }
        public Student(string FullName, int point)
        {
            this.FullName = FullName;
            this.Point = point;
            count++;
            ID = count;

        }
    }
}
