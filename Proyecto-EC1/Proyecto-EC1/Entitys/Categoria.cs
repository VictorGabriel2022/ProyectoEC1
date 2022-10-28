using System.ComponentModel.DataAnnotations;



namespace Proyecto_EC1.Entitys
{
    public class Categoria
    {
        [Key]
        public int Id_catg { get; set; }
        [Required]
        //definimos el tamaño del campo
        [StringLength(maximumLength: 100,
            ErrorMessage = "Se tiene que ingresar un nombre de un producto")]
        public string nom_catg{ get; set; }
        [Required]
        public string desp_catg { get; set; }

        
    }
}