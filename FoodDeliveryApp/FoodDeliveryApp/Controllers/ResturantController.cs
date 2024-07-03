using AutoMapper;
using FoodDeliveryApp.Auth;
using FoodDeliveryApp.EF;
using FoodDeliveryApp.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodDeliveryApp.Controllers
{
    public class ResturantController : Controller
    {
        FoodDeliveryAppEntities db = new FoodDeliveryAppEntities();

        // GET: Resturant
        [ResturantAccess]
        public ActionResult Index()
        {
            return View();
        }

        [UserAccess]
        public ActionResult ResturantsList()
        {
            var resturants = db.Resturants.ToList();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Resturant, ResturantListDTO>();
            });
            var mapper = new Mapper(config);
            var resturantsList = mapper.Map<List<ResturantListDTO>>(resturants);
            return View(resturantsList);
        }

        [UserAccess]
        public ActionResult ResturantMenu(int id)
        {
            var rm = (from f in db.Foods
                      where f.RId == id
                      select f).ToList();
            var rd = db.Resturants.Find(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Food, ResturantMenuDTO>();
            });
            var mapper = new Mapper(config);
            var resturantMenu = mapper.Map<List<ResturantMenuDTO>>(rm);
            /*var resturantDetails = mapper.Map<ResturantDetailsDTO>(rd);
            ViewBag.ResturantName = resturantDetails.RName;
            ViewBag.ResturantLoc = resturantDetails.RLoc;*/
            ViewBag.ResturantName = rd.RName;
            ViewBag.ResturantLoc = rd.RLoc;
            return View(resturantMenu);
        }
    }
}