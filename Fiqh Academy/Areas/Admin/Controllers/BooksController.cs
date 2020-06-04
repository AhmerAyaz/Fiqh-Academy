using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fiqh_Academy.Models;

namespace Fiqh_Academy.Areas.Admin.Controllers
{
    public class BooksController : Controller
    {
        private FiqhDb db = new FiqhDb();
        // GET: Admin/Books
        public ActionResult Index()
        {
            if (Session["username"] == null)
            {
                return RedirectToAction("Index", "../Home");
            }
            else
            {
                return View(db.Books.ToList());
            }
        }
        public ActionResult Details()
        {
            if (Session["username"] == null)
            {
                return RedirectToAction("Index", "../Home");
            }
            else
            {
                return View();
            }
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Details(Books book)
        {
            string FileExt = Path.GetExtension(book.Files.FileName).ToUpper();
            if (FileExt == ".PDF")
            {
                Stream str = book.Files.InputStream;
                BinaryReader Br = new BinaryReader(str);
                Byte[] FileDet = Br.ReadBytes((Int32)str.Length);
                book.FileContent = FileDet;
                double fileSize = book.Files.ContentLength;
                book.Size = Math.Round(fileSize / 1000000, 2);
                book.Topic = book.Files.FileName;
                book.Date = DateTime.Today.ToString("d");
                db.Books.Add(book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.FileStatus = "Invalid file format.";
                return View();

            }
        }

        [HttpGet]
        public FileResult DownLoadFile(int id)
        {
            List<Books> ObjFiles = db.Books.ToList();

            var FileById = (from FC in ObjFiles
                            where FC.Id.Equals(id)
                            select new { FC.Topic, FC.FileContent }).ToList().FirstOrDefault();

            return File(FileById.FileContent, "application/pdf", FileById.Topic);

        }
    }
}