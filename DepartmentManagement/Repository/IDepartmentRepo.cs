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
        IEnumerable<Department> GetAllDepartment();
        Department GetById(int id);
        long CreateDepartment(T1 t);
        string UpdateDepartment(int id, T1 t);
        string DeleteDepartment(int id);
    }
}
