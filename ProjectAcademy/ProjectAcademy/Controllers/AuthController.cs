using ProjectAcademy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ProjectAcademy.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult AuthView()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AuthView(LoginModel model)
        {
                User user = null;
                using(AuthContext db = new AuthContext())
                {
                    user = db.Users.FirstOrDefault(u => u.PhoneNumber == model.Phone && u.Site_Pass == model.Password);
                }
                if(user != null)
                {
                    FormsAuthentication.SetAuthCookie(model.Phone, true);
                    return RedirectToAction("Index", "Main");
                }
                else
                {
                    ModelState.AddModelError("", "Пароль или номер телефона введены неправильно!");
                }
            return View(model);
        }
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel model)
        {
                User user = null;
                using (AuthContext db = new AuthContext())
                {
                    user = db.Users.FirstOrDefault(u => u.PhoneNumber == model.Phone);
                }
                if (user == null)
                {
                    using (AuthContext db = new AuthContext())
                    {
                        db.Users.Add(new User { PhoneNumber = model.Phone, Site_Pass = "12345678", FirstName = "1", LastName = "2", UserId = 2, UserLVL = 1 });
                        db.SaveChanges();

                        user = db.Users.Where(u => u.PhoneNumber == model.Phone).FirstOrDefault();
                    }
                    if (user != null)
                    {
                        FormsAuthentication.SetAuthCookie(model.Phone, true);
                        return RedirectToAction("AuthView", "Auth");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Введенный номер телефона неверен!");
                }
            return View(model);
        }
    }
}