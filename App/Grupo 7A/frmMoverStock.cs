using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_7A
{
    public partial class frmMoverStock : Form
    {
        private Articulo articulo = null;
        private Sucursal sucursal = null;

        private OpenFileDialog archivo = null;
        public frmMoverStock()
        {
            InitializeComponent();
        }

        public frmMoverStock(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Ingresar Stock";
        }
        private void frmMoverStock_Load(object sender, EventArgs e)
        {

        }
    }
}
