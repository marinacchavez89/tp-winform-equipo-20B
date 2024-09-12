using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_20B
{
    public partial class frmAdministrarImagenes : Form
    {
        private int idArticulo;
        private frmArticulos frmArticulosRef;
        public frmAdministrarImagenes(int idArticulo, frmArticulos frmArticulos) 
        {
            InitializeComponent();
            this.idArticulo = idArticulo;
            this.frmArticulosRef = frmArticulos;
            cargarImagenes();
        }

        private void frmAdministrarImagenes_Load(object sender, EventArgs e)
        {
            dgvImagenes.Columns["Id"].Visible = false;
        }

        private void cargarImagenes()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Imagen> imagenes = negocio.listarImagenesPorArticulo(idArticulo);
            dgvImagenes.DataSource = imagenes;
        }
        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtUrlImagen.Text))
            {
                    AccesoDatos datos = new AccesoDatos();
                try
                {
                    datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (" + idArticulo + ", '" + txtUrlImagen.Text + "')");
                    datos.ejecutarAccion();
                    MessageBox.Show("Imagen agregada correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmArticulosRef.RecargarDatos();
                    this.Close();
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al agregar la imagen", ex.ToString());
                }
                finally
                {
                    datos.cerrarConexion();
                }
            }
            else
            {
                MessageBox.Show("Ingresa una URL válida", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            if (dgvImagenes.SelectedRows.Count > 0)
            {           
                int idImagen = (int)dgvImagenes.SelectedRows[0].Cells["Id"].Value;

                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar esta imagen?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        ArticuloNegocio negocio = new ArticuloNegocio();
                        negocio.eliminarImagen(idImagen);
                        cargarImagenes();
                        MessageBox.Show("Imagen eliminada con éxito.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar la imagen: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una imagen para eliminar.", "Atención",  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagenAdmin.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxImagenAdmin.Load("https://bocashop.vteximg.com.br/arquivos/ids/163215-1000-1000/not-available-es.png?v=637443433440730000");
            }
        }

        private void dgvImagenes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvImagenes.CurrentRow != null)
                {                   
                    string imagenUrl = dgvImagenes.CurrentRow.Cells["ImagenUrl"].Value.ToString();

                    if (!string.IsNullOrEmpty(imagenUrl))
                    {
                        cargarImagen(imagenUrl);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la imagen: " + ex.Message);
            }
        }
    }
}
