using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstWithMvc.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public string Designation { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}