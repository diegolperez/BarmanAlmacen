using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarmanAlmacen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarmanController : ControllerBase
    {
        [HttpGet]
        public dynamic Get()
        {
            return "Hola mundo";
        }
    }
}
