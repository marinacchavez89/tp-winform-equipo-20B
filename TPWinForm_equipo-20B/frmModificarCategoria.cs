using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TPWinForm_equipo_20B
{
    public partial class frmModificarCategoria : Form
    {
        Categoria seleccionado;
        public frmModificarCategoria(Categoria seleccionado)
        {
            InitializeComponent();
            this.seleccionado = seleccionado;
        }
        private void frmModificarCategoria_Load_1(object sender, EventArgs e)
        {
            txtDescripcionCategoria.Text = seleccionado.Descripcion;
        }

        private void btnModificarCategoriaAceptar_Click_1(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                if (string.IsNullOrWhiteSpace(txtDescripcionCategoria.Text))
                {
                    MessageBox.Show("El campo 'Descripción' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                seleccionado.Descripcion = txtDescripcionCategoria.Text;

                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea modificar la categoria?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    negocio.modificar(seleccionado);
                    MessageBox.Show("Categoria modificada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarCategoriaCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
