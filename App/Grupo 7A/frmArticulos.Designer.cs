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
            this.gbxBusquedaRapida = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slblVacio = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblFechaHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.gbAdministrar.SuspendLayout();
            this.gbxBusquedaRapida.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBusquedaRapida
            // 
            this.txtBusquedaRapida.Location = new System.Drawing.Point(23, 33);
            this.txtBusquedaRapida.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusquedaRapida.Name = "txtBusquedaRapida";
            this.txtBusquedaRapida.Size = new System.Drawing.Size(233, 22);
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
            this.gbFiltros.Location = new System.Drawing.Point(20, 410);
            this.gbFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Padding = new System.Windows.Forms.Padding(4);
            this.gbFiltros.Size = new System.Drawing.Size(401, 185);
            this.gbFiltros.TabIndex = 3;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtrar por:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(155, 33);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(52, 16);
            this.lblCriterio.TabIndex = 13;
            this.lblCriterio.Text = "Criterio:";
            // 
            // rbtnCategoria
            // 
            this.rbtnCategoria.AutoSize = true;
            this.rbtnCategoria.Location = new System.Drawing.Point(23, 142);
            this.rbtnCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnCategoria.Name = "rbtnCategoria";
            this.rbtnCategoria.Size = new System.Drawing.Size(87, 20);
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
            this.cbxCriterio.Location = new System.Drawing.Point(157, 55);
            this.cbxCriterio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(217, 24);
            this.cbxCriterio.TabIndex = 4;
            // 
            // rbtnMarca
            // 
            this.rbtnMarca.AutoSize = true;
            this.rbtnMarca.Location = new System.Drawing.Point(23, 105);
            this.rbtnMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnMarca.Name = "rbtnMarca";
            this.rbtnMarca.Size = new System.Drawing.Size(66, 20);
            this.rbtnMarca.TabIndex = 2;
            this.rbtnMarca.TabStop = true;
            this.rbtnMarca.Text = "Marca";
            this.rbtnMarca.UseVisualStyleBackColor = true;
            this.rbtnMarca.CheckedChanged += new System.EventHandler(this.rbtnMarca_CheckedChanged);
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(157, 100);
            this.txtFiltroAvanzado.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(217, 22);
            this.txtFiltroAvanzado.TabIndex = 5;
            // 
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Location = new System.Drawing.Point(23, 69);
            this.rbtnNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(77, 20);
            this.rbtnNombre.TabIndex = 1;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Nombre";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            this.rbtnNombre.CheckedChanged += new System.EventHandler(this.rbtnNombre_CheckedChanged);
            // 
            // rbtnCodigo
            // 
            this.rbtnCodigo.AutoSize = true;
            this.rbtnCodigo.Location = new System.Drawing.Point(23, 33);
            this.rbtnCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnCodigo.Name = "rbtnCodigo";
            this.rbtnCodigo.Size = new System.Drawing.Size(72, 20);
            this.rbtnCodigo.TabIndex = 0;
            this.rbtnCodigo.TabStop = true;
            this.rbtnCodigo.Text = "Código";
            this.rbtnCodigo.UseVisualStyleBackColor = true;
            this.rbtnCodigo.CheckedChanged += new System.EventHandler(this.rbtnCodigo_CheckedChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(276, 140);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 28);
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
            this.dgvArticulos.Location = new System.Drawing.Point(13, 14);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4);
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
            this.dgvArticulos.Size = new System.Drawing.Size(1013, 322);
            this.dgvArticulos.TabIndex = 5;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(20, 354);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 28);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminarFisico
            // 
            this.btnEliminarFisico.Location = new System.Drawing.Point(603, 354);
            this.btnEliminarFisico.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(112, 28);
            this.btnEliminarFisico.TabIndex = 2;
            this.btnEliminarFisico.Text = "Eliminar de BD";
            this.btnEliminarFisico.UseVisualStyleBackColor = true;
            this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminarFisico_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(139, 354);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(112, 28);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAdmMarcas
            // 
            this.btnAdmMarcas.Location = new System.Drawing.Point(21, 28);
            this.btnAdmMarcas.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmMarcas.Name = "btnAdmMarcas";
            this.btnAdmMarcas.Size = new System.Drawing.Size(104, 27);
            this.btnAdmMarcas.TabIndex = 0;
            this.btnAdmMarcas.Text = "Marcas";
            this.btnAdmMarcas.UseVisualStyleBackColor = true;
            this.btnAdmMarcas.Click += new System.EventHandler(this.btnAdmMarcas_Click);
            // 
            // btnAdmCategorias
            // 
            this.btnAdmCategorias.Location = new System.Drawing.Point(148, 28);
            this.btnAdmCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmCategorias.Name = "btnAdmCategorias";
            this.btnAdmCategorias.Size = new System.Drawing.Size(111, 27);
            this.btnAdmCategorias.TabIndex = 1;
            this.btnAdmCategorias.Text = "Categorías";
            this.btnAdmCategorias.UseVisualStyleBackColor = true;
            this.btnAdmCategorias.Click += new System.EventHandler(this.btnAdmCategorias_Click);
            // 
            // gbAdministrar
            // 
            this.gbAdministrar.Controls.Add(this.btnAdmMarcas);
            this.gbAdministrar.Controls.Add(this.btnAdmCategorias);
            this.gbAdministrar.Location = new System.Drawing.Point(437, 518);
            this.gbAdministrar.Margin = new System.Windows.Forms.Padding(4);
            this.gbAdministrar.Name = "gbAdministrar";
            this.gbAdministrar.Padding = new System.Windows.Forms.Padding(4);
            this.gbAdministrar.Size = new System.Drawing.Size(277, 76);
            this.gbAdministrar.TabIndex = 5;
            this.gbAdministrar.TabStop = false;
            this.gbAdministrar.Text = "Administrar:";
            // 
            // gbxBusquedaRapida
            // 
            this.gbxBusquedaRapida.Controls.Add(this.txtBusquedaRapida);
            this.gbxBusquedaRapida.Location = new System.Drawing.Point(437, 410);
            this.gbxBusquedaRapida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxBusquedaRapida.Name = "gbxBusquedaRapida";
            this.gbxBusquedaRapida.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxBusquedaRapida.Size = new System.Drawing.Size(279, 76);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 605);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1059, 24);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // slblVacio
            // 
            this.slblVacio.Name = "slblVacio";
            this.slblVacio.Size = new System.Drawing.Size(1045, 16);
            this.slblVacio.Spring = true;
            // 
            // slblFechaHora
            // 
            this.slblFechaHora.Name = "slblFechaHora";
            this.slblFechaHora.Size = new System.Drawing.Size(0, 16);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 629);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbxBusquedaRapida);
            this.Controls.Add(this.gbAdministrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.gbFiltros);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1077, 676);
            this.MinimumSize = new System.Drawing.Size(1077, 676);
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
    }
}

