using ProductionOrder.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace ProductionOrder.Data

{
    public class ProductionOrdersDbContext : DbContext
    {
        public ProductionOrdersDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<NewProduction_Order> NewProduction_Order { get; set; }
    }
}
