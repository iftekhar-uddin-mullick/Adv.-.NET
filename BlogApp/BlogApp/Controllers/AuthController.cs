using BlogApp.DTOs;
using BlogApp.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    public class AuthController : Controller
    {
        DemoTask_BlogSiteEntities1 db = new DemoTask_BlogSiteEntities1();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginDTO l)
        {
            if (ModelState.IsValid)
            {
                var user = (from u in db.Users
                            where u.Username.Equals(l.Username) &&
                            u.Password.Equals(l.Password)
                            select u).SingleOrDefault();

                if (user == null)
                {
                    TempData["Msg"] = "Username / Password did not match!";
                    return RedirectToAction("Login", "Auth");
                }

                Session["userData"] = user;
                TempData["Msg"] = "Login Successfull!";
                return RedirectToAction("Home", "User");
            }
            return View(l);
        }

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(RegistrationDTO l)
        {
            if (ModelState.IsValid)
            {
                var convertedData = Convert(l);
                db.Users.Add(convertedData);
                db.SaveChanges();
                TempData["Msg"] = "Registration Successfull!";
                return RedirectToAction("Index", "Home");
            }
            return View(l);
        }

        public static RegistrationDTO Convert(User u)
        {
            return new RegistrationDTO()
            {
                Username = u.Username,
                Password = u.Password,
                Name = u.Name
            };
        }

        public static User Convert(RegistrationDTO reg)
        {
            return new User()
            {
                Username = reg.Username,
                Password = reg.Password,
                Name = reg.Name
            };
        }

        public static List<RegistrationDTO> Convert(List<User> l)
        {
            var list = new List<RegistrationDTO>();
            foreach (var item in l)
            {
                list.Add(Convert(item));
            }
            return list;
        }
    }
}