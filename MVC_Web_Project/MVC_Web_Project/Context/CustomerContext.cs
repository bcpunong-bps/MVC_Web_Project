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
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Customer>().HasKey(c => c.CustID);
            modelBuilder.Entity<Customer>().Property(c => c.CustID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Customer>().Property(c => c.CustName).HasMaxLength(64);


            modelBuilder.Entity<Order>()
              .ToTable("Orders");
            modelBuilder.Entity<Order>().HasKey(o => o.orderId);
            modelBuilder.Entity<Order>().Property(o => o.orderId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        }

    }

    

}