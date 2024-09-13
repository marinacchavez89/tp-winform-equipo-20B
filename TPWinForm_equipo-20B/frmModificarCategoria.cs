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

            seleccionado.Descripcion = txtDescripcionCategoria.Text;

            negocio.modificar(seleccionado);

            MessageBox.Show("Categoría modificada exitosamente");
            Close();
        }

        private void btnModificarCategoriaCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
