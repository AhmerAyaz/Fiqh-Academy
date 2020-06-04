using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fiqh_Academy.Models;

namespace Fiqh_Academy.Controllers
{
    public class RegistrationController : Controller
    {
        private FiqhDb FiqhDb = new FiqhDb();
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        // GET: Registration/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Registration/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Registration/Create
        [HttpPost]
        public ActionResult Create(Registration registration)
        {
            if(ModelState.IsValid)
            {
                FiqhDb.Registrations.Add(registration);
                FiqhDb.SaveChanges();
                TempData["Success"] = "Registered Successfully!";
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        // GET: Registration/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Registration/Edit/5
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

        // GET: Registration/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Registration/Delete/5
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
    }
}
