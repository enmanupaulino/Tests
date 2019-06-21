using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Entidades
{
    public class TipoPersona
    {
        [Key]
        public int Idtipopersona { get; set; }
        public string Nombre { get; set; }
        public TipoPersona()
        {
            Idtipopersona = 0;
            Nombre = string.Empty;
        }

    }
}
