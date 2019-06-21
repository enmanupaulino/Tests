using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Entidades;

namespace Test.DAL
{
    public class Contexto :DbContext
    {
        public DbSet<Cargos> cargos { get; set; }
        public DbSet<Categorias> categorias { get; set; }
        public DbSet<Compras> compras { get; set; }
        public DbSet<DetalleCompra> detalleCompras { get; set; }
        public DbSet<DetalleVenta> detalleVentas { get; set; }
        public DbSet<Empleados> empleados { get; set; }
        public DbSet<Estados> estados { get; set; }
        public DbSet<Imagenes> imagenes { get; set; }
        public DbSet<Marcas> marcas { get; set; }
        public DbSet<Modelos> modelos { get; set; }
        public DbSet<Permisos> permisos { get; set; }
        public DbSet<Personas> personas { get; set; }
        public DbSet<Productos> productos { get; set; }
        public DbSet<Proveedores> proveedores { get; set; }
        public DbSet<TipoPersona> tipoPersonas { get; set; }
        public DbSet<TiposComprobantes> TiposComprobantes { get; set; }
        public DbSet<UnidadesMedidas> unidadesMedidas { get; set; }
        public DbSet<Usuarios> usuarios { get; set; }
        public DbSet<UsuariosPermisos> usuariosPermisos { get; set; }
        public DbSet<Ventas> ventas { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}
