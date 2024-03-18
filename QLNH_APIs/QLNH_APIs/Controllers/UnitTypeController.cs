using Microsoft.AspNetCore.Mvc;
using QLNH_APIs.Data;
using QLNH_APIs.Models;
using System.Collections.Generic;
using System.Linq;

namespace QLNH_APIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UnitTypeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UnitTypeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<UnitType> Get()
        {
            return _context.UnitType.ToList();
        }
    }
}