using Microsoft.EntityFrameworkCore;
using ReStore.Entities;

namespace ReStore.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options) 
        { 

        }

        public DbSet<Product> Products { get; set; } // create table Products
        public DbSet<Basket> Baskets { get; set; } // create table Baskets

    }
}
