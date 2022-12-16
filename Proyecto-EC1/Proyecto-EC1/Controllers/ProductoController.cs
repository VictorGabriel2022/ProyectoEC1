using Proyecto_EC1.Entitys;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_EC1;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_EC1.Controllers
{
    [ApiController]
    [Route("Proyecto_EC1/producto")]
    public class ProductoController : ControllerBase
    {
        private readonly ApplicationDBContext context;

        public ProductoController(ApplicationDBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Producto>>> findAll()
        {
            return await context.Producto.Include(x => x.Categoria).ToListAsync();
        }



        [HttpPost]
        public async Task<ActionResult> add(Producto l)
        {
            //verificando la existencia del autor
            var autorexiste = await context.Categoria
                .AnyAsync(x => x.Id_catg == l.Id_catg);

            if (!autorexiste)
            {
                return BadRequest($"No existe el autor con codigo: {l.Id_catg}");
            }
            context.Add(l);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Producto>> findById(int id)
        {
            var libro = await context.Producto
                .FirstOrDefaultAsync(x => x.Id_prod == id);
            return libro;

        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> update(Producto l, int id)
        {
            if (l.Id_prod != id)
            {
                return BadRequest("No se encuentra el codigo correspondiente");
            }

            context.Update(l);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> delete(int id)
        {

            var existe = await context.Producto.AnyAsync(x => x.Id_prod == id);
            if (!existe)
            {
                return NotFound();
            }
            var autor = await context.Producto.FirstOrDefaultAsync(x => x.Id_prod == id);
            autor.estado = false;
            context.Update(autor);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}

