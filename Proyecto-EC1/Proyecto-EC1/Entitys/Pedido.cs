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
        [Required]
        public int Id_Cliente { get; set; }

        public int fech_ped { get; set; }

        public int hor_ped { get; set; }

        public int fech_entr { get; set; }

        public string obs { get; set; }
        [Required]
        public bool estado { get; set; }


        
        public Cliente Cliente { get; set; }
      




    }
}
