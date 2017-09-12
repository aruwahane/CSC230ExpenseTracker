using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExpenseTracker.Models
{
    public class Friends
    {
        public int SuperUserID { get; set; }

       
       
        public string SuperEmailId { get; set; }

        public string FriendsEmailId { get; set; }

        public string FriendsUserId { get; set; }
    }
}