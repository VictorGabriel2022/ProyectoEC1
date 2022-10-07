using System.ComponentModel.DataAnnotations;

namespace Proyecto_EC1.Entitys
{
    public class Producto
    {
        [Key]
        public int Id_Producto { get; set; }
        [Required]
        //definimos el tamaño del campo
        [StringLength(maximumLength: 100,
            ErrorMessage = "Se tiene que ingresar un nombre")]
        public string titulo { get; set; }
        [Required]
        public bool estado { get; set; }
      
    }
}
