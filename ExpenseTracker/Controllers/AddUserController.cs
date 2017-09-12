using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExpenseTracker.Models;
using System.Web.Security;

namespace ExpenseTracker.Controllers
{ 
    public class AddUserController : Controller
    {
        private AddUser db = new AddUser();

        //
        // GET: /AddUser/

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
            //return View(db.Users.ToList());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string email, string password)
        {
            if (ModelState.IsValid)
            {
                //    User item = new User();

                //    if (email == item.Email && password == "")
                //    {
                //        FormsAuthentication.SetAuthCookie(email, false);
                //        return RedirectToAction("DashboardPage", "DashboardController", "");
                //    }
                //        else
                //        {
                //            ModelState.AddModelError("", "Invalid Username and Password");
                //        }
                var v = db.Users.Where(a => a.Email.Equals(email) && a.Password.Equals(password)).FirstOrDefault();
                if (v != null)
                {
                    Session["LoggedUserID"] = v.UserID.ToString();
                    Session["LoggedUserName"] = v.UserFirstName.ToString();
                    return RedirectToAction("DashboardPage", "Dashboard", "");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Username and Password");
                    
                }
            }
               
            return View();
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }


        //
        // GET: /AddUser/Details/5

        public ViewResult Details(int id)
        {
            User user = db.Users.Find(id);
            return View(user);
        }

        //
        // GET: /AddUser/Create

        public ActionResult Create()
        {
            var StateLst = new List<string>();

            var StateQry = from d in db.States
                           orderby d.StateName
                           select d.StateName;
            StateLst.AddRange(StateQry.Distinct());
            ViewBag.movieGenre = new SelectList(StateLst);

            return View(db.States.ToList());
           // return View();
        } 

        //
        // POST: /AddUser/Create

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(user);
        }
        
        //
        // GET: /AddUser/Edit/5
 
        public ActionResult Edit(int id)
        {
            User user = db.Users.Find(id);
            return View(user);
        }

        //
        // POST: /AddUser/Edit/5

        [HttpPost]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        //
        // GET: /AddUser/Delete/5
 
        public ActionResult Delete(int id)
        {
            User user = db.Users.Find(id);
            return View(user);
        }

        //
        // POST: /AddUser/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}