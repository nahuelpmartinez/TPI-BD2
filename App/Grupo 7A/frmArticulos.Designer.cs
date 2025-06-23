namespace Grupo_7A
{
    partial class frmArticulos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBusquedaRapida = new System.Windows.Forms.TextBox();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.rbtnCategoria = new System.Windows.Forms.RadioButton();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.rbtnMarca = new System.Windows.Forms.RadioButton();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.rbtnNombre = new System.Windows.Forms.RadioButton();
            this.rbtnCodigo = new System.Windows.Forms.RadioButton();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminarFisico = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAdmMarcas = new System.Windows.Forms.Button();
            this.btnAdmCategorias = new System.Windows.Forms.Button();
            this.gbAdministrar = new System.Windows.Forms.GroupBox();
            this.btnSucursales = new System.Windows.Forms.Button();
            this.gbxBusquedaRapida = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slblVacio = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblFechaHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMoverStock = new System.Windows.Forms.Button();
            this.btnIngresarStock = new System.Windows.Forms.Button();
            this.btnReducirStock = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStockPorArticulo = new System.Windows.Forms.Button();
            this.btnStockPorSucursal = new System.Windows.Forms.Button();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.gbAdministrar.SuspendLayout();
            this.gbxBusquedaRapida.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBusquedaRapida
            // 
            this.txtBusquedaRapida.Location = new System.Drawing.Point(32, 67);
            this.txtBusquedaRapida.Margin = new System.Windows.Forms.Padding(6);
            this.txtBusquedaRapida.Name = "txtBusquedaRapida";
            this.txtBusquedaRapida.Size = new System.Drawing.Size(348, 31);
            this.txtBusquedaRapida.TabIndex = 0;
            this.txtBusquedaRapida.TextChanged += new System.EventHandler(this.txtBusquedaRapida_TextChanged);
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.lblCriterio);
            this.gbFiltros.Controls.Add(this.rbtnCategoria);
            this.gbFiltros.Controls.Add(this.cbxCriterio);
            this.gbFiltros.Controls.Add(this.rbtnMarca);
            this.gbFiltros.Controls.Add(this.txtFiltroAvanzado);
            this.gbFiltros.Controls.Add(this.rbtnNombre);
            this.gbFiltros.Controls.Add(this.rbtnCodigo);
            this.gbFiltros.Controls.Add(this.btnFiltrar);
            this.gbFiltros.Location = new System.Drawing.Point(30, 620);
            this.gbFiltros.Margin = new System.Windows.Forms.Padding(6);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Padding = new System.Windows.Forms.Padding(6);
            this.gbFiltros.Size = new System.Drawing.Size(602, 297);
            this.gbFiltros.TabIndex = 3;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtrar por:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(232, 52);
            this.lblCriterio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(87, 25);
            this.lblCriterio.TabIndex = 13;
            this.lblCriterio.Text = "Criterio:";
            // 
            // rbtnCategoria
            // 
            this.rbtnCategoria.AutoSize = true;
            this.rbtnCategoria.Location = new System.Drawing.Point(34, 222);
            this.rbtnCategoria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtnCategoria.Name = "rbtnCategoria";
            this.rbtnCategoria.Size = new System.Drawing.Size(136, 29);
            this.rbtnCategoria.TabIndex = 3;
            this.rbtnCategoria.TabStop = true;
            this.rbtnCategoria.Text = "Categoría";
            this.rbtnCategoria.UseVisualStyleBackColor = true;
            this.rbtnCategoria.CheckedChanged += new System.EventHandler(this.rbtnCategoria_CheckedChanged);
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Location = new System.Drawing.Point(236, 86);
            this.cbxCriterio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(324, 33);
            this.cbxCriterio.TabIndex = 4;
            // 
            // rbtnMarca
            // 
            this.rbtnMarca.AutoSize = true;
            this.rbtnMarca.Location = new System.Drawing.Point(34, 164);
            this.rbtnMarca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtnMarca.Name = "rbtnMarca";
            this.rbtnMarca.Size = new System.Drawing.Size(103, 29);
            this.rbtnMarca.TabIndex = 2;
            this.rbtnMarca.TabStop = true;
            this.rbtnMarca.Text = "Marca";
            this.rbtnMarca.UseVisualStyleBackColor = true;
            this.rbtnMarca.CheckedChanged += new System.EventHandler(this.rbtnMarca_CheckedChanged);
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(236, 156);
            this.txtFiltroAvanzado.Margin = new System.Windows.Forms.Padding(6);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(324, 31);
            this.txtFiltroAvanzado.TabIndex = 5;
            // 
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Location = new System.Drawing.Point(34, 108);
            this.rbtnNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(118, 29);
            this.rbtnNombre.TabIndex = 1;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Nombre";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            this.rbtnNombre.CheckedChanged += new System.EventHandler(this.rbtnNombre_CheckedChanged);
            // 
            // rbtnCodigo
            // 
            this.rbtnCodigo.AutoSize = true;
            this.rbtnCodigo.Location = new System.Drawing.Point(34, 52);
            this.rbtnCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtnCodigo.Name = "rbtnCodigo";
            this.rbtnCodigo.Size = new System.Drawing.Size(111, 29);
            this.rbtnCodigo.TabIndex = 0;
            this.rbtnCodigo.TabStop = true;
            this.rbtnCodigo.Text = "Código";
            this.rbtnCodigo.UseVisualStyleBackColor = true;
            this.rbtnCodigo.CheckedChanged += new System.EventHandler(this.rbtnCodigo_CheckedChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(414, 219);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(6);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(150, 44);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria Math", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArticulos.Location = new System.Drawing.Point(20, 22);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(6);
            this.dgvArticulos.Name = "dgvArticulos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.Size = new System.Drawing.Size(1520, 503);
            this.dgvArticulos.TabIndex = 5;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(30, 553);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(168, 44);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminarFisico
            // 
            this.btnEliminarFisico.Location = new System.Drawing.Point(388, 553);
            this.btnEliminarFisico.Margin = new System.Windows.Forms.Padding(6);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(168, 44);
            this.btnEliminarFisico.TabIndex = 2;
            this.btnEliminarFisico.Text = "Eliminar";
            this.btnEliminarFisico.UseVisualStyleBackColor = true;
            this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminarFisico_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(208, 553);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(6);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(168, 44);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAdmMarcas
            // 
            this.btnAdmMarcas.Location = new System.Drawing.Point(32, 44);
            this.btnAdmMarcas.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdmMarcas.Name = "btnAdmMarcas";
            this.btnAdmMarcas.Size = new System.Drawing.Size(156, 42);
            this.btnAdmMarcas.TabIndex = 0;
            this.btnAdmMarcas.Text = "Marcas";
            this.btnAdmMarcas.UseVisualStyleBackColor = true;
            this.btnAdmMarcas.Click += new System.EventHandler(this.btnAdmMarcas_Click);
            // 
            // btnAdmCategorias
            // 
            this.btnAdmCategorias.Location = new System.Drawing.Point(222, 44);
            this.btnAdmCategorias.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdmCategorias.Name = "btnAdmCategorias";
            this.btnAdmCategorias.Size = new System.Drawing.Size(166, 42);
            this.btnAdmCategorias.TabIndex = 1;
            this.btnAdmCategorias.Text = "Categorías";
            this.btnAdmCategorias.UseVisualStyleBackColor = true;
            this.btnAdmCategorias.Click += new System.EventHandler(this.btnAdmCategorias_Click);
            // 
            // gbAdministrar
            // 
            this.gbAdministrar.Controls.Add(this.btnSucursales);
            this.gbAdministrar.Controls.Add(this.btnAdmMarcas);
            this.gbAdministrar.Controls.Add(this.btnAdmCategorias);
            this.gbAdministrar.Location = new System.Drawing.Point(658, 769);
            this.gbAdministrar.Margin = new System.Windows.Forms.Padding(6);
            this.gbAdministrar.Name = "gbAdministrar";
            this.gbAdministrar.Padding = new System.Windows.Forms.Padding(6);
            this.gbAdministrar.Size = new System.Drawing.Size(416, 148);
            this.gbAdministrar.TabIndex = 5;
            this.gbAdministrar.TabStop = false;
            this.gbAdministrar.Text = "Administrar:";
            // 
            // btnSucursales
            // 
            this.btnSucursales.Location = new System.Drawing.Point(32, 98);
            this.btnSucursales.Margin = new System.Windows.Forms.Padding(6);
            this.btnSucursales.Name = "btnSucursales";
            this.btnSucursales.Size = new System.Drawing.Size(156, 42);
            this.btnSucursales.TabIndex = 3;
            this.btnSucursales.Text = "Sucursales";
            this.btnSucursales.UseVisualStyleBackColor = true;
            this.btnSucursales.Click += new System.EventHandler(this.btnSucursales_Click);
            // 
            // gbxBusquedaRapida
            // 
            this.gbxBusquedaRapida.Controls.Add(this.txtBusquedaRapida);
            this.gbxBusquedaRapida.Location = new System.Drawing.Point(656, 620);
            this.gbxBusquedaRapida.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxBusquedaRapida.Name = "gbxBusquedaRapida";
            this.gbxBusquedaRapida.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxBusquedaRapida.Size = new System.Drawing.Size(418, 140);
            this.gbxBusquedaRapida.TabIndex = 11;
            this.gbxBusquedaRapida.TabStop = false;
            this.gbxBusquedaRapida.Text = "Busqueda Rapida";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblVacio,
            this.slblFechaHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 923);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 20, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1576, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // slblVacio
            // 
            this.slblVacio.Name = "slblVacio";
            this.slblVacio.Size = new System.Drawing.Size(1554, 12);
            this.slblVacio.Spring = true;
            // 
            // slblFechaHora
            // 
            this.slblFechaHora.Name = "slblFechaHora";
            this.slblFechaHora.Size = new System.Drawing.Size(0, 12);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMoverStock);
            this.groupBox1.Controls.Add(this.btnIngresarStock);
            this.groupBox1.Controls.Add(this.btnReducirStock);
            this.groupBox1.Location = new System.Drawing.Point(1101, 776);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(416, 141);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock:";
            // 
            // btnMoverStock
            // 
            this.btnMoverStock.Location = new System.Drawing.Point(32, 91);
            this.btnMoverStock.Margin = new System.Windows.Forms.Padding(6);
            this.btnMoverStock.Name = "btnMoverStock";
            this.btnMoverStock.Size = new System.Drawing.Size(166, 42);
            this.btnMoverStock.TabIndex = 2;
            this.btnMoverStock.Text = "Mover";
            this.btnMoverStock.UseVisualStyleBackColor = true;
            this.btnMoverStock.Click += new System.EventHandler(this.btnMoverStock_Click);
            // 
            // btnIngresarStock
            // 
            this.btnIngresarStock.Location = new System.Drawing.Point(32, 37);
            this.btnIngresarStock.Margin = new System.Windows.Forms.Padding(6);
            this.btnIngresarStock.Name = "btnIngresarStock";
            this.btnIngresarStock.Size = new System.Drawing.Size(166, 42);
            this.btnIngresarStock.TabIndex = 0;
            this.btnIngresarStock.Text = "Ingresar";
            this.btnIngresarStock.UseVisualStyleBackColor = true;
            this.btnIngresarStock.Click += new System.EventHandler(this.btnIngresarStock_Click);
            // 
            // btnReducirStock
            // 
            this.btnReducirStock.Location = new System.Drawing.Point(222, 37);
            this.btnReducirStock.Margin = new System.Windows.Forms.Padding(6);
            this.btnReducirStock.Name = "btnReducirStock";
            this.btnReducirStock.Size = new System.Drawing.Size(166, 42);
            this.btnReducirStock.TabIndex = 1;
            this.btnReducirStock.Text = "Reducir";
            this.btnReducirStock.UseVisualStyleBackColor = true;
            this.btnReducirStock.Click += new System.EventHandler(this.btnReducirStock_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStockPorArticulo);
            this.groupBox2.Controls.Add(this.btnStockPorSucursal);
            this.groupBox2.Location = new System.Drawing.Point(1101, 620);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(416, 140);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vistas:";
            // 
            // btnStockPorArticulo
            // 
            this.btnStockPorArticulo.Location = new System.Drawing.Point(32, 83);
            this.btnStockPorArticulo.Margin = new System.Windows.Forms.Padding(6);
            this.btnStockPorArticulo.Name = "btnStockPorArticulo";
            this.btnStockPorArticulo.Size = new System.Drawing.Size(356, 42);
            this.btnStockPorArticulo.TabIndex = 2;
            this.btnStockPorArticulo.Text = "Stock por Articulo";
            this.btnStockPorArticulo.UseVisualStyleBackColor = true;
            this.btnStockPorArticulo.Click += new System.EventHandler(this.btnStockPorArticulo_Click);
            // 
            // btnStockPorSucursal
            // 
            this.btnStockPorSucursal.Location = new System.Drawing.Point(32, 36);
            this.btnStockPorSucursal.Margin = new System.Windows.Forms.Padding(6);
            this.btnStockPorSucursal.Name = "btnStockPorSucursal";
            this.btnStockPorSucursal.Size = new System.Drawing.Size(356, 42);
            this.btnStockPorSucursal.TabIndex = 0;
            this.btnStockPorSucursal.Text = "Stock por Sucursal";
            this.btnStockPorSucursal.UseVisualStyleBackColor = true;
            this.btnStockPorSucursal.Click += new System.EventHandler(this.btnStockPorSucursal_Click);
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 945);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbxBusquedaRapida);
            this.Controls.Add(this.gbAdministrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.gbFiltros);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1602, 1016);
            this.MinimumSize = new System.Drawing.Size(1602, 1016);
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Artículos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.gbAdministrar.ResumeLayout(false);
            this.gbxBusquedaRapida.ResumeLayout(false);
            this.gbxBusquedaRapida.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusquedaRapida;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminarFisico;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAdmMarcas;
        private System.Windows.Forms.Button btnAdmCategorias;
        private System.Windows.Forms.GroupBox gbAdministrar;
        private System.Windows.Forms.GroupBox gbxBusquedaRapida;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.RadioButton rbtnMarca;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.RadioButton rbtnNombre;
        private System.Windows.Forms.RadioButton rbtnCodigo;
        private System.Windows.Forms.RadioButton rbtnCategoria;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel slblVacio;
        private System.Windows.Forms.ToolStripStatusLabel slblFechaHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSucursales;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMoverStock;
        private System.Windows.Forms.Button btnIngresarStock;
        private System.Windows.Forms.Button btnReducirStock;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStockPorArticulo;
        private System.Windows.Forms.Button btnStockPorSucursal;
    }
}

