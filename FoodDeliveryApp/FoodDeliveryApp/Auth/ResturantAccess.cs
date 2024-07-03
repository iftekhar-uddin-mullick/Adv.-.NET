using FoodDeliveryApp.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodDeliveryApp.Auth
{
    public class ResturantAccess : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var user = (User)httpContext.Session["UserData"];
            if (user != null && user.Type.Equals("Resturant"))
            {
                return true;
            }
            return false;
        }
    }
}