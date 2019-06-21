using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Entidades
{
  public class Personas
    {
        [Key]
        public int IdPersona { get; set; }
        public int dni { get; set; }
        public string nombre { get; set; }
        public string Paterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Sexo { get; set; }
        public string Direccion { get; set; }


        public Personas()
        {
            IdPersona = 0;
            dni = 0;
            nombre = string.Empty;
            Paterno = string.Empty;
            FechaNacimiento = DateTime.Now;
            Telefono = string.Empty;
            Correo = string.Empty;
            Sexo = string.Empty;
            Direccion = string.Empty;
        }

    }

}
