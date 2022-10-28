using Proyecto_EC1.Entitys;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_EC1;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Proyecto_EC1.Controllers
{
    //dinciamos que es un controlador
    [ApiController]
    //es definir la ruta de acceso al controlador
    [Route("Proyecto_EC1/cliente")]
    //: ControllerBase es una herencia para que sea un controlador
    public class ClienteController : ControllerBase
    {
        private readonly ApplicationDBContext context;

        //creamos el metodo constructor
        public ClienteController(ApplicationDBContext context)
        {
            this.context = context;
        }

        //cuando queremos obtener informacion
        [HttpGet]
        public async Task<ActionResult<List<Cliente>>> findAll()
        {
           return await context.Cliente.ToListAsync();
        }

        //cuando queremos guardar informacion
        [HttpPost]
        public async Task<ActionResult> add(Cliente a)
        {
            context.Add(a);
            await context.SaveChangesAsync();
            return Ok();
        }
        //cuado queremos buscar informacion
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Cliente>> findById(int id)
        {
            var cliente = await context.Cliente.FirstOrDefaultAsync(x => x.Id_Cliente == id);
            return cliente;

        }

        //cuado tenemos que actualizar informacion
        [HttpPut("{id:int}")]
        public async Task<ActionResult> update(Cliente a, int id)
        {
            if (a.Id_Cliente != id)
            {
                return BadRequest("No se encuentra el codigo correspondiente");
            }

            context.Update(a);
            await context.SaveChangesAsync();
            return Ok();


        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> delete(Cliente a, int id)
        {
            if (a.Id_Cliente != id)
            {
                return BadRequest("No se encuentra el codigo correspondiente");
            }

            await context.SaveChangesAsync();
            return Ok();

        }
    }
}
