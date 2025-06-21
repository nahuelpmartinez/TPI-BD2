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
    public partial class frmAgregarSucursales : Form
    {
        private Sucursal sucursal = null;

        private OpenFileDialog archivo = null;
        public frmAgregarSucursales()
        {
            InitializeComponent();
        }

        public frmAgregarSucursales(Sucursal sucursal)
        {
            InitializeComponent();
            this.sucursal = sucursal;
            Text = "Modificar Sucursal";
        }

        private void frmAgregarSucursales_Load(object sender, EventArgs e)
        {
            try
            {

                if (sucursal != null)
                {
                    txtNombre.Text = sucursal.Nombre;
                    txtDireccion.Text = sucursal.Direccion;

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            SucursalNegocio negocio = new SucursalNegocio();
            try
            {
                //VALIDACIÓN CARGA DE SUCURSAL
                //if (validarCargaArticulo())
                //    return;

                if (sucursal == null)
                    sucursal = new Sucursal();

                sucursal.Nombre = txtNombre.Text;
                sucursal.Direccion = txtDireccion.Text;

                if (sucursal.Id != 0)
                {
                    negocio.modificar(sucursal);
                    sucursal.Id = negocio.ultimoAgregado(); //Busca el ultimo articulo (Que es el que se agrego recien)
                    MessageBox.Show("Articulo modificado exitosamente");
                }
                else
                {
                    //VALIDACIÓN CARGA DE SUCURSAL
                    //if (validarCargaArticulo())
                    //    return;
                    negocio.agregar(sucursal); //Agregar el Articulo a la Base de datos
                    sucursal.Id = negocio.ultimoAgregado(); //Busca el ultimo articulo (Que es el que se agrego recien)
                    MessageBox.Show("Articulo agregado exitosamente");

                }


                Close();

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
    }
}
