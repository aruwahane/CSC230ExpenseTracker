using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExpenseTracker.Models;

namespace ExpenseTracker.Controllers
{
    public class BillController : Controller
    {
        private AddPersonalBill db = new AddPersonalBill();

        // GET: /Bill/Create
        public ActionResult PersonalBillCreate()
        {
            var model = new Bill();
            model.PDate = System.DateTime.Now;
            model.ModeOfPayment = new[]
  {
     new SelectListItem { Value = "Cash", Text = "Cash" },
     new SelectListItem { Value = "Check", Text = "Check" },         
  };
            return View(model);
        } 

        // POST: /Bill/Create
        [HttpPost]
        public ActionResult PersonalBillCreate(Bill pbill)
        {
            //Arundhati: Add later
            if (ModelState.IsValid)
            {
                db.PersonalBills.Add(pbill);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pbill);
        }


        // GET: /AddUser/Edit/5
 
        //public ActionResult Edit(int id)
        //{
        //    User user = db.Users.Find(id);
        //    return View(user);
        //}

        // POST: /AddUser/Edit/5
        //[HttpPost]
        //public ActionResult Edit(User user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(user).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(user);
        //}


        //// GET: /AddUser/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    User user = db.Users.Find(id);
        //    return View(user);
        //}

        //// POST: /AddUser/Delete/5
        //[HttpPost, ActionName("Delete")]
        //public ActionResult DeleteConfirmed(int id)
        //{            
        //    User user = db.Users.Find(id);
        //    db.Users.Remove(user);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    db.Dispose();
        //    base.Dispose(disposing);
        //}
    }
}