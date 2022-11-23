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
    
        public string nomb_prod { get; set; }

        [Required]
        public float prec_prod { get; set; }

        [Required]
        public int stock_prod { get; set; }
        [Required]
        public int Id_catg { get; set; }
        [Required]
        public bool estado { get; set; }

        public Categoria Categoria { get; set; }




    }
}
