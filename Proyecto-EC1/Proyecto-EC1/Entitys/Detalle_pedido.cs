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
        //definimos el tamaño del campo
        [StringLength(
        maximumLength: 100,
        ErrorMessage = "Se tiene que ingresar un pedido"
        )]
        public int Id_pedido { get; set; }
        
        public int Id_prod { get; set; }

        public string producto { get; set; }
        [Required]
        public int cant { get; set; }
        [Required]
        public int und { get; set; }

        public float precio { get; set; }

        public float subtotal { get; set; }

    }
}
