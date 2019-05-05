using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DepartmentManagement.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public int DepartmentName { get; set; }
        public long NumberOfStudent { get; set; }
    }
}