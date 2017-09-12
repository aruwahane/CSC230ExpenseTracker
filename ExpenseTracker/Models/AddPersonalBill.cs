using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExpenseTracker.Models
{
    public class AddPersonalBill: DbContext
    {
        public DbSet<Bill> PersonalBills { get; set; }
    }
}