namespace TPWinForm_equipo_20B
{
    partial class frmModificarMarca
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
            this.lblDescripcionMarca = new System.Windows.Forms.Label();
            this.txtDescripcionMarca = new System.Windows.Forms.TextBox();
            this.btnModificarMarcaAceptar = new System.Windows.Forms.Button();
            this.btnModificarMarcaCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescripcionMarca
            // 
            this.lblDescripcionMarca.AutoSize = true;
            this.lblDescripcionMarca.Location = new System.Drawing.Point(84, 76);
            this.lblDescripcionMarca.Name = "lblDescripcionMarca";
            this.lblDescripcionMarca.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcionMarca.TabIndex = 0;
            this.lblDescripcionMarca.Text = "Descripción:";
            // 
            // txtDescripcionMarca
            // 
            this.txtDescripcionMarca.Location = new System.Drawing.Point(156, 73);
            this.txtDescripcionMarca.Name = "txtDescripcionMarca";
            this.txtDescripcionMarca.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionMarca.TabIndex = 0;
            // 
            // btnModificarMarcaAceptar
            // 
            this.btnModificarMarcaAceptar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModificarMarcaAceptar.FlatAppearance.BorderSize = 0;
            this.btnModificarMarcaAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarMarcaAceptar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMarcaAceptar.ForeColor = System.Drawing.Color.White;
            this.btnModificarMarcaAceptar.Location = new System.Drawing.Point(175, 191);
            this.btnModificarMarcaAceptar.Name = "btnModificarMarcaAceptar";
            this.btnModificarMarcaAceptar.Size = new System.Drawing.Size(81, 23);
            this.btnModificarMarcaAceptar.TabIndex = 2;
            this.btnModificarMarcaAceptar.Text = "Aceptar";
            this.btnModificarMarcaAceptar.UseVisualStyleBackColor = false;
            this.btnModificarMarcaAceptar.Click += new System.EventHandler(this.btnModificarMarcaAceptar_Click);
            // 
            // btnModificarMarcaCancelar
            // 
            this.btnModificarMarcaCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModificarMarcaCancelar.FlatAppearance.BorderSize = 0;
            this.btnModificarMarcaCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarMarcaCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMarcaCancelar.ForeColor = System.Drawing.Color.White;
            this.btnModificarMarcaCancelar.Location = new System.Drawing.Point(69, 191);
            this.btnModificarMarcaCancelar.Name = "btnModificarMarcaCancelar";
            this.btnModificarMarcaCancelar.Size = new System.Drawing.Size(81, 23);
            this.btnModificarMarcaCancelar.TabIndex = 1;
            this.btnModificarMarcaCancelar.Text = "Cancelar";
            this.btnModificarMarcaCancelar.UseVisualStyleBackColor = false;
            this.btnModificarMarcaCancelar.Click += new System.EventHandler(this.btnModificarMarcaCancelar_Click);
            // 
            // frmModificarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 237);
            this.Controls.Add(this.btnModificarMarcaCancelar);
            this.Controls.Add(this.btnModificarMarcaAceptar);
            this.Controls.Add(this.txtDescripcionMarca);
            this.Controls.Add(this.lblDescripcionMarca);
            this.Name = "frmModificarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Marca";
            this.Load += new System.EventHandler(this.frmModificarMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcionMarca;
        private System.Windows.Forms.TextBox txtDescripcionMarca;
        private System.Windows.Forms.Button btnModificarMarcaAceptar;
        private System.Windows.Forms.Button btnModificarMarcaCancelar;
    }
}