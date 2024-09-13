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
    public partial class frmAdministrarCategorias : Form
    {
        private Categoria categoria;
        private List<Categoria> listaCategoria;
        public frmAdministrarCategorias()
        {
            InitializeComponent();
        }

        private void frmAdministrarCategorias_Load_1(object sender, EventArgs e)
        {
            try
            {
                CategoriaNegocio negocio = new CategoriaNegocio();
                listaCategoria = negocio.listar();
                dgvCategorias.DataSource = listaCategoria;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAgregarCategoria_Click_1(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                categoria = new Categoria();
                categoria.Descripcion = txtAgregarCategoria.Text;
                DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea agregar la categoría?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    negocio.agregar(categoria);

                    MessageBox.Show("Categoría agregada exitosamente", "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void cargar()
        {
            try
            {
                CategoriaNegocio negocio = new CategoriaNegocio();
                listaCategoria = negocio.listar();
                dgvCategorias.DataSource = listaCategoria;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnModificarCategoria_Click_1(object sender, EventArgs e)
        {
            Categoria seleccionado;
            if (dgvCategorias.CurrentRow != null)
            {
                seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                frmModificarCategoria modificar = new frmModificarCategoria(seleccionado);
                modificar.ShowDialog();
                cargar();
            }
            else
            {
                MessageBox.Show("Seleccione una categoría haciendo clic en una fila de la tabla.", "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarCategoria_Click_1(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar la categoría seleccionada de forma permanente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes && dgvCategorias.CurrentRow != null)
                {
                    seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Debe seleccionar al menos una categoría para eliminar.", "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cargar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
