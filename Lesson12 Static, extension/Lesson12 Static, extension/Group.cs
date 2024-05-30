using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Static__extension
{
    internal class Group
    {
        private int _studentLimit;
        private string _groupNo;
        private Student[] Students=new Student[0] ;
        public string GroupNo {
            get { return _groupNo;  }

            set
            { if (CheckGroupNumber(value)) _groupNo = value; }
                }
        public int StudentLimit {
            get { 
              return _studentLimit;
            }
            set { 
            if(value>=5 && value<=18) _studentLimit = value;
            }
        }
        public bool CheckGroupNumber(string  groupNo)
        {  if (groupNo.Length == 5)
                if (char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]) && char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[4]))
                    return true;
            return false;

        }
        public void AddStudent(Student student)
        {

            if (Students.Length + 1 <= StudentLimit)
            {
                Array.Resize(ref Students, Students.Length + 1);

                Students[Students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("The student can not be added");
            }
        }
        public Student? GetStudent(int? id)
        {
            foreach (var student in Students)
            { if(student.ID==id)
                    return student;
                
            }
            return null;
        }
        public Student[] GetAllStudents()
        {
            return Students;
        }
        public Group(string groupNo, int studentLimit)
        {
            this.GroupNo = groupNo;
            this.StudentLimit = studentLimit;
        }

    }
}
