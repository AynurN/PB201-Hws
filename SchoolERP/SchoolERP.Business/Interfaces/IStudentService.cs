using SchoolERP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolERP.Business.Interfaces
{
    public interface IStudentService
    {
        void Create(Student student);
        List<Student> GetAll();
        Student? GetStudent(int ID);
        void Remove(int ID);
  
    }

}

