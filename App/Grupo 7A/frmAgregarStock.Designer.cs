namespace Grupo_7A
{
    partial class frmAgregarStock
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
            this.gbCargarArticulo = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxSucursal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombreArticulo = new System.Windows.Forms.Label();
            this.txtCodigoArticulo = new System.Windows.Forms.TextBox();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbCargarArticulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCargarArticulo
            // 
            this.gbCargarArticulo.Controls.Add(this.txtCantidad);
            this.gbCargarArticulo.Controls.Add(this.label3);
            this.gbCargarArticulo.Controls.Add(this.cbxSucursal);
            this.gbCargarArticulo.Controls.Add(this.label1);
            this.gbCargarArticulo.Controls.Add(this.lblDireccion);
            this.gbCargarArticulo.Controls.Add(this.lblNombreArticulo);
            this.gbCargarArticulo.Controls.Add(this.txtCodigoArticulo);
            this.gbCargarArticulo.Controls.Add(this.txtNombreArticulo);
            this.gbCargarArticulo.Location = new System.Drawing.Point(249, 88);
            this.gbCargarArticulo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCargarArticulo.Name = "gbCargarArticulo";
            this.gbCargarArticulo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCargarArticulo.Size = new System.Drawing.Size(358, 347);
            this.gbCargarArticulo.TabIndex = 27;
            this.gbCargarArticulo.TabStop = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(43, 284);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(6);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(240, 31);
            this.txtCantidad.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 253);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad";
            // 
            // cbxSucursal
            // 
            this.cbxSucursal.FormattingEnabled = true;
            this.cbxSucursal.Location = new System.Drawing.Point(39, 202);
            this.cbxSucursal.Name = "cbxSucursal";
            this.cbxSucursal.Size = new System.Drawing.Size(240, 33);
            this.cbxSucursal.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sucursal:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(34, 27);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(164, 25);
            this.lblDireccion.TabIndex = 0;
            this.lblDireccion.Text = "Código Articulo:";
            // 
            // lblNombreArticulo
            // 
            this.lblNombreArticulo.AutoSize = true;
            this.lblNombreArticulo.Location = new System.Drawing.Point(34, 95);
            this.lblNombreArticulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombreArticulo.Name = "lblNombreArticulo";
            this.lblNombreArticulo.Size = new System.Drawing.Size(171, 25);
            this.lblNombreArticulo.TabIndex = 1;
            this.lblNombreArticulo.Text = "Nombre Articulo:";
            // 
            // txtCodigoArticulo
            // 
            this.txtCodigoArticulo.Location = new System.Drawing.Point(39, 58);
            this.txtCodigoArticulo.Margin = new System.Windows.Forms.Padding(6);
            this.txtCodigoArticulo.Name = "txtCodigoArticulo";
            this.txtCodigoArticulo.Size = new System.Drawing.Size(240, 31);
            this.txtCodigoArticulo.TabIndex = 1;
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.Location = new System.Drawing.Point(39, 131);
            this.txtNombreArticulo.Margin = new System.Windows.Forms.Padding(6);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.Size = new System.Drawing.Size(240, 31);
            this.txtNombreArticulo.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(457, 456);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 44);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(249, 456);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(6);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 44);
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmAgregarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 673);
            this.Controls.Add(this.gbCargarArticulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frmAgregarStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarStock";
            this.Load += new System.EventHandler(this.frmAgregarStock_Load);
            this.gbCargarArticulo.ResumeLayout(false);
            this.gbCargarArticulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCargarArticulo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxSucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombreArticulo;
        private System.Windows.Forms.TextBox txtCodigoArticulo;
        private System.Windows.Forms.TextBox txtNombreArticulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}