using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fiqh_Academy.Areas.Admin.ViewModels;
using Fiqh_Academy.Models;
using System.IO;

namespace Fiqh_Academy.Areas.Admin.Controllers
{
    public class BayanaatController : Controller
    {
        private FiqhDb db = new FiqhDb();
        // GET: Admin/Bayanaat
        public ActionResult Bayanaat()
        {
            if (Session["username"] == null)
            {
                return RedirectToAction("Index", "../Home");
            }
            else
            {
                return View(db.Bayanaats.ToList());
            }

        }

        public ActionResult Details()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Details(Bayanaat bayan)
        {
            if(bayan.File!=null)
            {
                string fileName = Path.GetFileName(bayan.File.FileName);
                double fileSize = bayan.File.ContentLength;
                bayan.Size = Math.Round(fileSize / 1000000, 2);
                bayan.File.SaveAs(Server.MapPath("~/AudioFileUpload/" + fileName));
                bayan.FilePath = "~/AudioFileUpload/" + fileName;
                bayan.Date = DateTime.Today.ToString("d");
                db.Bayanaats.Add(bayan);
                db.SaveChanges();
                return RedirectToAction("Bayanaat");
            }

            ViewBag.FileStatus = "Invalid file format.";
            return View();
        }
    }
}