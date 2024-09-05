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
                datos.setearConsulta("select a.Id, a.Codigo, a.Nombre, a.Descripcion, m.Descripcion as Marca, c.Descripcion as Categoria, a.Precio from articulos as a, marcas as m, categorias as c Where a.IdMarca = m.Id AND a.IdCategoria = c.Id");
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
                    aux.ImagenArticulo = new Imagen();
                    /*aux.ImagenArticulo.Id = (int)datos.Lector["IdImagen"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenArticulo.ImagenUrl = (string)datos.Lector["ImagenUrl"];*/
                    aux.Precio = (decimal)datos.Lector["Precio"];

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
