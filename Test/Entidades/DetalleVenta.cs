using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Entidades
{
    public class DetalleVenta
    {
        [Key]
        public int IdVenta { get; set; }
        public int IdDetalleVenta { get; set; }
        public int IdProducto { get; set; }
        public double Unidades { get; set; }
        public double costounidades { get; set; }
        public double Total { get; set; }
        public DetalleVenta()
        {

        }
    }
}
