using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectAcademy.Models
{
    public class UserDbInitializer:DropCreateDatabaseAlways<AuthContext>
    {
        protected override void Seed(AuthContext db)
        {
            db.Users.Add(new User { FirstName = "Ivan", LastName = "Slesarenko", PhoneNumber = "+7(999)632-58-95", UserId = 1, UserLVL = 1 , Site_Pass = "123456" });
            base.Seed(db);
        }
    }
}