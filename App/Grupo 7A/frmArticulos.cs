using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Globalization;

namespace Grupo_7A
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulos;
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                ocultarColumnas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }


        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                if (dgvArticulos.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Desea eliminar el artículo seleccionado?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                        negocio.eliminar(seleccionado.Id);
                        cargar();
                    }
                }
                else
                {
                    MessageBox.Show("No existe artículo para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            slblFechaHora.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                ocultarColumnas();
                dgvArticulos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                dgvArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                CultureInfo arCulture = new CultureInfo("es-AR"); // Código para $ARS
                dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "c2";
                dgvArticulos.Columns["Precio"].DefaultCellStyle.FormatProvider = arCulture;
                dgvArticulos.Columns["Precio"].DefaultCellStyle.NullValue = "0.00";

                if (dgvArticulos.Rows.Count > 0)
                {
                    cargar();
                    dgvArticulos.Rows[0].Selected = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Estado"].Visible = false;
        }
       
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo agregarArticulo = new frmAgregarArticulo();
            agregarArticulo.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                Articulo seleccionado;
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                frmAgregarArticulo modificarArticulo = new frmAgregarArticulo(seleccionado);
                modificarArticulo.ShowDialog();
                cargar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnAdmMarcas_Click(object sender, EventArgs e)
        {
            frmAdministrar administrar = new frmAdministrar(true);
            administrar.ShowDialog();
        }

        private void btnAdmCategorias_Click(object sender, EventArgs e)
        {
            frmAdministrar administrar = new frmAdministrar(false);
            administrar.ShowDialog();

        }

        private void txtBusquedaRapida_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtBusquedaRapida.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }
        private void rbtnCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCodigo != null && rbtnCodigo.Checked)
            {
                cbxCriterio.Text = string.Empty;             
            }
            cbxCriterio.Items.Clear();
            cbxCriterio.Items.Add("Comienza con");
            cbxCriterio.Items.Add("Termina con");
            cbxCriterio.Items.Add("Contiene");
        }

        private void rbtnNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNombre != null && rbtnNombre.Checked)
            {
                cbxCriterio.Text = string.Empty;
            }
            cbxCriterio.Items.Clear();
            cbxCriterio.Items.Add("Comienza con");
            cbxCriterio.Items.Add("Termina con");
            cbxCriterio.Items.Add("Contiene");
        }

        private void rbtnMarca_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMarca != null && rbtnMarca.Checked)
            {
                cbxCriterio.Text = string.Empty;
            }
            cbxCriterio.Items.Clear();
            cbxCriterio.Items.Add("Comienza con");
            cbxCriterio.Items.Add("Termina con");
            cbxCriterio.Items.Add("Contiene");
        }

        private void rbtnCategoria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCategoria != null && rbtnCategoria.Checked)
            {
                cbxCriterio.Text = string.Empty;
            }
            cbxCriterio.Items.Clear();
            cbxCriterio.Items.Add("Comienza con");
            cbxCriterio.Items.Add("Termina con");
            cbxCriterio.Items.Add("Contiene");
        }

        private bool validarFiltro()
        {
            if ((rbtnCodigo.Checked == false) && (rbtnNombre.Checked == false) && (rbtnMarca.Checked == false) && (rbtnCategoria.Checked == false))
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar");
                return true;
            }
            if (cbxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar");
                return true;
            }
            return false;
        }

        public string validarCampo()
        {
            if (rbtnCodigo.Checked)
            {
                return "Código";
            }
            else if (rbtnNombre.Checked)
            {
                return "Nombre";
            }
            else if (rbtnMarca.Checked)
            {
                return "Marca";
            }
            else if (rbtnCategoria.Checked)
            {
                return "Categoria";
            }
            return "";
        }

        //private bool soloNumeros(string cadena)
        //{
            //foreach (char caracter in cadena)
            //{
                //if (!(char.IsNumber(caracter)))
                    //return false;
            //}
            //return true;

        //}

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string campo = validarCampo();
                string criterio = cbxCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
            frmSucursales sucursales = new frmSucursales();
            sucursales.ShowDialog();

        }

        private void btnIngresarStock_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo articuloSeleccionado;
                articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                //Sucursal sucursalSeleccionada;
                //sucursalSeleccionada = (Sucursal)cbx

                frmAgregarStock agregarStock = new frmAgregarStock(articuloSeleccionado);
                agregarStock.ShowDialog();
                cargar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnMoverStock_Click(object sender, EventArgs e)
        {
            frmMoverStock moverStock = new frmMoverStock();
            moverStock.ShowDialog();
        }
    }
}

