using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Entidades
{
    public class Proveedores
    {
        [Key]
        public int IdProveedor { get; set; }
        public int IdPersoan { get; set; }
        public Proveedores()
        {
            IdProveedor = 0;
            IdPersoan = 0;
        }
    }
}
