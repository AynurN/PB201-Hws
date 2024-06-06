using SchoolERP.Business.Exceptions;
using SchoolERP.Business.Interfaces;
using SchoolERP.Core.Models;
using SchoolERP.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolERP.Business.Implementations
{
    public class StudentService : IStudentService
    {
        

        public void Create(Student student)
        {
            SchoolERPDataBase<Student>.models.Add(student);
        }

        public List<Student> GetAll()
        {
            return SchoolERPDataBase<Student>.models;
        }

        public Student? GetStudent(int ID)
        {
            Student? wanted = SchoolERPDataBase<Student>.models.Find(x => x.ID == ID);
            if (wanted != null)
                return wanted;
            throw new StudentNotFoundException("Student Could not be found");
        }

        public void Remove(int ID)
        {
            Student? wanted = SchoolERPDataBase<Student>.models.Find(x => x.ID == ID);
            if (wanted != null)

                SchoolERPDataBase<Student>.models.Remove(wanted);

            else
                throw new StudentNotFoundException("Student Could not be found");
        }
    }
}
