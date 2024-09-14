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
    public partial class frmAdministrarMarcas : Form
    {
        private Marca marca;
        private List<Marca> listaMarca;
        public frmAdministrarMarcas()
        {
            InitializeComponent();
        }

        private void frmAdministrarMarcas_Load(object sender, EventArgs e)
        {
            try
            {
                MarcaNegocio negocio = new MarcaNegocio();
                listaMarca = negocio.listar();
                dgvMarcas.DataSource = listaMarca;
                ocultarColumnas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                if (string.IsNullOrWhiteSpace(txtAgregarMarca.Text))
                {
                    MessageBox.Show("Por favor ingrese una Marca valida");
                    return;
                }
                marca = new Marca();
                marca.Descripcion = txtAgregarMarca.Text;
                DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea agregar la marca?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    negocio.agregar(marca);

                    MessageBox.Show("Marca agregada exitosamente", "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MarcaNegocio negocio = new MarcaNegocio();
                listaMarca = negocio.listar();
                dgvMarcas.DataSource = listaMarca;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            Marca seleccionado;
            if (dgvMarcas.CurrentRow != null)
            {
                seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                frmModificarMarca modificar = new frmModificarMarca(seleccionado);
                modificar.ShowDialog();
                cargar();
            }
            else
            {
                MessageBox.Show("Seleccione una marca haciendo clic en una fila de la tabla.", "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar la marca seleccionada de forma permanente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes && dgvMarcas.CurrentRow != null)
                {
                    seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Debe seleccionar al menos una marca para eliminar.", "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cargar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvMarcas.Columns["Id"].Visible = false;
        }
    }
}
