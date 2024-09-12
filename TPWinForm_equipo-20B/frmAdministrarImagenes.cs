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
        public frmAdministrarImagenes(int idArticulo)
        {
            InitializeComponent();
            this.idArticulo = idArticulo;
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
                    MessageBox.Show("Imagen agregada correctamente");                 
                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al agregar la imagen");
                }
                finally
                {
                    datos.cerrarConexion();
                }
            }
            else
            {
                MessageBox.Show("Ingresa una URL valida");
            }
        }        
    }
}
