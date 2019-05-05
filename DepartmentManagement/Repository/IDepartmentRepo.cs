using DepartmentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentManagement.Repository
{
    public interface IDepartmentRepo<T1> where T1 : class
    {
        IEnumerable<Department> GetAllUser();
        IEnumerable<Department> GetById();
        string CreateStudent(T1 t);
        string UpdateStudent(T1 t);
        string DeleteStudent(T1 t);
    }
}
