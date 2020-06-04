using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Fiqh_Academy.Areas.Admin.Models;
using Fiqh_Academy.Models;

namespace Fiqh_Academy.Areas.Admin.Controllers
{
    public class LoginsController : Controller
    {
        private FiqhDb db = new FiqhDb();

        // GET: Admin/Logins
        public ActionResult Index()
        {
            
            return View();
            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "Id,FName,LName,Email,Password,CPassword")] Login login)
        {
            var admin = db.Logins.Where(b => b.FName == login.FName && b.Password == login.Password).FirstOrDefault();
            if (admin != null)
            {
                Session["username"] = login.FName.ToString();
                Session["userid"] = login.Id.ToString();
                //return RedirectToAction("Index","../Home");
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                ViewBag.msg = "Invalid username or password";
                return View();
            }
        }

        // GET: Admin/Logins/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Login login = db.Logins.Find(id);
            if (login == null)
            {
                return HttpNotFound();
            }
            return View(login);
        }

        // GET: Admin/Logins/Create
        
        public ActionResult Create()
        {
            if(Session["username"] == null)
            {
                return RedirectToAction("Index", "../Home");
            }
            else
            {
                return View();
            }
        }

        // POST: Admin/Logins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FName,LName,Email,Password,CPassword")] Login login)
        {
            if (ModelState.IsValid)
            {
                db.Logins.Add(login);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(login);
        }

        // GET: Admin/Logins/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Login login = db.Logins.Find(id);
            if (login == null)
            {
                return HttpNotFound();
            }
            return View(login);
        }

        // POST: Admin/Logins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FName,LName,Email,Password,CPassword")] Login login)
        {
            if (ModelState.IsValid)
            {
                db.Entry(login).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(login);
        }

        // GET: Admin/Logins/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Login login = db.Logins.Find(id);
            if (login == null)
            {
                return HttpNotFound();
            }
            return View(login);
        }

        // POST: Admin/Logins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Login login = db.Logins.Find(id);
            db.Logins.Remove(login);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
