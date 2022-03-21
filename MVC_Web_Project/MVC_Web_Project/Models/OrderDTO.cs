using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Web_Project.Models
{
    public class OrderDTO
    {
        public int OrderID { get; set; }
        public String OrderItemName { get; set; }
        public String OrderDesc {  get; set; }

    }
}