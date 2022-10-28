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
    [Route("Proyecto_EC1/categoria")]
    //: ControllerBase es una herencia para que sea un controlador
    public class CategoriaController : ControllerBase
    {
        private readonly ApplicationDBContext context;

        //creamos el metodo constructor
        public CategoriaController(ApplicationDBContext context)
        {
            this.context = context;
        }

        //cuando queremos obtener informacion
        [HttpGet]
        public async Task<ActionResult<List<Categoria>>> findAll()
        {
            return await context.Categoria.ToListAsync();
        }

        //cuando queremos guardar informacion
        [HttpPost]
        public async Task<ActionResult> add(Categoria a)
        {
            context.Add(a);
            await context.SaveChangesAsync();
            return Ok();
        }
        //cuado queremos buscar informacion
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Categoria>> findById(int id)
        {
            var categoria = await context.Categoria.FirstOrDefaultAsync(x => x.Id_catg == id);
            return categoria;

        }

        //cuado tenemos que actualizar informacion
        [HttpPut("{id:int}")]
        public async Task<ActionResult> update(Categoria a, int id)
        {
            if (a.Id_catg != id)
            {
                return BadRequest("No se encuentra el codigo correspondiente");
            }

            context.Update(a);
            await context.SaveChangesAsync();
            return Ok();


        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> delete(Producto a, int id)
        {
            if (a.Id_prod != id)
            {
                return BadRequest("No se encuentra el codigo correspondiente");
            }
        
            await context.SaveChangesAsync();
            return Ok();

        }
    }
}

