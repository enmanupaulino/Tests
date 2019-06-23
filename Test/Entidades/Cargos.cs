using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Entidades
{
    public class Cargos
    {
        public int IdCargo;
        public string Nombre;

        [Key]
        public int Idcargo { get; set; }
        public string NombreCargo { get; set; }
        public int IdEstado { get; set; }

        public Cargos()
        {
            Idcargo = 0;
            NombreCargo = string.Empty;
            IdEstado = 0;
        }
    }
}
