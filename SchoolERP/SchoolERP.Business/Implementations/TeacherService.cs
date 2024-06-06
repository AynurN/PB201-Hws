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
    public class TeacherService : ITeacherService
    {    

        public void Create(Teacher teacher)
        {
           SchoolERPDataBase<Teacher>.models.Add(teacher);
        }

        public List<Teacher> GetAll()
        {
            return SchoolERPDataBase<Teacher>.models;
        }

        public Teacher GetTeacher(int ID)
        {
            Teacher? wanted = SchoolERPDataBase<Teacher>.models.Find(x => x.ID == ID);
            if (wanted != null)
                return wanted;
            throw new TeacherNotFoundException("Teacher Could not be found");
        }

        public void Remove(int ID)
        {   
            Teacher? wanted = SchoolERPDataBase<Teacher>.models.Find(x => x.ID == ID);
            if(wanted != null)
            {
                SchoolERPDataBase<Teacher>.models.Remove(wanted);
                foreach (var student in SchoolERPDataBase<Student>.models)
                { if(student.TeacherID==ID)
                    student.teacher = null;
                }
            }    
            
            else
                throw new TeacherNotFoundException("Teacher Could not be found");
        }


        

    }
}
