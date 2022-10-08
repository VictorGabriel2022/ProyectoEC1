using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_EC1.Entitys
{
    public class Pedido
    {
        //definimos la clave primaria
        [Key]
        public int Id_pedido { get; set; }
        //definimos valores no nulos
        [Required]
        //definimos el tamaño del campo
        [StringLength(
        maximumLength: 100,
        ErrorMessage = "Se tiene que ingresar un pedido"
        )]
        public string Id_cliente { get; set; }
        [Required]
        public string Id_factura { get; set; }

        public DateAndTime fech_ped { get; set; }

        public DateAndTime hor_ped { get; set; }

        public DateAndTime hor_entr { get; set; }

        public int num_ped { get; set; }

        public DateAndTime fech_entr { get; set; }

        public string obs { get; set; }




    }
}
