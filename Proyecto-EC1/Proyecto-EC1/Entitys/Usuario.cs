using System.ComponentModel.DataAnnotations;

namespace Proyecto_EC1.Entitys
{
    public class Usuario
    {
        [Key]
        public int Id_Usuario { get; set; }
        [Required]
        //definimos el tamaño del campo
        [StringLength(maximumLength: 100,
            ErrorMessage = "Se tiene que ingresar su ID ")]
        public string email { get; set; }
        [Required]
        public string Contraseña { get; set; }

    }
}
