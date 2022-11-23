using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;


namespace Proyecto_EC1.Entitys
{
    public class Categoria
    {
        [Key]
        public int Id_catg { get; set; }
        [Required]
        [StringLength(
         maximumLength: 100,
         ErrorMessage = "Se tiene que ingresar un nombre"
         )]
        public string nom_catg { get; set; }
        [Required]
        public bool estado { get; set; }
        

    }
}
