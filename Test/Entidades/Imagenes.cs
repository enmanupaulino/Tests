using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Entidades
{
   public class Imagenes
    {
        [Key]
        public int IdImagen { get; set; }
        public string rutaimagen { get; set; }
        public Imagenes()
        {
            IdImagen = 0;
            rutaimagen = string.Empty;
        }
    }
}
