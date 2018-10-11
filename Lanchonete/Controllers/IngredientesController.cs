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
    public class IngredientesController : ControllerBase
    {
        DataContext context;

        public IngredientesController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Ingrediente>> Get()
        {
            List<Ingrediente> ingredientes = context.Get<Ingrediente>("Ingredientes");

            return ingredientes;
        }

        [HttpGet("{titulo}")]
        public ActionResult<Models.Ingrediente> Get(string titulo)
        {
            Ingrediente ingrediente = context.Get<Ingrediente>("Ingredientes", titulo);

            return ingrediente;
        }
    }
}
