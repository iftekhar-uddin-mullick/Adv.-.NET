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
    public class OrderController : Controller
    {
        FoodDeliveryAppEntities db = new FoodDeliveryAppEntities();
        // GET: Order
        [LoggedIn]
        public ActionResult Index()
        {
            return View();
        }

        [UserAccess]
        public ActionResult AddToCart(int id)
        {
            var food = db.Foods.Find(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Food, FoodDTO>();
            });
            var mapper = new Mapper(config);
            var fd = mapper.Map<FoodDTO>(food);
            if (Session["Cart"] == null)
            {
                var cart = new List<FoodDTO>();
                cart.Add(fd);
                Session["Cart"] = cart;
            }
            else
            {
                var cart = (List<FoodDTO>)Session["Cart"];
                cart.Add(fd);
                Session["Cart"] = cart;
            }
            TempData["Msg"] = food.FName + " added to cart successfully";
            return RedirectToAction("ResturantMenu", "Resturant", new { id = food.RId });
        }

        [UserAccess]
        public ActionResult Cart()
        {
            var cart = (List<FoodDTO>)Session["Cart"];
            if(cart == null)
            {
                TempData["Msg"] = "Cart is empty";
                return RedirectToAction("Index", "User");
            }
            return View(cart);
        }

        [UserAccess]
        public ActionResult PlaceOrder(decimal total, int rid)
        {
            var order = new Order();
            order.UId = ((User)Session["UserData"]).Id;
            order.RId = rid;
            order.DateTime = DateTime.Now;
            order.Status = "Placed";
            order.TotalAmount = total;
            db.Orders.Add(order);
            db.SaveChanges();

            var cart = (List<FoodDTO>)Session["Cart"];
            foreach (var item in cart)
            {
                var orderFood = new OrderFood();
                orderFood.FId = item.Id;
                orderFood.OId = order.Id;
                orderFood.FPrice = item.FPrice;
                orderFood.FQty = 1;
                db.OrderFoods.Add(orderFood);
                db.SaveChanges();
            }
            Session["Cart"] = null;
            TempData["Msg"] = "Order placed successfully";
            return RedirectToAction("Index", "User");
        }

        [UserAccess]
        public ActionResult RemoveFromCart(int id)
        {
            var cart = (List<FoodDTO>)Session["Cart"];
            var item = cart.FirstOrDefault(x => x.Id == id);
            cart.Remove(item);
            if (cart == null)
            {
                TempData["Msg"] = item.FName + " removed from cart successfully and cart is empty!";
                return RedirectToAction("Index", "User");
            }
            Session["Cart"] = cart;
            TempData["Msg"] = item.FName + " removed from cart successfully";
            return RedirectToAction("Cart");
        }
    }
}