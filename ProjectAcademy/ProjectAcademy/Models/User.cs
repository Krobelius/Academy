using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace ProjectAcademy.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int UserLVL { get; set; }
        public string PhoneNumber { get; set; }
        public string Site_Pass { get; set; }
    }
}