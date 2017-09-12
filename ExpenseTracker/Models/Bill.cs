using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpenseTracker.Models
{
    public class Bill
    {
        public int BillID { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Amount")]
        public decimal Amount { get; set; }

        [Required]
        [Display(Name = "Date")]
        public DateTime PDate { get; set; }

        [Display(Name = "Image")]
        public string PImage { get; set; }

        [Display(Name = "Mode of Payment")]
        public IEnumerable<SelectListItem> ModeOfPayment { get; set; }
        //public string ModeOfPayment { get; set; }

        [Display(Name = "Check Status")]
        public string CheckStatus { get; set; }

        [Display(Name = "Check Number")]
        public int CheckNumber { get; set; }

        //Savleen: dropdown for Billtype
        public virtual BillType billtype { get; set; }

        //Savleen: dropdown for Category
        public virtual Category category { get; set; }
    }
}