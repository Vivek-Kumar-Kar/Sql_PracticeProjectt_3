using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Practice_Project3;

namespace Practice_Project3.Controllers
{
    public class StudentsPr4Controller : Controller
    {
        private SchoolPP_3Entities db = new SchoolPP_3Entities();

        // GET: StudentsPr4
        public ActionResult Index()
        {
            return View(db.StudentsPr4.ToList());
        }

        // GET: StudentsPr4/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentsPr4 studentsPr4 = db.StudentsPr4.Find(id);
            if (studentsPr4 == null)
            {
                return HttpNotFound();
            }
            return View(studentsPr4);
        }

        // GET: StudentsPr4/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentsPr4/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,StudentsName,Class,TotalMarks")] StudentsPr4 studentsPr4)
        {
            if (ModelState.IsValid)
            {
                db.StudentsPr4.Add(studentsPr4);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studentsPr4);
        }

        // GET: StudentsPr4/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentsPr4 studentsPr4 = db.StudentsPr4.Find(id);
            if (studentsPr4 == null)
            {
                return HttpNotFound();
            }
            return View(studentsPr4);
        }

        // POST: StudentsPr4/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,StudentsName,Class,TotalMarks")] StudentsPr4 studentsPr4)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentsPr4).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studentsPr4);
        }

        // GET: StudentsPr4/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentsPr4 studentsPr4 = db.StudentsPr4.Find(id);
            if (studentsPr4 == null)
            {
                return HttpNotFound();
            }
            return View(studentsPr4);
        }

        // POST: StudentsPr4/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentsPr4 studentsPr4 = db.StudentsPr4.Find(id);
            db.StudentsPr4.Remove(studentsPr4);
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
