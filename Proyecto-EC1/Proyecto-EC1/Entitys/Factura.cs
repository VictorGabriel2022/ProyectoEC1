using System.ComponentModel.DataAnnotations;

namespace Proyecto_EC1.Entitys
{
    public class Factura
    {
        [Key]
        public int Id_Factura { get; set; }
        [Required]
        //definimos el tamaño del campo
        [StringLength(maximumLength: 100,
            ErrorMessage = "Se tiene que ingresar un ID ")]
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        [Required]
        public int importe { get; set; }
    }
}
