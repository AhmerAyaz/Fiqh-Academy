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
    public class DashboardController : Controller
    {
        private FiqhDb db = new FiqhDb();

        // GET: Admin/Dashboard
        public ActionResult Index()
        {
            if (Session["username"] == null)
            {
                return RedirectToAction("Index", "../Home");
            }
            else
            {
                DashboardViewModel ViewModel = new DashboardViewModel();
                ViewModel.Registration = db.Registrations.Count();
                ViewModel.Update = db.Updates.Count();
                ViewModel.Bayanaat = db.Bayanaats.Count();
                ViewModel.Books = db.Books.Count();
                return View(ViewModel);
            }
        }

        // GET: Admin/Dashboard/Details/5
        public ActionResult Registration()
        {
            if (Session["username"] == null)
            {
                return RedirectToAction("Index", "../Home");
            }
            else
            {
                return View(db.Registrations.ToList());
            }
        }

        public ActionResult Updates()
        {
            if (Session["username"] == null)
            {
                return RedirectToAction("Index", "../Home");
            }
            else
            {
                return View(db.Updates.ToList());
            }
            
        }
    }
}
