namespace TPWinForm_equipo_20B
{
    partial class frmAdministrarMarcas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrarMarcas));
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnModificarMarca = new System.Windows.Forms.Button();
            this.labelAdmMarcas = new System.Windows.Forms.Label();
            this.txtAgregarMarca = new System.Windows.Forms.TextBox();
            this.btnSalirMarca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.BackgroundColor = System.Drawing.Color.White;
            this.dgvMarcas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMarcas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarcas.Location = new System.Drawing.Point(161, 31);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.ReadOnly = true;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(144, 187);
            this.dgvMarcas.TabIndex = 0;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarMarca.FlatAppearance.BorderSize = 0;
            this.btnAgregarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMarca.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMarca.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMarca.Location = new System.Drawing.Point(137, 360);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(81, 23);
            this.btnAgregarMarca.TabIndex = 4;
            this.btnAgregarMarca.Text = "Agregar";
            this.btnAgregarMarca.UseVisualStyleBackColor = false;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEliminarMarca.FlatAppearance.BorderSize = 0;
            this.btnEliminarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMarca.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMarca.ForeColor = System.Drawing.Color.White;
            this.btnEliminarMarca.Location = new System.Drawing.Point(241, 234);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(81, 23);
            this.btnEliminarMarca.TabIndex = 1;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.UseVisualStyleBackColor = false;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // btnModificarMarca
            // 
            this.btnModificarMarca.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModificarMarca.FlatAppearance.BorderSize = 0;
            this.btnModificarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarMarca.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMarca.ForeColor = System.Drawing.Color.White;
            this.btnModificarMarca.Location = new System.Drawing.Point(137, 234);
            this.btnModificarMarca.Name = "btnModificarMarca";
            this.btnModificarMarca.Size = new System.Drawing.Size(81, 23);
            this.btnModificarMarca.TabIndex = 2;
            this.btnModificarMarca.Text = "Modificar";
            this.btnModificarMarca.UseVisualStyleBackColor = false;
            this.btnModificarMarca.Click += new System.EventHandler(this.btnModificarMarca_Click);
            // 
            // labelAdmMarcas
            // 
            this.labelAdmMarcas.AutoSize = true;
            this.labelAdmMarcas.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmMarcas.Location = new System.Drawing.Point(106, 310);
            this.labelAdmMarcas.Name = "labelAdmMarcas";
            this.labelAdmMarcas.Size = new System.Drawing.Size(241, 21);
            this.labelAdmMarcas.TabIndex = 6;
            this.labelAdmMarcas.Text = "Ingrese la Marca que desea agregar:";
            // 
            // txtAgregarMarca
            // 
            this.txtAgregarMarca.Location = new System.Drawing.Point(93, 334);
            this.txtAgregarMarca.Name = "txtAgregarMarca";
            this.txtAgregarMarca.Size = new System.Drawing.Size(266, 20);
            this.txtAgregarMarca.TabIndex = 3;
            // 
            // btnSalirMarca
            // 
            this.btnSalirMarca.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSalirMarca.FlatAppearance.BorderSize = 0;
            this.btnSalirMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirMarca.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirMarca.ForeColor = System.Drawing.Color.White;
            this.btnSalirMarca.Location = new System.Drawing.Point(241, 360);
            this.btnSalirMarca.Name = "btnSalirMarca";
            this.btnSalirMarca.Size = new System.Drawing.Size(81, 23);
            this.btnSalirMarca.TabIndex = 7;
            this.btnSalirMarca.Text = "Salir";
            this.btnSalirMarca.UseVisualStyleBackColor = false;
            this.btnSalirMarca.Click += new System.EventHandler(this.btnSalirMarca_Click);
            // 
            // frmAdministrarMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 415);
            this.Controls.Add(this.btnSalirMarca);
            this.Controls.Add(this.txtAgregarMarca);
            this.Controls.Add(this.labelAdmMarcas);
            this.Controls.Add(this.btnModificarMarca);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.dgvMarcas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(469, 454);
            this.MinimumSize = new System.Drawing.Size(469, 454);
            this.Name = "frmAdministrarMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Marcas";
            this.Load += new System.EventHandler(this.frmAdministrarMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnModificarMarca;
        private System.Windows.Forms.Label labelAdmMarcas;
        private System.Windows.Forms.TextBox txtAgregarMarca;
        private System.Windows.Forms.Button btnSalirMarca;
    }
}