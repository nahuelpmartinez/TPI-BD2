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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Grupo_7A
{
    public partial class frmAdministrar : Form
    {
        //Atributo para determinar si se trata de Marca(true) o Categoria(false)
        private bool tipo;

        public frmAdministrar(bool tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
            if (tipo)
            {
                Text = "Administrar Marca";
            }
            else
            {
                Text = "Administrar Categoria";
            }
        }

        private void frmAdministrar_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            try
            {
                if (tipo) //MARCA
                {
                    MarcaNegocio negocioM = new MarcaNegocio();
                    List<Marca> listaMarca = negocioM.listar();

                    dgvMarcaCategoria.DataSource = listaMarca;
                    dgvMarcaCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvMarcaCategoria.Columns["Id"].Visible = false;

                }
                else //CATEGORIA
                {
                    CategoriaNegocio negocioC = new CategoriaNegocio();
                    List<Categoria> listaCategoria = negocioC.listar();
                    dgvMarcaCategoria.DataSource = listaCategoria;
                    dgvMarcaCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvMarcaCategoria.Columns["Id"].Visible = false;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnAgregarMC_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAdministrador.Text))
                {
                    MessageBox.Show("El campo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAdministrador.Focus();
                }
                else
                {
                    if (tipo) //MARCA
                    {
                        MarcaNegocio negocioM = new MarcaNegocio();
                        Marca marca = new Marca();

                        marca.Descripcion = txtAdministrador.Text;

                        negocioM.agregar(marca);
                        txtAdministrador.Text = "";
                        MessageBox.Show("¡Marca agregada con exito!");

                        btnEliminarMC.Enabled = dgvMarcaCategoria.Rows.Count != -1;

                    }
                    else //CATEGORIA
                    {
                        CategoriaNegocio negocioC = new CategoriaNegocio();
                        Categoria categoria = new Categoria();

                        categoria.Descripcion = txtAdministrador.Text;

                        negocioC.agregar(categoria);
                        txtAdministrador.Text = "";
                        MessageBox.Show("¡Categoria agregada con exito!");

                        btnEliminarMC.Enabled = dgvMarcaCategoria.Rows.Count != -1;
                    }

                    cargar();
                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnModificarMC_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAdministrador.Text))
                {
                    MessageBox.Show("El campo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAdministrador.Focus();
                }
                else
                {
                    if (tipo)
                    {
                        MarcaNegocio negocioM = new MarcaNegocio();
                        Marca marca = new Marca();

                        marca = (Marca)dgvMarcaCategoria.CurrentRow.DataBoundItem;
                        marca.Descripcion = txtAdministrador.Text;

                        negocioM.modificar(marca);
                        txtAdministrador.Text = "";
                        MessageBox.Show("¡Marca Modificada con Exito!");
                        cargar();

                    }
                    else
                    {
                        CategoriaNegocio negocioC = new CategoriaNegocio();
                        Categoria categoria = new Categoria();

                        categoria = (Categoria)dgvMarcaCategoria.CurrentRow.DataBoundItem;
                        categoria.Descripcion = txtAdministrador.Text;

                        negocioC.modificar(categoria);
                        txtAdministrador.Text = "";
                        MessageBox.Show("¡Categoria Modificada con Exito!");
                        cargar();

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminarMC_Click(object sender, EventArgs e)
        {
            {
                if (tipo)
                {
                    MarcaNegocio negocioM = new MarcaNegocio();
                    Marca marca = new Marca();
                    try
                    {
                        if (dgvMarcaCategoria.CurrentRow != null)
                        {
                            DialogResult respuesta = MessageBox.Show("¿Desea eliminar la marca seleccionada?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (respuesta == DialogResult.Yes)
                            {
                                marca = (Marca)dgvMarcaCategoria.CurrentRow.DataBoundItem;
                                negocioM.eliminar(marca.Id);
                                cargar();

                                btnEliminarMC.Enabled = dgvMarcaCategoria.Rows.Count > 0;
                            }
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                else
                {
                    CategoriaNegocio negocioC = new CategoriaNegocio();
                    Categoria categoria = new Categoria();
                    try
                    {
                        if (dgvMarcaCategoria.CurrentRow != null)
                        {
                            DialogResult respuesta = MessageBox.Show("¿Desea eliminar la categoría seleccionada?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (respuesta == DialogResult.Yes)
                            {
                                categoria = (Categoria)dgvMarcaCategoria.CurrentRow.DataBoundItem;
                                negocioC.eliminar(categoria.Id);
                                cargar();

                                btnEliminarMC.Enabled = dgvMarcaCategoria.Rows.Count > 0;
                            }
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }

        }

        private void txtBusquedaRapidaMC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                if (tipo)
                {
                    MarcaNegocio negocioM = new MarcaNegocio();
                    List<Marca> listaMarca = negocioM.listar();
                    List<Marca> listaFiltrada;
                    string filtro = txtBusquedaRapidaMC.Text;
                    if (filtro.Length >= 3)
                    {
                        listaFiltrada = listaMarca.FindAll(x => x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                    }
                    else
                    {
                        listaFiltrada = listaMarca;
                    }

                    dgvMarcaCategoria.DataSource = null;
                    dgvMarcaCategoria.DataSource = listaFiltrada;
                    dgvMarcaCategoria.Columns["Id"].Visible = false;


                }
                else
                {
                    CategoriaNegocio negocioC = new CategoriaNegocio();
                    List<Categoria> listaCategoria = negocioC.listar();
                    List<Categoria> listaFiltrada;
                    string filtro = txtBusquedaRapidaMC.Text;
                    if (filtro.Length >= 3)
                    {
                        listaFiltrada = listaCategoria.FindAll(x => x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                    }
                    else
                    {
                        listaFiltrada = listaCategoria;
                    }

                    dgvMarcaCategoria.DataSource = null;
                    dgvMarcaCategoria.DataSource = listaFiltrada;
                    //ocultarColumnas();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
