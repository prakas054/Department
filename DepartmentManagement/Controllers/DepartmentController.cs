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
    public class DepartmentController : ApiController
    {
        private IDepartmentRepo<Department> _department;

        public DepartmentController(IDepartmentRepo<Department> department)
        {
            _department = department;
        }
        // GET: api/Department
        public IHttpActionResult GetAllDepartment()
        {
            IEnumerable<Department> ListOfDepartment = _department.GetAllDepartment();
            return ResponseMessage(Request.CreateResponse(ListOfDepartment));
        }

        // GET: api/Department/5
        public IHttpActionResult GetDepartementById(int id)
        {
            return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, _department.GetById(id)));
        }

        [HttpPost]
        // POST: api/Department
        public IHttpActionResult CreateDepartment(Department department)
        {
            return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, _department.CreateDepartment(department)));
        }

        [HttpPut]
        // PUT: api/Department/5
        public IHttpActionResult UpdateDepartment(int id, Department department)
        {
            return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, _department.UpdateDepartment(id, department)));
        }

        [HttpDelete]
        // DELETE: api/Department/5
        public IHttpActionResult DeleteDepartment(int id)
        {
            return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, _department.DeleteDepartment(id)));
        }
    }
}
