namespace TPWinForm_equipo_20B
{
    partial class frmDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalle));
            this.txtPrecioDetalle = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtNombreDetalle = new System.Windows.Forms.TextBox();
            this.txtDescripcionDetalle = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtMarcaDetalle = new System.Windows.Forms.TextBox();
            this.txtCategoriaDetalle = new System.Windows.Forms.TextBox();
            this.pbxImagenDetalle = new System.Windows.Forms.PictureBox();
            this.btnCerrarDetalle = new System.Windows.Forms.Button();
            this.btnAnteriorDetalle = new System.Windows.Forms.Button();
            this.btnSiguienteDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrecioDetalle
            // 
            this.txtPrecioDetalle.Location = new System.Drawing.Point(121, 186);
            this.txtPrecioDetalle.Name = "txtPrecioDetalle";
            this.txtPrecioDetalle.ReadOnly = true;
            this.txtPrecioDetalle.Size = new System.Drawing.Size(229, 20);
            this.txtPrecioDetalle.TabIndex = 4;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPrecio.Location = new System.Drawing.Point(23, 186);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 21);
            this.lblPrecio.TabIndex = 24;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCategoria.Location = new System.Drawing.Point(23, 150);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(77, 21);
            this.lblCategoria.TabIndex = 23;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMarca.Location = new System.Drawing.Point(23, 114);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(53, 21);
            this.lblMarca.TabIndex = 22;
            this.lblMarca.Text = "Marca";
            // 
            // txtNombreDetalle
            // 
            this.txtNombreDetalle.Location = new System.Drawing.Point(120, 76);
            this.txtNombreDetalle.Name = "txtNombreDetalle";
            this.txtNombreDetalle.ReadOnly = true;
            this.txtNombreDetalle.Size = new System.Drawing.Size(230, 20);
            this.txtNombreDetalle.TabIndex = 1;
            // 
            // txtDescripcionDetalle
            // 
            this.txtDescripcionDetalle.Location = new System.Drawing.Point(27, 268);
            this.txtDescripcionDetalle.Multiline = true;
            this.txtDescripcionDetalle.Name = "txtDescripcionDetalle";
            this.txtDescripcionDetalle.ReadOnly = true;
            this.txtDescripcionDetalle.Size = new System.Drawing.Size(323, 99);
            this.txtDescripcionDetalle.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(121, 41);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(229, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDescripcion.Location = new System.Drawing.Point(23, 235);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(92, 20);
            this.lblDescripcion.TabIndex = 18;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNombre.Location = new System.Drawing.Point(23, 76);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 21);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCodigo.Location = new System.Drawing.Point(23, 40);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(60, 21);
            this.lblCodigo.TabIndex = 16;
            this.lblCodigo.Text = "Código";
            // 
            // txtMarcaDetalle
            // 
            this.txtMarcaDetalle.Location = new System.Drawing.Point(120, 113);
            this.txtMarcaDetalle.Name = "txtMarcaDetalle";
            this.txtMarcaDetalle.ReadOnly = true;
            this.txtMarcaDetalle.Size = new System.Drawing.Size(230, 20);
            this.txtMarcaDetalle.TabIndex = 2;
            // 
            // txtCategoriaDetalle
            // 
            this.txtCategoriaDetalle.Location = new System.Drawing.Point(120, 150);
            this.txtCategoriaDetalle.Name = "txtCategoriaDetalle";
            this.txtCategoriaDetalle.ReadOnly = true;
            this.txtCategoriaDetalle.Size = new System.Drawing.Size(230, 20);
            this.txtCategoriaDetalle.TabIndex = 3;
            // 
            // pbxImagenDetalle
            // 
            this.pbxImagenDetalle.Location = new System.Drawing.Point(484, 51);
            this.pbxImagenDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxImagenDetalle.Name = "pbxImagenDetalle";
            this.pbxImagenDetalle.Size = new System.Drawing.Size(284, 288);
            this.pbxImagenDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenDetalle.TabIndex = 28;
            this.pbxImagenDetalle.TabStop = false;
            // 
            // btnCerrarDetalle
            // 
            this.btnCerrarDetalle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCerrarDetalle.FlatAppearance.BorderSize = 0;
            this.btnCerrarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarDetalle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarDetalle.ForeColor = System.Drawing.Color.White;
            this.btnCerrarDetalle.Location = new System.Drawing.Point(710, 390);
            this.btnCerrarDetalle.Name = "btnCerrarDetalle";
            this.btnCerrarDetalle.Size = new System.Drawing.Size(117, 34);
            this.btnCerrarDetalle.TabIndex = 8;
            this.btnCerrarDetalle.Text = "Aceptar";
            this.btnCerrarDetalle.UseVisualStyleBackColor = false;
            this.btnCerrarDetalle.Click += new System.EventHandler(this.btnCerrarDetalle_Click);
            // 
            // btnAnteriorDetalle
            // 
            this.btnAnteriorDetalle.BackColor = System.Drawing.Color.Transparent;
            this.btnAnteriorDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnteriorDetalle.FlatAppearance.BorderSize = 0;
            this.btnAnteriorDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnteriorDetalle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAnteriorDetalle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAnteriorDetalle.Location = new System.Drawing.Point(437, 174);
            this.btnAnteriorDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnteriorDetalle.Name = "btnAnteriorDetalle";
            this.btnAnteriorDetalle.Size = new System.Drawing.Size(39, 37);
            this.btnAnteriorDetalle.TabIndex = 6;
            this.btnAnteriorDetalle.Text = "◀";
            this.btnAnteriorDetalle.UseCompatibleTextRendering = true;
            this.btnAnteriorDetalle.UseVisualStyleBackColor = false;
            this.btnAnteriorDetalle.Click += new System.EventHandler(this.btnAnteriorDetalle_Click);
            // 
            // btnSiguienteDetalle
            // 
            this.btnSiguienteDetalle.BackColor = System.Drawing.Color.Transparent;
            this.btnSiguienteDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguienteDetalle.FlatAppearance.BorderSize = 0;
            this.btnSiguienteDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguienteDetalle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSiguienteDetalle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSiguienteDetalle.Location = new System.Drawing.Point(776, 174);
            this.btnSiguienteDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSiguienteDetalle.Name = "btnSiguienteDetalle";
            this.btnSiguienteDetalle.Size = new System.Drawing.Size(39, 37);
            this.btnSiguienteDetalle.TabIndex = 7;
            this.btnSiguienteDetalle.Text = "▶";
            this.btnSiguienteDetalle.UseCompatibleTextRendering = true;
            this.btnSiguienteDetalle.UseVisualStyleBackColor = false;
            this.btnSiguienteDetalle.Click += new System.EventHandler(this.btnSiguienteDetalle_Click);
            // 
            // frmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.btnAnteriorDetalle);
            this.Controls.Add(this.btnSiguienteDetalle);
            this.Controls.Add(this.btnCerrarDetalle);
            this.Controls.Add(this.pbxImagenDetalle);
            this.Controls.Add(this.txtCategoriaDetalle);
            this.Controls.Add(this.txtMarcaDetalle);
            this.Controls.Add(this.txtPrecioDetalle);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtNombreDetalle);
            this.Controls.Add(this.txtDescripcionDetalle);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(871, 489);
            this.MinimumSize = new System.Drawing.Size(871, 489);
            this.Name = "frmDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle del Articulo";
            this.Load += new System.EventHandler(this.frmDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPrecioDetalle;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtNombreDetalle;
        private System.Windows.Forms.TextBox txtDescripcionDetalle;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtMarcaDetalle;
        private System.Windows.Forms.TextBox txtCategoriaDetalle;
        private System.Windows.Forms.PictureBox pbxImagenDetalle;
        private System.Windows.Forms.Button btnCerrarDetalle;
        private System.Windows.Forms.Button btnAnteriorDetalle;
        private System.Windows.Forms.Button btnSiguienteDetalle;
    }
}