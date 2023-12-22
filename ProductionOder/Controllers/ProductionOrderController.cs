using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductionOrder.Data;
using ProductionOrder.Models;

namespace ProductionOder.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductionOrderController : ControllerBase
    {
        private readonly ProductionOrdersDbContext _ProductionOderDbContext;
        public ProductionOrderController(ProductionOrdersDbContext ProductionOderDbContext)
        {
            _ProductionOderDbContext = ProductionOderDbContext;
        }
        private static readonly string[] Summaries = new[]
        {
            "ProductionOrderID", "WIPOrderNo", "Chilly", "OrderType", "OrderStatus", "ExternalOrderNo", "Facility", "Priority", "Project", "Rank","Process","ProcessRev","Recipe"
        };

      


        private readonly ILogger<ProductionOrderController> _logger;

        public ProductionOrderController(ILogger<ProductionOrderController> logger)
        {
            _logger = logger;
            //}



        }

        [HttpPost(Name = "NewProductionOrder")]
        public async Task<IActionResult> AddData([FromBody] NewProduction_Order dataRequest)
        {
            await _ProductionOderDbContext.NewProduction_Order.AddAsync(dataRequest);
            await _ProductionOderDbContext.SaveChangesAsync();
            return Ok(dataRequest);

        }

        //[HttpPost(Name = "NewProductionOrder")]
        //public IEnumerable<ProductionOrderAPI> Post()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new ProductionOrderAPI
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

    }
}
