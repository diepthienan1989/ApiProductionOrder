using ProductionOrder.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace ProductionOrder.Data

{
    public class AESProductionOrdersDbContext : DbContext
    {
        public AESProductionOrdersDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ProductionOrders> ProductionOrders { get; set; }
    }
}
