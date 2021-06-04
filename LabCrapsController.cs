using AssignLab.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace AssignLab.Controllers
{
    public class LabCrapsController : Controller
    {
        private LabContext db = new LabContext();

        // GET: LabCraps
        public ActionResult Index()
        {
            return View(db.lab.ToList());
        }

        // GET: LabCraps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LabCrap labCrap = db.lab.Find(id);
            if (labCrap == null)
            {
                return HttpNotFound();
            }
            return View(labCrap);
        }

        // GET: LabCraps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LabCraps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] LabCrap labCrap)
        {
            if (ModelState.IsValid)
            {
                db.lab.Add(labCrap);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(labCrap);
        }

        // GET: LabCraps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LabCrap labCrap = db.lab.Find(id);
            if (labCrap == null)
            {
                return HttpNotFound();
            }
            return View(labCrap);
        }

        // POST: LabCraps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] LabCrap labCrap)
        {
            if (ModelState.IsValid)
            {
                db.Entry(labCrap).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(labCrap);
        }

        // GET: LabCraps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LabCrap labCrap = db.lab.Find(id);
            if (labCrap == null)
            {
                return HttpNotFound();
            }
            return View(labCrap);
        }

        // POST: LabCraps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LabCrap labCrap = db.lab.Find(id);
            db.lab.Remove(labCrap);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult LabTestSchedual()
        {
            List<LabCrap> plzWork = db.lab.ToList();
            return View(db.lab.ToList());
        }
        [HttpPost]
        public ActionResult LabTestSchedual(List<LabCrap> lt)
        {
            string patient = Request.Form["patient"];
            string datestamp = Request.Form["dstamp"];
            foreach (LabCrap test in lt)
            {
                LabTestsDue ltd = new LabTestsDue();
                if (test.Check)
                {
                    ltd.labTestId = test.ID;
                    ltd.patientName = patient;
                    ltd.dateTimeStamp = DateTime.Parse(datestamp);
                    db.Tests.Add(ltd);
                    db.SaveChanges();
                }
            }
            return View(db.lab.ToList());
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
