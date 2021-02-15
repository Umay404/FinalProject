using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context:Db tabloları ile proje classlarını bağlamak
    public class NorthwindContext:DbContext
    {
        //Db yerini göstermek için
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Sql server kullanacağım ve nasıl bağlanacağını belirmeliyim.
            optionsBuilder.UseSqlServer(@"Server=LENOVO-PC\SQL2019;Database-Northwind;Trusted_Connection=true");
        }
        //kullandığımız tabloları tanımladık
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
