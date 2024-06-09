using SchoolERP.Business.Exceptions;
using SchoolERP.Business.Implementations;
using SchoolERP.Business.Interfaces;
using SchoolERP.Core.Models;
using System.Linq.Expressions;

namespace SchoolERP_CA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITeacherService teacherService = new TeacherService();
            IStudentService studentService = new StudentService();
           
            
            Teacher t1 = new Teacher() { FullName = "Eli Hesenov", Salary = 700 };
            Teacher t2 = new Teacher() { FullName = "Amil Babayev", Salary = 300 };
            Student s1 = new Student() { FullName = "Adil Ismayilov ", Grade = 85 };
            Student s2 = new Student() { FullName = "Elton Eliyev ", Grade = 70 };
            Student s3 = new Student() { FullName = "Anar Feteliyev", Grade = 50 };
            Student s4 = new Student() { FullName = "Fidan Efendiyeva ", Grade = 80 };
            Student s5 = new Student() { FullName = "Gulay Movlamova ", Grade = 90 };
            teacherService.Create(t1);
            teacherService.Create(t2);
            studentService.Create(s1);
            studentService.Create(s2);
            studentService.Create(s3);
            studentService.Create(s4);
            studentService.Create(s5);
            //try
            //{
            //    Console.WriteLine(teacherService.GetTeacher(1));
            //}
            //catch (TeacherNotFoundException ex)
            //{
            //    Console.WriteLine(ex.Message);

            //}
            s1.teacher = t1;
            s2.teacher = t1;
            s3.teacher = t2;
            s4.teacher = t2;
            s5.teacher = t2;
            foreach (var item in studentService.GetAll())
            {
                Console.WriteLine(item);
            }
            teacherService.Remove(2);
            foreach (var item in studentService.GetAll())
            {
                Console.WriteLine(item);
            }
        }
    }
}
