using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace ProjectAcademy.Models
{
    public class RegisterModel
    {
        [Required]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Пароль неверен!")]
        public string ConfirmPassword { get; set; }
        [Required]
        public int UserLVL { get; set; }
    }
}