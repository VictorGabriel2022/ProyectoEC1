using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace Proyecto_EC1.Entitys
{
    public class Producto
    {
        internal int ID;

        //definimos la clave primaria
        [Key]
        public int ID_PROD { get; set; }
        //definimos valores no nulos
        [Required]
        //definimos el tamaño del campo
        [StringLength(
            maximumLength: 100,
            ErrorMessage = "Se tiene que ingresar un nombre de un producto"
            )]
        public string ID_CATG { get; set; }
        [Required]
        public bool NOM_PROD { get; set; }

        [Required]
        public bool PREC_PROD { get; set; }

        [Required]
        public bool STOCK_PROD { get; set; }



        public List<Categoria> Categoria { get; set; }
    }
}
