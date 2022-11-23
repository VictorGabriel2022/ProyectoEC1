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
    [Route("Proyecto_EC1/detallepedido")]
    public class DetallePedidoController : ControllerBase
    {
        private readonly ApplicationDBContext context;

        public DetallePedidoController(ApplicationDBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Detalle_pedido>>> findAll()
        {
            return await context.Detalle_pedido.Include(x => x.Pedido).Include(x => x.Producto).ToListAsync();

        }



        [HttpPost]
        public async Task<ActionResult> add(Detalle_pedido l)
        {
            //verificando la existencia del autor
            var pedidoexiste = await context.Pedido
                .AnyAsync(x => x.Id_pedido == l.Id_pedido);

            if (!pedidoexiste)
            {
                return BadRequest($"No existe el pedido con codigo: {l.Id_pedido}");
            }
            var productoexiste = await context.Producto.
                AnyAsync(x => x.Id_prod == l.Id_prod);
            if (!productoexiste)
            {
                return BadRequest($"No existe el producto con codigo: {l.Id_prod}");
            }
            context.Add(l);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Detalle_pedido>> findById(int id)
        {
            var dpedido = await context.Detalle_pedido
                .FirstOrDefaultAsync(x => x.Id_dped == id);
            return dpedido;

        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> update(Detalle_pedido l, int id)
        {
            if (l.Id_dped != id)
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
            var libro = await context.Producto.
                FirstOrDefaultAsync(x => x.Id_prod == id);
            context.Update(libro);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
