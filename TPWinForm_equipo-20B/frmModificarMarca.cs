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
    public partial class frmModificarMarca : Form
    {
        Marca seleccionado;
        public frmModificarMarca(Marca seleccionado)
        {
            InitializeComponent();
            this.seleccionado = seleccionado;
        }
        private void frmModificarMarca_Load(object sender, EventArgs e)
        {
            txtDescripcionMarca.Text = seleccionado.Descripcion;
        }

        private void btnModificarMarcaCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificarMarcaAceptar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();

            seleccionado.Descripcion = txtDescripcionMarca.Text;

            negocio.modificar(seleccionado);

            MessageBox.Show("Artículo modificado exitosamente");
            Close();
        }
    }
}
