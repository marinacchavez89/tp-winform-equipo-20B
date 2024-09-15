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
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;

        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar artículo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();
                articulo.Codigo = txtCodigoDetalle.Text;
                articulo.Nombre = txtNombreDetalle.Text;
                articulo.Descripcion = txtDescripcionDetalle.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                if (decimal.Parse(txtPrecio.Text) < 0)
                {
                    MessageBox.Show("El precio no puede ser un valor negativo.", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                articulo.TipoMarca = (Marca)cboMarcaDetalle.SelectedItem;
                if(cboMarcaDetalle.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una Marca.", "Verificar",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                articulo.TipoCategoria = (Categoria)cboCategoria.SelectedItem;              
                if(cboCategoria.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una Categoría.", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult respuesta;
                DialogResult confirmarModificar;

                if (articulo.Id != 0)
                {
                    if(string.IsNullOrEmpty(txtCodigoDetalle.Text) || string.IsNullOrEmpty(txtNombreDetalle.Text))
                    {
                        respuesta = MessageBox.Show("Debe completar Código y Nombre.", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        confirmarModificar = MessageBox.Show("¿Esta seguro de modificar el articulo?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if(confirmarModificar == DialogResult.Yes)
                        {
                            negocio.modificar(articulo);
                            respuesta = MessageBox.Show("Artículo modificado exitosamente.", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            return;
                        }                  
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(txtCodigoDetalle.Text) || string.IsNullOrEmpty(txtNombreDetalle.Text))
                    {
                        respuesta = MessageBox.Show("Debe completar Código y Nombre.", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        negocio.agregar(articulo);
                        respuesta = MessageBox.Show("Artículo agregado exitosamente.", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }

                }
            }
            catch (FormatException ex) { MessageBox.Show("Campo Precio admite solo números y no puede estar vacío.", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error al agregar Artículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cboMarcaDetalle.DataSource = marcaNegocio.listar();
                cboMarcaDetalle.ValueMember = "Id";
                cboMarcaDetalle.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigoDetalle.Text = articulo.Codigo.ToString();
                    txtNombreDetalle.Text = articulo.Nombre;
                    txtDescripcionDetalle.Text = articulo.Descripcion;
                    cboMarcaDetalle.SelectedValue = articulo.TipoMarca.Id;
                    cboCategoria.SelectedValue = articulo.TipoCategoria.Id;
                    txtPrecio.Text = articulo.Precio.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
