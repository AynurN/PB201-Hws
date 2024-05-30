using System;

namespace Lesson12_Static__extension
{
    internal class Program
    {
        static void Main(string[] args)
        {  //task1
            Console.WriteLine("Enter FullName:");
            string? FullName = Console.ReadLine();
            Console.WriteLine("Enter Email: ");
            string? Email = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string? password = Console.ReadLine();
            User? user1 = new User(Email, password);
            user1.FullName = FullName;
            //Task2,3
            Student student1 = new Student("Adil", 75);
            Student student2 = new Student("Leyla", 40);
            Student student3 = new Student("Sema", 95);
            Student student4 = new Student("Gulay", 64);
            Student student5 = new Student("Mahir", 30);
            Student student6 = new Student("Mahir", 30);
            Console.WriteLine("1. Show Info");
            Console.WriteLine("2.Create Group");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                user1.ShowInfo();
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter GroupNo:");
                string? groupNo = Console.ReadLine();
                Console.WriteLine("Enter studentLimit:");
                int studentLimit = Convert.ToInt32(Console.ReadLine());
                Group group1 = new Group(groupNo, studentLimit);
                group1.AddStudent(student1);
                group1.AddStudent(student2);
                group1.AddStudent(student3);
                group1.AddStudent(student4);
                group1.AddStudent(student5);
                group1.AddStudent(student6);
                Console.WriteLine("1.Show all students");
                Console.WriteLine("2. Get student by id");
                Console.WriteLine("3.Add student");
                Console.WriteLine("0.Quit");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                if (choice2 == 1)
                {
                    foreach (var student in group1.GetAllStudents())
                    {
                        student.StudentInfo();
                    }
                }
                else if (choice2 == 2)
                {
                    Console.WriteLine("Enter ID");
                    int searchingID = Convert.ToInt32(Console.ReadLine());
                    foreach (var student in group1.GetAllStudents())
                    {
                        if (student.ID == searchingID) student.StudentInfo();

                    }
                }
                else if (choice2 == 3)
                {
                    Console.WriteLine("Enter new student name:");
                    string? name = Console.ReadLine();
                    Console.WriteLine("Enter new student point:");
                    int point = Convert.ToInt32(Console.ReadLine());
                    Student newstudent = new Student(name, point);
                    group1.AddStudent(newstudent);
                 

                }
                else if (choice2 == 0)
                {
                    Console.WriteLine("Program exit");
                }
            }




        }
    }
}
