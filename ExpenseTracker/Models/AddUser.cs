using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExpenseTracker.Models
{
    public class AddUser : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<State> States { get; set; }
    }
}