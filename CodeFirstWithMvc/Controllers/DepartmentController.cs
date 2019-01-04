using CodeFirstWithMvc.Context;
using CodeFirstWithMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstWithMvc.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentContext db = new DepartmentContext();
        // GET: Department
        public ActionResult Index()
        {
            try
            {
                List<Department> departments = db.Departments.ToList();
                return View(departments);
            }
            catch(Exception ex)
            {
                return View();
            }

        }

        // GET: Department/Details/5
        public ActionResult Details(int id)
        {  
            return View(db.Departments.Find(id));
        }

        // GET: Department/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Department/Create
        [HttpPost]
        public ActionResult Create(Department depData)
        {
            try
            {
                // TODO: Add insert logic here
                db.Departments.Add(depData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {

                return View();
            }
        }

        // GET: Department/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Department/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Department collection)
        {
            try
            {
                // TODO: Add update logic here
                Department department = db.Departments.Find(id);
                db.Departments.Remove(department);
                db.Departments.Add(collection);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Department/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Department/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Department depData)
        {
            try
            {
                // TODO: Add delete logic here
                Department department = db.Departments.Find(id);
                db.Departments.Remove(department);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }
    }
}
