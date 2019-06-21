using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Entidades
{
    public class Usuarios
    {
        [Key]
        public int IdUsuarios { get; set; }
        public int Idempleaddo { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public Usuarios()
        {
            IdUsuarios = 0;
            Idempleaddo = 0;
            NombreUsuario = string.Empty;
            Clave = string.Empty;
        }
    }
}
