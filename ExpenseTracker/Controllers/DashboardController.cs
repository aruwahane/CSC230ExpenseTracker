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
    public class DashboardController : Controller
    {
        //private AddUser db = new AddUser();

        //
        // GET: /AddUser/

        public ActionResult DashboardPage()
        {
            //if (Session["LoggedUserID"] != null)
            //{
                return View();
            //}
            //else {
            //    return RedirectToAction("Index", "AddUser", "");
            //}

           
        }

       

      
     
       
    }
}