using System.ComponentModel.DataAnnotations;



namespace Proyecto_EC1.Entitys
{
    public class Categoria
    {
        [Key]
        public int ID_CATG { get; set; }
        [Required]
        //definimos el tamaño del campo
        [StringLength(maximumLength: 100,
            ErrorMessage = "Se tiene que ingresar un nombre de un producto")]
        public string NOM_CATG { get; set; }
        [Required]
        public bool DESP_CATG { get; set; }
        [Required]
        public Producto producto { get; set; }
    }
}