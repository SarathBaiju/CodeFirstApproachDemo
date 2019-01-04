using CodeFirstWithMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstWithMvc.Context
{
    public class DepartmentContext:DbContext
    {
       public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Department>().HasKey(c => c.Id);
        //}
    }
}