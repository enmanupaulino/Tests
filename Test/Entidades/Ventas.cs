using System;
using System.ComponentModel.DataAnnotations;

namespace Test.Entidades
{
    public class Ventas
    {

        [Key]
        public int IdVenta { get; set; }
        public int IdUsuario { get; set; }
        public int IdCliente { get; set; }
        public int IdComprobante { get; set; }
        public DateTime FechaVenta { get; set; }
        public double Igv { get; set; }
        public double SubTotal { get; set; }
        public double costoventa { get; set; }

        public Ventas()
        {
            IdVenta = 0;
            IdUsuario = 0;
            IdCliente = 0;
            IdComprobante = 0;
            FechaVenta = DateTime.Now;
            Igv = 0;
            SubTotal = 0;
            costoventa = 0;
        }
    }
}
