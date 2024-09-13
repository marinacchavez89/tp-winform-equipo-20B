namespace TPWinForm_equipo_20B
{
    partial class frmModificarCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarCategoria));
            this.btnModificarCategoriaCancelar = new System.Windows.Forms.Button();
            this.btnModificarCategoriaAceptar = new System.Windows.Forms.Button();
            this.txtDescripcionCategoria = new System.Windows.Forms.TextBox();
            this.lblDescripcionCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModificarCategoriaCancelar
            // 
            this.btnModificarCategoriaCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModificarCategoriaCancelar.FlatAppearance.BorderSize = 0;
            this.btnModificarCategoriaCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCategoriaCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCategoriaCancelar.ForeColor = System.Drawing.Color.White;
            this.btnModificarCategoriaCancelar.Location = new System.Drawing.Point(108, 127);
            this.btnModificarCategoriaCancelar.Name = "btnModificarCategoriaCancelar";
            this.btnModificarCategoriaCancelar.Size = new System.Drawing.Size(81, 23);
            this.btnModificarCategoriaCancelar.TabIndex = 1;
            this.btnModificarCategoriaCancelar.Text = "Cancelar";
            this.btnModificarCategoriaCancelar.UseVisualStyleBackColor = false;
            this.btnModificarCategoriaCancelar.Click += new System.EventHandler(this.btnModificarCategoriaCancelar_Click_1);
            // 
            // btnModificarCategoriaAceptar
            // 
            this.btnModificarCategoriaAceptar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModificarCategoriaAceptar.FlatAppearance.BorderSize = 0;
            this.btnModificarCategoriaAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCategoriaAceptar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCategoriaAceptar.ForeColor = System.Drawing.Color.White;
            this.btnModificarCategoriaAceptar.Location = new System.Drawing.Point(214, 127);
            this.btnModificarCategoriaAceptar.Name = "btnModificarCategoriaAceptar";
            this.btnModificarCategoriaAceptar.Size = new System.Drawing.Size(81, 23);
            this.btnModificarCategoriaAceptar.TabIndex = 2;
            this.btnModificarCategoriaAceptar.Text = "Aceptar";
            this.btnModificarCategoriaAceptar.UseVisualStyleBackColor = false;
            this.btnModificarCategoriaAceptar.Click += new System.EventHandler(this.btnModificarCategoriaAceptar_Click_1);
            // 
            // txtDescripcionCategoria
            // 
            this.txtDescripcionCategoria.Location = new System.Drawing.Point(108, 84);
            this.txtDescripcionCategoria.Name = "txtDescripcionCategoria";
            this.txtDescripcionCategoria.Size = new System.Drawing.Size(187, 20);
            this.txtDescripcionCategoria.TabIndex = 0;
            // 
            // lblDescripcionCategoria
            // 
            this.lblDescripcionCategoria.AutoSize = true;
            this.lblDescripcionCategoria.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCategoria.Location = new System.Drawing.Point(36, 87);
            this.lblDescripcionCategoria.Name = "lblDescripcionCategoria";
            this.lblDescripcionCategoria.Size = new System.Drawing.Size(70, 13);
            this.lblDescripcionCategoria.TabIndex = 3;
            this.lblDescripcionCategoria.Text = "Descripción:";
            // 
            // frmModificarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 237);
            this.Controls.Add(this.btnModificarCategoriaCancelar);
            this.Controls.Add(this.btnModificarCategoriaAceptar);
            this.Controls.Add(this.txtDescripcionCategoria);
            this.Controls.Add(this.lblDescripcionCategoria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(386, 276);
            this.MinimumSize = new System.Drawing.Size(386, 276);
            this.Name = "frmModificarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Categoría";
            this.Load += new System.EventHandler(this.frmModificarCategoria_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificarCategoriaCancelar;
        private System.Windows.Forms.Button btnModificarCategoriaAceptar;
        private System.Windows.Forms.TextBox txtDescripcionCategoria;
        private System.Windows.Forms.Label lblDescripcionCategoria;
    }
}