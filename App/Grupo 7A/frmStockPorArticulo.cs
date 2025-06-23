using negocio;
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
    public partial class frmStockPorArticulo : Form
    {
        public frmStockPorArticulo()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmStockPorArticulo_Load);
        }
        private void frmStockPorArticulo_Load(object sender, EventArgs e)
        {
            cargarVistaStock();
        }
        private void cargarVistaStock()
        {
            VistaNegocio negocio = new VistaNegocio();
            try
            {
                dgvStockPorArticulo.DataSource = negocio.obtenerVistaStockArticulo();

                dgvStockPorArticulo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            }
            catch (ApplicationException appEx)
            {
                MessageBox.Show("Error al cargar la vista de stock: " + appEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado al cargar la vista de stock: " + ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
