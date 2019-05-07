using Dapper;
using DepartmentManagement.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DepartmentManagement.Repository
{
    public class StudentRepo : IStudentRepo<Student>
    {
        string ConnectionManager = ConfigurationManager.ConnectionStrings["SqlServices"].ConnectionString;

        public IEnumerable<Student> GetAllUser()
        {
            string listOfStudent = "select * from [dbo].[Student];";
            try
            {
                using (var connection = new SqlConnection(ConnectionManager))
                {
                    return connection.Query<Student>(listOfStudent).ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<Student> GetById()
        {
            throw new NotImplementedException();
        }

        public string CreateStudent(Student t)
        {
            throw new NotImplementedException();
        }

        public string UpdateStudent(Student t)
        {
            throw new NotImplementedException();
        }

        public string DeleteStudent(Student t)
        {
            throw new NotImplementedException();
        }
    }
}