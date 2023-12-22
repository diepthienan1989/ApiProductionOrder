using Microsoft.AspNetCore.Mvc;
using ProductionOrder.Data;
using ProductionOrder.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Text.RegularExpressions;

namespace ProductionOrder.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductionOrdersController : Controller
    {
        private readonly AESProductionOrdersDbContext _ProductionOderDbContext;
        public ProductionOrdersController(AESProductionOrdersDbContext ProductionOderDbContext)
        {
            _ProductionOderDbContext = ProductionOderDbContext;
        }

        [HttpPost(Name = "NewProductionOrder")]
        public async Task<IActionResult> AddData([FromBody] ProductionOrders dataRequest)
        {
            await _ProductionOderDbContext.ProductionOrders.AddAsync(dataRequest);
            await _ProductionOderDbContext.SaveChangesAsync();
            return Ok(dataRequest);

        }

        [HttpGet]
        [Route("{id:long}")]
        public async Task<IActionResult> GetDataId([FromRoute] Guid id)
        {
            int ID = 0;
            var data = await _ProductionOderDbContext.ProductionOrders.FirstOrDefaultAsync(x => x.ProductionOrderID == id);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }

      
    }
}
