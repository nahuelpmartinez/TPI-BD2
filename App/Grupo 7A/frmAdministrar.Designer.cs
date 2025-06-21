namespace Grupo_7A
{
    partial class frmAdministrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMarcaCategoria = new System.Windows.Forms.DataGridView();
            this.btnAgregarMC = new System.Windows.Forms.Button();
            this.btnModificarMC = new System.Windows.Forms.Button();
            this.btnEliminarMC = new System.Windows.Forms.Button();
            this.gbxBusquedaRapidaMC = new System.Windows.Forms.GroupBox();
            this.txtBusquedaRapidaMC = new System.Windows.Forms.TextBox();
            this.txtAdministrador = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcaCategoria)).BeginInit();
            this.gbxBusquedaRapidaMC.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMarcaCategoria
            // 
            this.dgvMarcaCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcaCategoria.Location = new System.Drawing.Point(24, 103);
            this.dgvMarcaCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMarcaCategoria.Name = "dgvMarcaCategoria";
            this.dgvMarcaCategoria.RowHeadersWidth = 51;
            this.dgvMarcaCategoria.RowTemplate.Height = 24;
            this.dgvMarcaCategoria.Size = new System.Drawing.Size(315, 210);
            this.dgvMarcaCategoria.TabIndex = 0;
            // 
            // btnAgregarMC
            // 
            this.btnAgregarMC.Location = new System.Drawing.Point(24, 378);
            this.btnAgregarMC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarMC.Name = "btnAgregarMC";
            this.btnAgregarMC.Size = new System.Drawing.Size(96, 33);
            this.btnAgregarMC.TabIndex = 1;
            this.btnAgregarMC.Text = "Agregar";
            this.btnAgregarMC.UseVisualStyleBackColor = true;
            this.btnAgregarMC.Click += new System.EventHandler(this.btnAgregarMC_Click);
            // 
            // btnModificarMC
            // 
            this.btnModificarMC.Location = new System.Drawing.Point(133, 378);
            this.btnModificarMC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarMC.Name = "btnModificarMC";
            this.btnModificarMC.Size = new System.Drawing.Size(96, 33);
            this.btnModificarMC.TabIndex = 2;
            this.btnModificarMC.Text = "Modificar";
            this.btnModificarMC.UseVisualStyleBackColor = true;
            this.btnModificarMC.Click += new System.EventHandler(this.btnModificarMC_Click);
            // 
            // btnEliminarMC
            // 
            this.btnEliminarMC.Location = new System.Drawing.Point(243, 378);
            this.btnEliminarMC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarMC.Name = "btnEliminarMC";
            this.btnEliminarMC.Size = new System.Drawing.Size(96, 33);
            this.btnEliminarMC.TabIndex = 3;
            this.btnEliminarMC.Text = "Eliminar";
            this.btnEliminarMC.UseVisualStyleBackColor = true;
            this.btnEliminarMC.Click += new System.EventHandler(this.btnEliminarMC_Click);
            // 
            // gbxBusquedaRapidaMC
            // 
            this.gbxBusquedaRapidaMC.Controls.Add(this.txtBusquedaRapidaMC);
            this.gbxBusquedaRapidaMC.Location = new System.Drawing.Point(24, 12);
            this.gbxBusquedaRapidaMC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxBusquedaRapidaMC.Name = "gbxBusquedaRapidaMC";
            this.gbxBusquedaRapidaMC.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxBusquedaRapidaMC.Size = new System.Drawing.Size(315, 76);
            this.gbxBusquedaRapidaMC.TabIndex = 12;
            this.gbxBusquedaRapidaMC.TabStop = false;
            this.gbxBusquedaRapidaMC.Text = "Busqueda Rapida";
            // 
            // txtBusquedaRapidaMC
            // 
            this.txtBusquedaRapidaMC.Location = new System.Drawing.Point(19, 31);
            this.txtBusquedaRapidaMC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBusquedaRapidaMC.Name = "txtBusquedaRapidaMC";
            this.txtBusquedaRapidaMC.Size = new System.Drawing.Size(263, 22);
            this.txtBusquedaRapidaMC.TabIndex = 0;
            this.txtBusquedaRapidaMC.TextChanged += new System.EventHandler(this.txtBusquedaRapidaMC_TextChanged);
            // 
            // txtAdministrador
            // 
            this.txtAdministrador.Location = new System.Drawing.Point(24, 335);
            this.txtAdministrador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdministrador.Name = "txtAdministrador";
            this.txtAdministrador.Size = new System.Drawing.Size(205, 22);
            this.txtAdministrador.TabIndex = 0;
            // 
            // frmAdministrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 447);
            this.Controls.Add(this.txtAdministrador);
            this.Controls.Add(this.gbxBusquedaRapidaMC);
            this.Controls.Add(this.btnEliminarMC);
            this.Controls.Add(this.btnModificarMC);
            this.Controls.Add(this.btnAgregarMC);
            this.Controls.Add(this.dgvMarcaCategoria);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAdministrar";
            this.Text = "Administrar";
            this.Load += new System.EventHandler(this.frmAdministrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcaCategoria)).EndInit();
            this.gbxBusquedaRapidaMC.ResumeLayout(false);
            this.gbxBusquedaRapidaMC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarcaCategoria;
        private System.Windows.Forms.Button btnAgregarMC;
        private System.Windows.Forms.Button btnModificarMC;
        private System.Windows.Forms.Button btnEliminarMC;
        private System.Windows.Forms.GroupBox gbxBusquedaRapidaMC;
        private System.Windows.Forms.TextBox txtBusquedaRapidaMC;
        private System.Windows.Forms.TextBox txtAdministrador;
    }
}