using AutoMapper;
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
    [UserAccess]
    public class UserController : Controller
    {
        FoodDeliveryAppEntities db = new FoodDeliveryAppEntities();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(UserDTO u)
        {
            if (ModelState.IsValid)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<UserDTO, User>();
                });
                var mapper = new Mapper(config);
                var data = mapper.Map<UserDTO, User>(u);
                data.Name = u.FirstName.Trim() + " " + u.LastName.Trim();
                db.Users.Add(data);
                TempData["Msg"] = "User Registered Successfully";
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(u);
        }
    }
}