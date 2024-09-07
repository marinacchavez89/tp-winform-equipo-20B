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
            AccesoDatos datosImagenes = new AccesoDatos();


            try
            {
                datos.setearConsulta("SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion, (SELECT m.Descripcion FROM marcas AS m WHERE m.Id = a.IdMarca) AS Marca, ISNULL((SELECT c.Descripcion FROM categorias AS c WHERE c.Id = a.IdCategoria), 'Sin Categoria') AS Categoria, a.Precio FROM articulos AS a;");
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
                    aux.ImagenArticulo = new List<Imagen>();

                    lista.Add(aux);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            try
            {
                datosImagenes.setearConsulta("SELECT img.IdArticulo, img.ImagenUrl FROM imagenes AS img;");
                datosImagenes.ejecutarLectura();

                while (datosImagenes.Lector.Read())
                {
                    int idArticulo = (int)datosImagenes.Lector["IdArticulo"];
                    string imagenUrl = (string)datosImagenes.Lector["ImagenUrl"];

                    foreach (Articulo articulo in lista)
                    {
                        if(articulo.Id == idArticulo)
                        {
                            Imagen imagen = new Imagen { ImagenUrl = imagenUrl };
                            articulo.ImagenArticulo.Add(imagen);
                        }
                    }

                }
            }
            
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                datosImagenes.cerrarConexion();
            }

            return lista;
           
        }
    }
}
