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
    public partial class frmStockPorSucursal : Form
    {
        public frmStockPorSucursal()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmStockPorSucursal_Load);
        }
        private void frmStockPorSucursal_Load(object sender, EventArgs e)
        {
            cargarVistaStock();
        }
        private void cargarVistaStock()
        {
            VistaNegocio negocio = new VistaNegocio();
            try
            {
                dgvStockPorSucursal.DataSource = negocio.obtenerVistaStock();
                dgvStockPorSucursal.Columns["IdSucursal"].Visible = false;

                // Opcional: Autoajustar las columnas para que se vean bien
                dgvStockPorSucursal.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                //MessageBox.Show("Vista de stock cargada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
