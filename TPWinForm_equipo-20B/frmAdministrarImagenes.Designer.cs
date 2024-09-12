namespace TPWinForm_equipo_20B
{
    partial class frmAdministrarImagenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrarImagenes));
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.labelUrlImagen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarImagen.FlatAppearance.BorderSize = 0;
            this.btnAgregarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarImagen.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarImagen.ForeColor = System.Drawing.Color.White;
            this.btnAgregarImagen.Location = new System.Drawing.Point(207, 122);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(81, 23);
            this.btnAgregarImagen.TabIndex = 0;
            this.btnAgregarImagen.Text = "Agregar";
            this.btnAgregarImagen.UseVisualStyleBackColor = false;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(16, 72);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(468, 20);
            this.txtUrlImagen.TabIndex = 1;
            // 
            // labelUrlImagen
            // 
            this.labelUrlImagen.AutoSize = true;
            this.labelUrlImagen.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUrlImagen.Location = new System.Drawing.Point(49, 37);
            this.labelUrlImagen.Name = "labelUrlImagen";
            this.labelUrlImagen.Size = new System.Drawing.Size(407, 21);
            this.labelUrlImagen.TabIndex = 2;
            this.labelUrlImagen.Text = "Ingrese la URL de la imagen del artículo del cual desea agregar";
            // 
            // frmAdministrarImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 174);
            this.Controls.Add(this.labelUrlImagen);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.btnAgregarImagen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdministrarImagenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Imagen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Label labelUrlImagen;
    }
}