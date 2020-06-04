using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fiqh_Academy.Models;

namespace Fiqh_Academy.Controllers
{
    public class BookController : Controller
    {
        private FiqhDb FiqhDb = new FiqhDb();
        // GET: Books
        public ActionResult Index()
        {
            return View(FiqhDb.Books.ToList());
        }

        [HttpGet]
        public FileResult DownloadFile(int id)
        {
            List<Books> ObjFiles = FiqhDb.Books.ToList();

            var FileById = (from FC in ObjFiles
                            where FC.Id.Equals(id)
                            select new { FC.Topic, FC.FileContent }).ToList().FirstOrDefault();

            return File(FileById.FileContent, "application/pdf", FileById.Topic);

        }
        // GET: Books/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Books/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
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

        // GET: Books/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Books/Edit/5
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

        // GET: Books/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Books/Delete/5
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
