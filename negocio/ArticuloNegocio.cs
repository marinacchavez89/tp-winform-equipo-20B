using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();



            try
            {                
                datos.setearConsulta("SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion,(SELECT m.Descripcion FROM marcas AS m WHERE m.Id = a.IdMarca) AS Marca, ISNULL((SELECT c.Descripcion FROM categorias AS c WHERE c.Id = a.IdCategoria), 'Sin Categoria') AS Categoria, a.Precio,(SELECT TOP 1 img.ImagenUrl FROM imagenes AS img WHERE img.IdArticulo = a.Id) AS ImagenUrl FROM articulos AS a");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    if (!(datos.Lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.TipoMarca = new Marca();
                    //aux.TipoMarca.Id = (int)datos.Lector["IdMarca"];
                    aux.TipoMarca.Descripcion = (string)datos.Lector["Marca"];
                    aux.TipoCategoria = new Categoria();
                    //aux.TipoCategoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.TipoCategoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.ImagenArticulo = new Imagen();
                    aux.ImagenArticulo.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
