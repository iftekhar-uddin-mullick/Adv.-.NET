using FoodDeliveryApp.Auth;
using FoodDeliveryApp.DTOs;
using FoodDeliveryApp.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodDeliveryApp.Controllers
{
    public class LoginController : Controller
    {
        FoodDeliveryAppEntities db = new FoodDeliveryAppEntities();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginDTO login)
        {
            if (ModelState.IsValid)
            {
                var user = (from u in db.Users
                            where u.Email == login.Email && u.Password == login.Password
                            select u).FirstOrDefault();

                if (user == null)
                {
                    TempData["Msg"] = "Invalid username or password";
                    return View(login);
                }
                else
                {
                    Session["UserData"] = user;
                    TempData["Msg"] = "Hello, " + user.Name;
                    if (user.Type == "User")
                    {
                        return RedirectToAction("Index", "User");
                    }
                    else if (user.Type == "Resturant")
                    {
                        return RedirectToAction("Index", "Resturant");
                    }
                    else
                    {
                        return RedirectToAction("Index", "Admin");
                    }
                }
            }
            return View(login);
        }

        [LoggedIn]
        public ActionResult Logout()
        {
            Session["UserData"] = null;
            TempData["Msg"] = "Logged out successfully!";
            return RedirectToAction("Index", "Home");
        }
    }
}