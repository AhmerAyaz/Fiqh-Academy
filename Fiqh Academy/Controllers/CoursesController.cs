using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fiqh_Academy.Models;

namespace Fiqh_Academy.Controllers
{
    public class CoursesController : Controller
    {
        private FiqhDb FiqhDb = new FiqhDb();
        // GET: Courses
        public ActionResult Index()
        {
            return View(FiqhDb.Courses.ToList());
        }
        public ActionResult Shahadah()
        {
            return View();
        }
        public ActionResult Taleem()
        {
            return View();
        }
        public ActionResult Lisan()
        {
            return View();
        }
        public ActionResult Arabic()
        {
            return View();
        }
        // GET: Courses/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Courses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Courses/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Courses/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Courses/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Courses/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Courses/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public List<Courses> GetCourses()
        {
            var courses = new List<Courses>()
            {
                new Courses{Id = 1, Date = "January", Duration = "2 Months", Timings = "2pm - 4pm", Title = "Lisan-ul-Quran"},
                new Courses{Id = 2, Date = "January", Duration = "6 Months", Timings = "2pm - 6pm", Title = "Shahadahtul-Dirasia"},
                new Courses{Id = 3, Date = "January", Duration = "12 Months", Timings = "2pm - 8pm", Title = "Arabic Grammar"}
            };
            return courses;
        }
    }
}
