using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS01;Initial Catalog=Northwind;Integrated Security=True");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category>  Categories { get; set; }
        public DbSet<Customer>  Customers { get; set; }
    }
    
}
