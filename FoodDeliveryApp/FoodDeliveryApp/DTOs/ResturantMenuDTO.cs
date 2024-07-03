using FoodDeliveryApp.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodDeliveryApp.DTOs
{
    public class ResturantMenuDTO
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string FDesc { get; set; }
        public decimal FPrice { get; set; }
        public int RId { get; set; }
    }
}