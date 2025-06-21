using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_7A
{
    public partial class frmSucursales : Form
    {
        private List<Sucursal> listaSucursales;
        public frmSucursales()
        {
            InitializeComponent();
        }

        private void cargar()
        {
            SucursalNegocio negocio = new SucursalNegocio();
            try
            {
                listaSucursales = negocio.listar();
                dgvSucursales.DataSource = listaSucursales;
                ocultarColumnas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmSucursales_Load(object sender, EventArgs e)
        {
            SucursalNegocio negocio = new SucursalNegocio();
            try
            {
                listaSucursales = negocio.listar();
                dgvSucursales.DataSource = listaSucursales;
                ocultarColumnas();
                dgvSucursales.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                dgvSucursales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                //CultureInfo arCulture = new CultureInfo("es-AR"); // Código para $ARS
                //dgvSucursales.Columns["Precio"].DefaultCellStyle.Format = "c2";
                //dgvSucursales.Columns["Precio"].DefaultCellStyle.FormatProvider = arCulture;
                //dgvSucursales.Columns["Precio"].DefaultCellStyle.NullValue = "0.00";
                //if (listaArticulos.Count > 0)
                //{
                //    cargarImagen(listaArticulos[0].Imagen);
                //}


                if (dgvSucursales.Rows.Count > 0)
                {
                    cargar();
                    dgvSucursales.Rows[0].Selected = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvSucursales.Columns["Id"].Visible = false;
            dgvSucursales.Columns["Estado"].Visible = false;
        }

        private void dgvSucursales_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSucursales.CurrentRow != null)
            {
                Sucursal seleccionado = (Sucursal)dgvSucursales.CurrentRow.DataBoundItem;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarSucursales agregarSucursales = new frmAgregarSucursales();
            agregarSucursales.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Sucursal seleccionado;
                seleccionado = (Sucursal)dgvSucursales.CurrentRow.DataBoundItem;

                frmAgregarSucursales modificarSucursales = new frmAgregarSucursales(seleccionado);
                modificarSucursales.ShowDialog();
                cargar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            SucursalNegocio negocio = new SucursalNegocio();
            Sucursal seleccionado;
            try
            {
                if (dgvSucursales.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Desea eliminar el artículo seleccionado?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Sucursal)dgvSucursales.CurrentRow.DataBoundItem;
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
    }
}
