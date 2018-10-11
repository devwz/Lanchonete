using Lanchonete.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lanchonete.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanchesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Lanche>> Get()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{titulo}")]
        public ActionResult<Lanche> Get(string titulo)
        {
            throw new NotImplementedException();
        }
    }
}
