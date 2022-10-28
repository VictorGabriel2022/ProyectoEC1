using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_EC1.Entitys
{
    public class Cliente
    {
        [Key]
        public int Id_Cliente { get; set; }
        [Required]
        //definimos el tamaño del campo
        [StringLength(maximumLength: 100,
            ErrorMessage = "Se tiene que ingresar un nombre")]
        public string nombre { get; set; }
        [Required]
        public string apellido { get; set; }
        public int fech_nac { get; set; }
        public int ruc { get; set; } 
        public int tip_doc { get; set; }
        [Required]
        public int Id_Usuario { get; set; }

        

    }
}
