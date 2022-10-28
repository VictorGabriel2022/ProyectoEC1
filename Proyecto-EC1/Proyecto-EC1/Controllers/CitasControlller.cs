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
    [Route("Proyecto_EC1/citas")]
    public class CitasController : ControllerBase
    {
        private readonly ApplicationDBContext context;

        public CitasController(ApplicationDBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Cita>>> findAll()
        {
            return await context.Cita.Include(x => x.Cliente).ToListAsync();
        }

      

        [HttpPost]
        public async Task<ActionResult> add(Cita l)
        {
            //verificando la existencia del autor
            var autorexiste = await context.Cliente
                .AnyAsync(x => x.Id_Cliente == l.Id_Cliente);

            if (!autorexiste)
            {
                return BadRequest($"No existe el autor con codigo: {l.Id_Cliente}");
            }
            context.Add(l);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Cita>> findById(int id)
        {
            var libro = await context.Cita
                .FirstOrDefaultAsync(x => x.id_cita == id);
            return libro;

        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> update(Cita l, int id)
        {
            if (l.id_cita != id)
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

            var existe = await context.Cita.AnyAsync(x => x.id_cita == id);
            if (!existe)
            {
                return NotFound();
            }
            var libro = await context.Producto.
                FirstOrDefaultAsync(x => x.Id_prod == id);
            context.Update(libro);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
