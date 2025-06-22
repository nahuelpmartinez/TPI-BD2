using dominio;
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
    public partial class frmAgregarStock : Form
    {
        private Articulo articulo = null;
        private Stock stock = null;
        private Sucursal sucursal = null;
        private bool tipo;
        public frmAgregarStock()
        {
            InitializeComponent();
        }

        public frmAgregarStock(Articulo articulo, bool tipo)
        {
            InitializeComponent();
            this.articulo = articulo;
            this.tipo = tipo;
            if (tipo)
            {
                Text = "Insertar Stock";
            }
            else
            {
                Text = "Reducir Stock";
            }
        }

        private void frmAgregarStock_Load(object sender, EventArgs e)
        {
            SucursalNegocio sucursalNegocio = new SucursalNegocio();
            try
            {
                cbxSucursal.DataSource = sucursalNegocio.listar();
                cbxSucursal.ValueMember = "Id";
                cbxSucursal.DisplayMember = "Nombre";

                if (cbxSucursal.Items.Count > 0)
                {
                    cbxSucursal.SelectedIndex = 0;
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
                if (cbxSucursal.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una 'Sucursal'.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
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

                Sucursal sucursalSeleccionada = (Sucursal)cbxSucursal.SelectedItem;
                stock.IdSucursal = sucursalSeleccionada.Id;

                stock.Cantidad = cantidad;

                if(tipo) //INGRESAR STOCK
                {
                    stockNegocio.agregar(stock);

                    MessageBox.Show("Stock ingresado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else //REDUCIR STOCK
                {
                    stockNegocio.reducirStock(stock);

                    MessageBox.Show("Stock reducido exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
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
