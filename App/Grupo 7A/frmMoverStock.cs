using dominio;
using negocio;
using System;
using System.Collections;
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
        private Stock stock = null;
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
            Text = "Mover Stock";
        }
        private void frmMoverStock_Load(object sender, EventArgs e)
        {
            SucursalNegocio sucursalNegocio = new SucursalNegocio();
            try
            {
                cbxOrigen.DataSource = sucursalNegocio.listar();
                cbxOrigen.ValueMember = "Id";
                cbxOrigen.DisplayMember = "Nombre";

                cbxDestino.DataSource = sucursalNegocio.listar();
                cbxDestino.ValueMember = "Id";
                cbxDestino.DisplayMember = "Nombre";

                if (cbxOrigen.Items.Count > 0)
                {
                    cbxOrigen.SelectedIndex = 0;
                }
                if (cbxDestino.Items.Count > 0)
                {
                    cbxDestino.SelectedIndex = 0;
                }

                if (articulo != null)
                {
                    txtCodigoArticulo.Text = articulo.Codigo.ToString();
                    txtNombreArticulo.Text = articulo.Nombre;
                    txtCodigoArticulo.Enabled = false;
                    txtNombreArticulo.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del formulario: " + ex.Message, "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            StockNegocio stockNegocio = new StockNegocio();

            try
            {
                if (string.IsNullOrWhiteSpace(txtCantidad.Text))
                {
                    MessageBox.Show("El campo 'Cantidad' no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int cantidad;
                if (!int.TryParse(txtCantidad.Text, out cantidad))
                {
                    MessageBox.Show("La 'Cantidad' debe ser un número válido.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // --- Lógica condicional para obtener IdArticulo ---
                int idArticuloFinal;

                idArticuloFinal = articulo.Id;

                if (stock == null)
                    stock = new Stock();

                // Mapeo de valores al objeto Stock
                stock.Id = idArticuloFinal;

                Sucursal sucursalOrigen = (Sucursal)cbxOrigen.SelectedItem;
                stock.IdSucursal = sucursalOrigen.Id;

                Sucursal sucursalDestino = (Sucursal)cbxDestino.SelectedItem;
                int destino;
                destino = sucursalDestino.Id;

                stock.Cantidad = cantidad;

                stockNegocio.mover(stock, destino);

                MessageBox.Show("Se movió el Stock exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (ApplicationException appEx)
            {
                MessageBox.Show(appEx.Message, "Error en la Operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Las conexiones se cierran en los métodos de negocio (AccesoDatos.cerrarConexion())
            }
        }
    }
}
