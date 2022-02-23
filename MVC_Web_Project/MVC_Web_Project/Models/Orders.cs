using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Web_Project.Models
{
    public class Order
    {
      
        public int orderID { set; get; }
        [key]
        public String orderItmName { set; get; }
        public String orderDesc { set; get; }



    }




}