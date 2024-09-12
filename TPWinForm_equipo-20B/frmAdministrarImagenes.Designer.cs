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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrarImagenes));
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.labelUrlImagen = new System.Windows.Forms.Label();
            this.btnEliminarImagen = new System.Windows.Forms.Button();
            this.dgvImagenes = new System.Windows.Forms.DataGridView();
            this.pbxImagenAdmin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarImagen.FlatAppearance.BorderSize = 0;
            this.btnAgregarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarImagen.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarImagen.ForeColor = System.Drawing.Color.White;
            this.btnAgregarImagen.Location = new System.Drawing.Point(298, 296);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(81, 23);
            this.btnAgregarImagen.TabIndex = 0;
            this.btnAgregarImagen.Text = "Agregar";
            this.btnAgregarImagen.UseVisualStyleBackColor = false;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(92, 270);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(468, 20);
            this.txtUrlImagen.TabIndex = 1;
            // 
            // labelUrlImagen
            // 
            this.labelUrlImagen.AutoSize = true;
            this.labelUrlImagen.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUrlImagen.Location = new System.Drawing.Point(138, 246);
            this.labelUrlImagen.Name = "labelUrlImagen";
            this.labelUrlImagen.Size = new System.Drawing.Size(382, 21);
            this.labelUrlImagen.TabIndex = 2;
            this.labelUrlImagen.Text = "Ingrese la URL de la imagen que desea agregar del articulo\r\n";
            // 
            // btnEliminarImagen
            // 
            this.btnEliminarImagen.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEliminarImagen.FlatAppearance.BorderSize = 0;
            this.btnEliminarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarImagen.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarImagen.ForeColor = System.Drawing.Color.White;
            this.btnEliminarImagen.Location = new System.Drawing.Point(546, 186);
            this.btnEliminarImagen.Name = "btnEliminarImagen";
            this.btnEliminarImagen.Size = new System.Drawing.Size(81, 23);
            this.btnEliminarImagen.TabIndex = 3;
            this.btnEliminarImagen.Text = "Eliminar";
            this.btnEliminarImagen.UseVisualStyleBackColor = false;
            this.btnEliminarImagen.Click += new System.EventHandler(this.btnEliminarImagen_Click);
            // 
            // dgvImagenes
            // 
            this.dgvImagenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvImagenes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvImagenes.BackgroundColor = System.Drawing.Color.White;
            this.dgvImagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvImagenes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvImagenes.Location = new System.Drawing.Point(16, 30);
            this.dgvImagenes.Name = "dgvImagenes";
            this.dgvImagenes.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImagenes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvImagenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImagenes.Size = new System.Drawing.Size(468, 150);
            this.dgvImagenes.TabIndex = 4;
            this.dgvImagenes.SelectionChanged += new System.EventHandler(this.dgvImagenes_SelectionChanged);
            // 
            // pbxImagenAdmin
            // 
            this.pbxImagenAdmin.Location = new System.Drawing.Point(502, 30);
            this.pbxImagenAdmin.Name = "pbxImagenAdmin";
            this.pbxImagenAdmin.Size = new System.Drawing.Size(170, 150);
            this.pbxImagenAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenAdmin.TabIndex = 5;
            this.pbxImagenAdmin.TabStop = false;
            // 
            // frmAdministrarImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 333);
            this.Controls.Add(this.pbxImagenAdmin);
            this.Controls.Add(this.dgvImagenes);
            this.Controls.Add(this.btnEliminarImagen);
            this.Controls.Add(this.labelUrlImagen);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.btnAgregarImagen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdministrarImagenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Imagenes";
            this.Load += new System.EventHandler(this.frmAdministrarImagenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Label labelUrlImagen;
        private System.Windows.Forms.Button btnEliminarImagen;
        private System.Windows.Forms.DataGridView dgvImagenes;
        private System.Windows.Forms.PictureBox pbxImagenAdmin;
    }
}