using FoodDeliveryApp.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodDeliveryApp.DTOs
{
    public class ResturantDetailsDTO
    {
        public int Id { get; set; }
        public string RName { get; set; }
        public string RLoc { get; set; }
        public int UId { get; set; }
    }
}