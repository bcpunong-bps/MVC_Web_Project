using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_Web_Project.Models
{
    public class Order
    {
        [Key]
        public int orderId { get; set; }
        public String orderItemName { get; set; }
        public String orderDesc { get; set; }

    }
}