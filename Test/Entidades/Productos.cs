using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Entidades
{
   public class Productos
    {
        [Key]
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Fechafabricacion { get; set; }
        public double costocompra { get; set; }
        public double Stock { get; set; }
        public int IdUnidadMedida { get; set; }
        public int IdImagen { get; set; }
        public int IdCategoria { get; set; }
        public int IdMarca { get; set; }
        public int IdModelo { get; set; }
        public Productos()
        {
            IdProducto = 0;
            Nombre = string.Empty;
            Descripcion = string.Empty;
            Fechafabricacion = string.Empty;
            costocompra = 0;
            Stock = 0;
            IdUnidadMedida = 0;
            IdImagen = 0;
            IdCategoria = 0;
            IdMarca = 0;
            IdModelo = 0;

        }
    }
}
