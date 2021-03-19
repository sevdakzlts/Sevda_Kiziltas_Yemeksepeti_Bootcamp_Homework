using System;
using System.Collections.Generic;
using System.Text;
using Homework_4_5.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Homework_4_5.DataAccess.Concrete.EntityFramework.Contexts
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
    }
}
