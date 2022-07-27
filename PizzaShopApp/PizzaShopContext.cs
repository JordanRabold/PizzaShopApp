using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopApp
{
    public class PizzaShopContext : DbContext
    {
        public PizzaShopContext() // general constructor
        {

        }

        // connecting to SQLServer or Database
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Setting up EF connection string
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PizzaShopAppDB;Trusted_Connection=True");
        }

        // Tell EF Core to track students in the database
        public DbSet<Customer> Customers { get; set; }
    }
}
