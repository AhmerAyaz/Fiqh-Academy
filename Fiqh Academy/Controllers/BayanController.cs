using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fiqh_Academy.Models;

namespace Fiqh_Academy.Controllers
{
    public class BayanController : Controller
    {
        private FiqhDb FiqhDb = new FiqhDb();
        // GET: Bayanaat
        public ActionResult Index()
        {
            return View(FiqhDb.Bayanaats.ToList());
        }

        // GET: Bayanaat/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Bayanaat/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bayanaat/Create
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

        // GET: Bayanaat/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Bayanaat/Edit/5
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

        // GET: Bayanaat/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Bayanaat/Delete/5
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
        public List<Bayanaat> GetBayanaat()
        {
            var Bayanaat = new List<Bayanaat>()
            {
                new Bayanaat(){Category="Ramadan", Date="Tuesday", Id=1, Size=2, Speaker="Maulana Tariq Jameel", Topic="Tauba", FilePath="MyComputer"},
                new Bayanaat(){Category="Ramadan", Date="Wednesday", Id=2, Size=3, Speaker="Maulana Tariq Jameel", Topic="Naik Amaal", FilePath="MyComputer"},
                new Bayanaat(){Category="Jannat", Date="Tuesday", Id=3, Size=4, Speaker="Maulana Saleemullah", Topic="Inaamaat", FilePath="MyComputer"},
                new Bayanaat(){Category="Akhirat", Date="Tuesday", Id=4, Size=5, Speaker="Mufti Owais Pasha Qarni", Topic="Pul e sirat", FilePath="MyComputer"},
                new Bayanaat(){Category="Ramadan", Date="Monday", Id=5, Size=6, Speaker="Mufti Tariq Masood", Topic="Tauba", FilePath="MyComputer"}
            };
            return Bayanaat;          
        }
    }
}
