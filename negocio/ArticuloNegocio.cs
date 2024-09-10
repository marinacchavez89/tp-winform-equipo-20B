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
                datos.setearConsulta(@"SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion,
                                      a.IdMarca, ISNULL(m.Descripcion, 'Sin Marca') AS Marca,
                                      a.IdCategoria, ISNULL(c.Descripcion, 'Sin Categoria') AS Categoria,
                                      a.Precio
                               FROM articulos AS a
                               LEFT JOIN marcas AS m ON m.Id = a.IdMarca
                               LEFT JOIN categorias AS c ON c.Id = a.IdCategoria");
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
                    if (!(datos.Lector["IdMarca"] is DBNull))
                        aux.TipoMarca.Id = (int)datos.Lector["IdMarca"];
                    aux.TipoMarca.Descripcion = (string)datos.Lector["Marca"];             
                    aux.TipoCategoria = new Categoria();
                    if (!(datos.Lector["IdCategoria"] is DBNull))
                        aux.TipoCategoria.Id = (int)datos.Lector["IdCategoria"];
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
        public void agregar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio)values(@Codigo, @Nombre, @Descripcion, @idMarca, @idCategoria, @Precio)");
                datos.setearParametro("@Codigo", articulo.Codigo);
                datos.setearParametro("@Nombre", articulo.Nombre);
                datos.setearParametro("@Descripcion", articulo.Descripcion);
                datos.setearParametro("@idMarca", articulo.TipoMarca.Id);
                datos.setearParametro("@idCategoria", articulo.TipoCategoria.Id);
                datos.setearParametro("@Precio", articulo.Precio);
                datos.ejecutarAccion();
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
        public void modificar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @idCategoria, Precio = @precio where Id = @id");
                datos.setearParametro("@codigo", art.Codigo);
                datos.setearParametro("@nombre", art.Nombre);
                datos.setearParametro("@descripcion", art.Descripcion);
                datos.setearParametro("@idMarca", art.TipoMarca.Id);
                datos.setearParametro("@idCategoria", art.TipoCategoria.Id);
                datos.setearParametro("@precio", art.Precio);
                datos.setearParametro("@id", art.Id);

                datos.ejecutarAccion();
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

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where Id = @id");
                datos.setearParametro("id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
