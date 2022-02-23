using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MVC_Web_Project.Models
{
    public class Customer
    {
       [Key]
        public int CustID { get; set; }
        public String CustName { get; set; }
     
    }
}