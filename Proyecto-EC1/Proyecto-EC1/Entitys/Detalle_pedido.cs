using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_EC1.Entitys
{
    public class Detalle_pedido
    {
        //definimos la clave primaria
        [Key]
        public int Id_dped { get; set; }
        //definimos valores no nulos
        [Required]
        public int Id_pedido { get; set; }
        [Required]
        public int Id_prod { get; set; }
        [Required]
        public int cant { get; set; }

        public float precio { get; set; }

        public float subtotal { get; set; }
        [Required]
        public bool estado { get; set; }

   
        public Producto Producto { get; set; }
      
        public Pedido Pedido{ get; set; }
       

    }
}
