using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;

namespace ExpenseTracker.Models
{
    public class State
    {
        public int StateID { get; set; }
     
        [Display(Name = "State")]
        public string StateName { get; set; }

        //Arundhati: State dropdown in User page
        public virtual ICollection<User> Users { get; set; }

        public List<SelectListItem> StateList { get; set; }
    }
}