namespace TPWinForm_equipo_20B
{
    partial class frmAdministrarCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrarCategorias));
            this.txtAgregarCategoria = new System.Windows.Forms.TextBox();
            this.labelAdmCategorias = new System.Windows.Forms.Label();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.btnSalirCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAgregarCategoria
            // 
            this.txtAgregarCategoria.Location = new System.Drawing.Point(99, 332);
            this.txtAgregarCategoria.Name = "txtAgregarCategoria";
            this.txtAgregarCategoria.Size = new System.Drawing.Size(254, 20);
            this.txtAgregarCategoria.TabIndex = 3;
            // 
            // labelAdmCategorias
            // 
            this.labelAdmCategorias.AutoSize = true;
            this.labelAdmCategorias.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmCategorias.Location = new System.Drawing.Point(95, 308);
            this.labelAdmCategorias.Name = "labelAdmCategorias";
            this.labelAdmCategorias.Size = new System.Drawing.Size(262, 21);
            this.labelAdmCategorias.TabIndex = 12;
            this.labelAdmCategorias.Text = "Ingrese la Categoría que desea agregar:";
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModificarCategoria.FlatAppearance.BorderSize = 0;
            this.btnModificarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCategoria.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnModificarCategoria.Location = new System.Drawing.Point(129, 242);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(81, 23);
            this.btnModificarCategoria.TabIndex = 2;
            this.btnModificarCategoria.Text = "Modificar";
            this.btnModificarCategoria.UseVisualStyleBackColor = false;
            this.btnModificarCategoria.Click += new System.EventHandler(this.btnModificarCategoria_Click_1);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEliminarCategoria.FlatAppearance.BorderSize = 0;
            this.btnEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCategoria.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(236, 242);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(81, 23);
            this.btnEliminarCategoria.TabIndex = 1;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = false;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click_1);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarCategoria.FlatAppearance.BorderSize = 0;
            this.btnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(129, 358);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(81, 23);
            this.btnAgregarCategoria.TabIndex = 4;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click_1);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategorias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategorias.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCategorias.Location = new System.Drawing.Point(155, 34);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(144, 187);
            this.dgvCategorias.TabIndex = 0;
            // 
            // btnSalirCategoria
            // 
            this.btnSalirCategoria.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSalirCategoria.FlatAppearance.BorderSize = 0;
            this.btnSalirCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirCategoria.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirCategoria.ForeColor = System.Drawing.Color.White;
            this.btnSalirCategoria.Location = new System.Drawing.Point(236, 358);
            this.btnSalirCategoria.Name = "btnSalirCategoria";
            this.btnSalirCategoria.Size = new System.Drawing.Size(81, 23);
            this.btnSalirCategoria.TabIndex = 13;
            this.btnSalirCategoria.Text = "Salir";
            this.btnSalirCategoria.UseVisualStyleBackColor = false;
            this.btnSalirCategoria.Click += new System.EventHandler(this.btnSalirCategoria_Click);
            // 
            // frmAdministrarCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 415);
            this.Controls.Add(this.btnSalirCategoria);
            this.Controls.Add(this.txtAgregarCategoria);
            this.Controls.Add(this.labelAdmCategorias);
            this.Controls.Add(this.btnModificarCategoria);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.dgvCategorias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(469, 454);
            this.MinimumSize = new System.Drawing.Size(469, 454);
            this.Name = "frmAdministrarCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Categorías";
            this.Load += new System.EventHandler(this.frmAdministrarCategorias_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAgregarCategoria;
        private System.Windows.Forms.Label labelAdmCategorias;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button btnSalirCategoria;
    }
}