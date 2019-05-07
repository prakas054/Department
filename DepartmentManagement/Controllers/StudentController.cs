using DepartmentManagement.Models;
using DepartmentManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DepartmentManagement.Controllers
{
    public class StudentController : ApiController
    {
        private IStudentRepo<Student> _student;

        public StudentController(IStudentRepo<Student> student)
        {
            _student = student;
        }

        // GET: api/Student
        public IHttpActionResult GetAllStudent()
        {
            IEnumerable<Student> ListOfStudent = _student.GetAllUser();
            return ResponseMessage(Request.CreateResponse(ListOfStudent));
        }

        // GET: api/Student/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
