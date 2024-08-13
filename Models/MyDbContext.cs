using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class MyDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Result> Results { get; set; }
    }
}