using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExpenseTracker.Models
{
    public class BillType
    {
        public int BillTypeID { get; set; }

        [Display(Name="Bill Type")]
        public string BillTypeName { get; set; }

        //Arundhati: State dropdown in User page
        public virtual ICollection<Bill> Bills { get; set; }
    }
}