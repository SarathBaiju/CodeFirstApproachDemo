namespace CodeFirstWithMvc.Migrations
{
    using CodeFirstWithMvc.Context;
    using CodeFirstWithMvc.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstWithMvc.Context.DepartmentContext>
    {
        DepartmentContext context = new DepartmentContext();
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "CodeFirstWithMvc.Context.DepartmentContext";
        }

        protected override void Seed(CodeFirstWithMvc.Context.DepartmentContext context)
        {
            //  This method will be called after migrating to the latest version.
            List<Employee> employees = new List<Employee>();
            Employee emp = new Employee()
            {
                DepartmentId = 1,
                EmployeeName = "Sarath",
                Designation = "ASE"
            };
            Department department = new Department()
            {
                DepartmentName = "EEE"
            };
            employees.Add(emp);
            context.Departments.Add(department);
            context.Employees.Add(emp);
            context.SaveChanges();
            
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
