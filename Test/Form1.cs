using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.BLL;
using Test.Entidades;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RepositorioBase<Cargos> db = new RepositorioBase<Cargos>();
            Cargos cargos = new Cargos()
            {
                IdEstado = 0,
                NombreCargo = "probando"
            };
            db.Guardar(cargos);
            
        }
    }
}
