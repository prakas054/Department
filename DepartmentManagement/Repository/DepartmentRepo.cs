using DepartmentManagement.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace DepartmentManagement.Repository
{
    public class DepartmentRepo : IDepartmentRepo<Department>
    {
        string ConnectionManager = ConfigurationManager.ConnectionStrings["SqlServices"].ConnectionString;

        public IEnumerable<Department> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Department> GetById()
        {
            throw new NotImplementedException();
        }

        public string CreateStudent(Models.Department t)
        {
            throw new NotImplementedException();
        }

        public string UpdateStudent(Models.Department t)
        {
            throw new NotImplementedException();
        }

        public string DeleteStudent(Models.Department t)
        {
            throw new NotImplementedException();
        }
    }
}