using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Fiqh_Academy.Areas.Admin.Models;

namespace Fiqh_Academy.Models
{
    public class FiqhDb: DbContext
    {
        public FiqhDb() 
        {
            Database.SetInitializer<FiqhDb>(new DropCreateDatabaseIfModelChanges<FiqhDb>());
        }
        public DbSet<Bayanaat> Bayanaats { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Update> Updates { get; set; }
        public DbSet<Login> Logins { get; set; }
    }
}