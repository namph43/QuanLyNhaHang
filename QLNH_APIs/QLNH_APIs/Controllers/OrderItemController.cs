using Microsoft.AspNetCore.Mvc;
using QLNH_APIs.Data;
using QLNH_APIs.Models;
using System.Collections.Generic;
using System.Linq;

namespace QLNH_APIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderItemController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public OrderItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<OrderItem> Get()
        {
            return _context.OrderItem.ToList();
        }
    }
}
