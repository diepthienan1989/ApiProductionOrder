using ProductionOrder.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace ProductionOrder.Data

{
    public class ProductionOrderDbContext : DbContext
    {
        public ProductionOrderDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ProductionOrders> ProductionOrders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderLines> OrderLines { get; set; }


    }
}
