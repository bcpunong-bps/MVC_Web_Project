using MVC_Web_Project.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;



namespace MVC_Web_Project.Context
{
    public class CustomerContext : DbContext
    {

        public CustomerContext() : base ("CustomerContext")
        { 

        }
       
       public DbSet<Customer> Customers { set; get; }
        public DbSet<Order> Orders { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
        }

    }

    

}