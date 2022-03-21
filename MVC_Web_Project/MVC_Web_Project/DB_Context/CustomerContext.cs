using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MVC_Web_Project.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext() : base("CustomerContext")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Customer>().HasKey(c => c.CustomerID);
            modelBuilder.Entity<Customer>().HasKey(c => c.CustomerName);


        }
    }
}