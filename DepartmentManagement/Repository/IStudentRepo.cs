using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DepartmentManagement.Models;

namespace DepartmentManagement.Repository
{
    public interface IStudentRepo<T1> where T1 : class
    {

        IEnumerable<Student> GetAllUser();
        IEnumerable<Student> GetById();
        string CreateStudent(T1 t);
        string UpdateStudent(T1 t);
        string DeleteStudent(T1 t);

    }
}