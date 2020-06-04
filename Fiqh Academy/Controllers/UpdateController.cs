using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fiqh_Academy.Models;

namespace Fiqh_Academy.Controllers
{
    public class UpdateController : Controller
    {
        private FiqhDb FiqhDb = new FiqhDb();
        // GET: Update
        public ActionResult Index()
        {
            return View();
        }

        // GET: Update/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Update/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Update/Create
        [HttpPost]
        public ActionResult Create(Update update)
        {
            if(ModelState.IsValid)
            {
                FiqhDb.Updates.Add(update);
                FiqhDb.SaveChanges();
                TempData["Success"] = "Registered Successfully!";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Index","Home");
            }
        }

        // GET: Update/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Update/Edit/5
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

        // GET: Update/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Update/Delete/5
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
