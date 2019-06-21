using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Entidades
{
    public class Estados
    { 
        [Key]
        public int IdEstado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime  fechafin { get; set; }
        public string Estado { get; set; }

        public Estados()
        {
            IdEstado = 0;
            FechaInicio = DateTime.Now;
            fechafin = DateTime.Now;
            Estado = string.Empty;
        }
    }
}
