using Dapper;
using Dapper.Contrib.Extensions;
using DepartmentManagement.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DepartmentManagement.Repository
{
    public class DepartmentRepo : IDepartmentRepo<Department>
    {
        string ConnectionManager = ConfigurationManager.ConnectionStrings["SqlServices"].ConnectionString;

        public IEnumerable<Department> GetAllDepartment()
        {
            try
            {
                using (var connection = new SqlConnection(ConnectionManager))
                {
                    connection.Open();
                    return connection.GetAll<Department>().ToList();
                }
            }
            catch (Exception e)
            {

                throw e;
            }
            
            
        }

        public Department GetById(int id)
        {
            try
            {
                using (var connection = new SqlConnection(ConnectionManager))
                {
                    connection.Open();
                    return connection.Get<Department>(id);
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public long CreateDepartment(Department department)
        {
            try
            {
                using (var connection = new SqlConnection(ConnectionManager))
                {
                    connection.Open();
                    var insert =  connection.Insert<Department>(department);

                    if (insert != 0)
                    {
                        //commit Transition
                        return insert;
                    }

                    else
                    {
                        //Transition Not Commited
                        return 0;
                    }
                }
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string UpdateDepartment(int id, Department department)
        {
            try
            {
                using (var connection = new SqlConnection(ConnectionManager))
                {
                    connection.Open();
                    var update = connection.Update<Department>(department);

                    if (update == true)
                    {
                        //commit Transition
                        return "Sucessfully Update";
                    }

                    else
                    {
                        //Transition Not Commited or Transition Roll Back
                        return "Not Update, Transition Fail";
                    }
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    

        public string DeleteDepartment(int id)
        {
            try
            {
                using (var connection = new SqlConnection(ConnectionManager))
                {
                    connection.Open();
                    var delete = connection.Delete(new Department {DepartmentId = id });

                    if (delete == true)
                    {
                        //id = id-1;
                        //string S = "DBCC CHECKIDENT (Department, RESEED, '" + id + "')";
                        //connection.Execute(S);

                        //commit Transition
                        return "Sucessfully Deleted";
                    }

                    else
                    {
                        //Transition Not Commited or Transition Roll Back
                        return "Not Deleted Transition Fail";
                    }
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}