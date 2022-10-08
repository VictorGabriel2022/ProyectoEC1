using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace Proyecto_EC1.Entitys
{
    public class Producto
    {
        //definimos la clave primaria
        [Key]
        public int Id_prod { get; set; }
        //definimos valores no nulos
        [Required]
        //definimos el tamaño del campo
        [StringLength(
            maximumLength: 100,
            ErrorMessage = "Se tiene que ingresar un nombre de un producto"
            )]
    
        public bool NOM_PROD { get; set; }

        [Required]
        public bool PREC_PROD { get; set; }

        [Required]
        public bool STOCK_PROD { get; set; }
        [Required]
        public Categoria Categoria { get; set; }




    }
}
