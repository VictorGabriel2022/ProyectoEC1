using Microsoft.EntityFrameworkCore;
using Proyecto_EC1.Entitys;

namespace Proyecto_EC1
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) :base(options)
        {
        }
        //configurando las tablas de la base datos
        public DbSet<Producto> Producto { get; set; }
    }

}

