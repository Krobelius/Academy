using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ProjectAcademy.Models
{
    public class AuthContext: DbContext
    {
        public AuthContext() :
            base("DefaultConnection")
        { }
        public DbSet<User> Users { get; set; }
    }
}