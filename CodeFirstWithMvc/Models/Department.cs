using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstWithMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }

        public virtual List<Employee> Employees { get; set; }
    }
}