using Lanchonete.Core.Entities;
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
        DataContext context;

        public LanchesController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Lanche>> Get()
        {
            List<Lanche> list = context.Get<Lanche>();

            if (list != null)
            {
                return list;
            }
            else
            {
                return NotFound();
            }

            // return Lanche.Get();
        }

        [HttpGet("{id}")]
        public ActionResult<Lanche> Get(int id)
        {
            return Lanche.Get(id);
        }
    }
}
