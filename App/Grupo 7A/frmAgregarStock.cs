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
        public frmAgregarStock()
        {
            InitializeComponent();
        }

        public frmAgregarStock(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frmAgregarStock_Load(object sender, EventArgs e)
        {
            SucursalNegocio sucursalNegocio = new SucursalNegocio();
            try
            {
                cbxSucursal.DataSource = sucursalNegocio.listar();
                cbxSucursal.ValueMember = "Id";
                cbxSucursal.DisplayMember = "Nombre";

                cbxSucursal.SelectedIndex = 0;

                if (articulo != null)
                {
                    txtCodigoArticulo.Text = articulo.Codigo.ToString();
                    txtNombreArticulo.Text = articulo.Nombre;

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
        //    StockNegocio negocio = new StockNegocio();
        //    try
        //    {
        //        //if (validarCargaArticulo())
        //        //    return;

        //        if (stock == null)
        //            stock = new Stock();

        //        int idArticulo = int.Parse(txtCodigoArticulo.Text);
        //        Sucursal sucursalSeleccionada = (Sucursal)cbxSucursal.SelectedItem;
        //        int idSucursal = sucursalSeleccionada.Id;
        //        int Cantidad = int.Parse(txtCantidad.Text);

        //        if (stock.Id != 0 && stock.IdSucursal != 0)
        //        {
        //            negocio.modificar(idArticulo, idSucursal, Cantidad);
        //            //articulo.Id = negocio.ultimoAgregado(); //Busca el ultimo articulo (Que es el que se agrego recien)
        //            MessageBox.Show("Articulo modificado exitosamente");
        //        }
        //        else
        //        {
        //            //if (validarCargaArticulo())
        //            //    return;
        //            negocio.agregar(articulo); //Agregar el Articulo a la Base de datos
        //            articulo.Id = negocio.ultimoAgregado(); //Busca el ultimo articulo (Que es el que se agrego recien)
        //            MessageBox.Show("Articulo agregado exitosamente");

        //        }


        //        Close();

        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.ToString());
        //    }
        }
    }
}
