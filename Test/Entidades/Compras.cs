using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Entidades
{
    public class Compras
    {
        [Key]
        public int IdCompro { get; set; }
        public int IdUsuarios { get; set; }
        public DateTime FechaCompra { get; set; }
        public int IdProveedor { get; set; }
        public int IdComprobante { get; set; }
        public double CostoCompra { get; set; }
        public Compras()
        {
            IdCompro = 0;
            IdUsuarios = 0;
            FechaCompra = DateTime.Now;
            IdProveedor = 0;
            IdComprobante = 0;
            CostoCompra = 0;
        }
    }
}
