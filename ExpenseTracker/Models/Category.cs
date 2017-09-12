using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpenseTracker.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        //Arundhati: State dropdown in User page
        public virtual ICollection<Bill> Bills { get; set; }
    }
}