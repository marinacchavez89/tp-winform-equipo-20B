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
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulo;
        private List<Articulo> listaArticulosFiltrada;
        private List<string> imagenesActuales;
        private int indiceImagenActual;
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Precio");
            cboCampo.Items.Add("Código");
            cboCampo.Items.Add("Nombre");            
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                imagenesActuales = new List<string>();
                indiceImagenActual = 0;

                if (dgvArticulos.CurrentRow != null)
                {
                    Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    ArticuloNegocio negocio = new ArticuloNegocio();

                    List<Imagen> listaImagenesArticulo = negocio.listarImagenesPorArticulo(seleccionado.Id);

                    foreach (Imagen img in listaImagenesArticulo)
                    {
                        imagenesActuales.Add(img.ImagenUrl);
                    }

                    if (imagenesActuales.Count > 0)
                    {
                        cargarImagen(imagenesActuales[indiceImagenActual]);
                    }

                    indiceImagenActual = 0;
                    if (imagenesActuales.Count > 0)
                    {
                        cargarImagen(imagenesActuales[indiceImagenActual]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargar()
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArticulo = negocio.listar();
                dgvArticulos.DataSource = listaArticulo;
                ocultarColumnas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargar(List<Articulo> listaArticulos)
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                dgvArticulos.DataSource = listaArticulos;
                ocultarColumnas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void RecargarDatos()
        {
            cargar();          
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxImagen.Load("https://bocashop.vteximg.com.br/arquivos/ids/163215-1000-1000/not-available-es.png?v=637443433440730000");
            }
        }

        private void btnAgregar_MouseEnter(object sender, EventArgs e)
        {
            btnAgregar.BackColor = Color.LightSteelBlue;
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.BackColor = Color.SteelBlue;
        }
        private void btnModificar_MouseEnter(object sender, EventArgs e)
        {
            btnModificar.BackColor = Color.LightSteelBlue;
        }

        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            btnModificar.BackColor = Color.SteelBlue;
        }
        private void btnEliminar_MouseEnter(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.LightSteelBlue;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.SteelBlue;
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.LightSteelBlue;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.SteelBlue;
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿De verdad desea salir?", "Saliendo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar el artículo seleccionado de forma permanente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes && dgvArticulos.CurrentRow != null)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Debe seleccionar al menos un artículo para eliminar.");
                cargar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (imagenesActuales.Count >= 0)
            {
                indiceImagenActual = (indiceImagenActual + 1) % imagenesActuales.Count;
                cargarImagen(imagenesActuales[indiceImagenActual]);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (imagenesActuales.Count >= 0)
            { 
                indiceImagenActual = (indiceImagenActual - 1 + imagenesActuales.Count) % imagenesActuales.Count;
                cargarImagen(imagenesActuales[indiceImagenActual]);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;            
            if (dgvArticulos.CurrentRow != null)
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem; 
                frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
                modificar.ShowDialog();                
                cargar();
            }
            else
            {
                MessageBox.Show("Seleccione un artículo haciendo clic en una fila de la tabla.");
            }
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            try
            {   
                Articulo seleccionado;

                if (dgvArticulos.CurrentRow != null)
                {                    
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    frmDetalle detalle = new frmDetalle(seleccionado);
                    detalle.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Seleccione un artículo haciendo clic en una fila de la tabla.", "Detalle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un artículo haciendo clic en una fila de la tabla.", "Detalle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdministrarImagenes_Click(object sender, EventArgs e)
        {
            if(dgvArticulos.SelectedCells.Count > 0)
            {
                int idArticulo = (int)dgvArticulos.SelectedRows[0].Cells["Id"].Value;
                frmAdministrarImagenes formImagenes = new frmAdministrarImagenes(idArticulo, this);
                formImagenes.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un articulo primero.");
            }
        }

        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.SelectedCells.Count > 0)
            {
                int idArticulo = (int)dgvArticulos.SelectedRows[0].Cells["Id"].Value;
                frmAdministrarImagenes formImagenes = new frmAdministrarImagenes(idArticulo, this);
                formImagenes.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un articulo primero.");
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return;
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltro.Text;
                listaArticulosFiltrada = negocio.filtrar(campo, criterio, filtro);
                dgvArticulos.DataSource = listaArticulosFiltrada;
                cargar(listaArticulosFiltrada);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }

            return true;
        }

        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un campo para filtrar, por favor.", "Filtro", MessageBoxButtons.OK, MessageBoxIcon.Information);             
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione el criterio para filtrar, por favor.", "Filtro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltro.Text))
                {
                    MessageBox.Show("Debes elegir una opción para filtrar por Precio, por favor.", "Filtro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                if (!(soloNumeros(txtFiltro.Text)))
                {
                    MessageBox.Show("Ingrese solo números para filtrar por Precio, por favor.", "Filtro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }

            return false;
        }        
    }
}
