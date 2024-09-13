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
    public partial class frmDetalle : Form
    {
        private List<string> imagenesActuales;
        private int indiceImagenActual;
        private Articulo seleccionado;
        public frmDetalle()
        {
            InitializeComponent();
        }

        public frmDetalle(Articulo articuloSeleccionado)
        {
            InitializeComponent();
            seleccionado = articuloSeleccionado;
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            imagenesActuales = new List<string>();
            indiceImagenActual = 0;

            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();                
                
                List<Imagen> listaImagenesArticulo  = negocio.listarImagenesPorArticulo(seleccionado.Id);

                foreach (Imagen img in listaImagenesArticulo)
                {
                    imagenesActuales.Add(img.ImagenUrl);
                }              
               
                if (imagenesActuales.Count > 0)
                {
                    cargarImagen(imagenesActuales[indiceImagenActual]);
                }
                
                txtCodigo.Text = seleccionado.Codigo;                
                txtNombreDetalle.Text = seleccionado.Nombre;                
                txtMarcaDetalle.Text = seleccionado.TipoMarca.ToString();
                txtCategoriaDetalle.Text = seleccionado.TipoCategoria.ToString();
                txtPrecioDetalle.Text = seleccionado.Precio.ToString();
                txtDescripcionDetalle.Text = seleccionado.Descripcion;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCerrarDetalle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagenDetalle.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxImagenDetalle.Load("https://bocashop.vteximg.com.br/arquivos/ids/163215-1000-1000/not-available-es.png?v=637443433440730000");
            }
        }

        private void btnAnteriorDetalle_Click(object sender, EventArgs e)
        {
            if (imagenesActuales.Count > 0 && imagenesActuales != null)
            {
                indiceImagenActual = (indiceImagenActual + 1) % imagenesActuales.Count;
                cargarImagen(imagenesActuales[indiceImagenActual]);
            }
        }

        private void btnSiguienteDetalle_Click(object sender, EventArgs e)
        {
            if (imagenesActuales.Count > 0 && imagenesActuales != null)
            {
                indiceImagenActual = (indiceImagenActual - 1 + imagenesActuales.Count) % imagenesActuales.Count;
                cargarImagen(imagenesActuales[indiceImagenActual]);
            }
        }
    }
}
