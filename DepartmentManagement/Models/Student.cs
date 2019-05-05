using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DepartmentManagement.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Address { get; set; }
        public int DepartmentId { get; set; }
        public Department department { get; set; }
    }
}