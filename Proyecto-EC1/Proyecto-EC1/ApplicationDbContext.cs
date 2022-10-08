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
        public DbSet<Cita> Cita { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Detalle_pedido> Detalle_pedido { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }

}

