using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_EC1.Entitys
{
    public class Cita
    {
        [Key]
        public int id_cita { get; set; }
        [Required]
        //definimos el tamaño del campo
        [StringLength(maximumLength: 100,
            ErrorMessage = "Se tiene que ingresar un nombre")]
        public string distrito { get; set; }
        [Required]
        public string direccion { get; set; }
        public int fecha { get; set; }
        [Required]
        public Cliente Cliente { get; set; }

    }
}
