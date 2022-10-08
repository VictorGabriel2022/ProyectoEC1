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

        public int fech_ped { get; set; }

        public int hor_ped { get; set; }

        public int hor_entr { get; set; }

        public int num_ped { get; set; }

        public int fech_entr { get; set; }

        public string obs { get; set; }


        [Required]
        public Cliente Cliente { get; set; }
        [Required]
        public Factura factura { get; set; }




    }
}
