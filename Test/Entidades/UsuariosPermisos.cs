using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Entidades
{
    public class UsuariosPermisos
    {
        [Key]
        public int IdUsuario { get; set; }
        public int IdPermiso { get; set; }
        public UsuariosPermisos()
        {
            IdUsuario = 0;
            IdPermiso = 0;
        }
    }
}
