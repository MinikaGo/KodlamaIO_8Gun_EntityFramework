using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : DB tabloları ile proje classlarını bağlamak
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}


