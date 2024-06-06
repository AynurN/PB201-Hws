using SchoolERP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SchoolERP.Data.DAL
{
    public class SchoolERPDataBase<T>
    {
        public static List<T> models= new List<T>();
    }
}
