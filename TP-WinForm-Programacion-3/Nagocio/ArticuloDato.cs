using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using Negocio;
using System.Globalization;

namespace Negocio
{
    public class ArticuloDato
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoADatos datos = new AccesoADatos();

            try
            {
                ///Trae todos los articulos tengan campos "validos" o no
                // Usamos un subquery para traer solo la primera imagen de cada artículo
                // Agregamos A.IdMarca y A.IdCategoria a la lista de campos
                string consulta = @"SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, 
                    A.IdMarca, A.IdCategoria, 
                    M.Descripcion AS Marca, 
                    C.Descripcion AS Categoria, 
                    (SELECT TOP 1 I.ImagenUrl FROM IMAGENES I WHERE I.IdArticulo = A.Id) AS ImagenUrl 
                    FROM ARTICULOS A 
                    INNER JOIN MARCAS M ON A.IdMarca = M.Id 
                    INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id";

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo arti = new Articulo();

                    arti.Id = (int)datos.Lector["Id"];
                    arti.Codigo = (string)datos.Lector["Codigo"];
                    arti.Nombre = (string)datos.Lector["Nombre"];
                    arti.Descripcion = (string)datos.Lector["Descripcion"];
                    arti.Precio = (decimal)datos.Lector["Precio"];
                    
                    //validaciones si el articulo cuenta o no con
                    //URLimagen - Marca - Categoria - Id
                    arti.Marca = new Marca();
                    if (!(datos.Lector["IdMarca"] is DBNull))
                    arti.Marca.Id = (int)datos.Lector["IdMarca"];
                    if (!(datos.Lector["Marca"] is DBNull))
                        arti.Marca.Descripcion = (string)datos.Lector["Marca"];
                    else
                        arti.Marca.Descripcion = "Sin marca";

                    arti.Categoria = new Categoria();
                    if (!(datos.Lector["IdCategoria"] is DBNull))
                        arti.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    if (!(datos.Lector["Categoria"] is DBNull))
                        arti.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    else
                        arti.Categoria.Descripcion = "Sin categoria";

                    arti.Imagen = new Imagen();
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        arti.Imagen.Url = (string)datos.Lector["ImagenUrl"];
                    ///

                    lista.Add(arti);
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


        public void agregar(Articulo nuevo)
        {
            AccesoADatos datos = new AccesoADatos();

            try
            {                    
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) OUTPUT INSERTED.ID VALUES (@codigo, @nombre, @desc, @idMarca, @idCat, @precio)");

                datos.setearParametro("@codigo", nuevo.Codigo);
                datos.setearParametro("@nombre", nuevo.Nombre);
                datos.setearParametro("@desc", nuevo.Descripcion);
                datos.setearParametro("@idMarca", nuevo.Marca.Id);
                datos.setearParametro("@idCat", nuevo.Categoria.Id);
                datos.setearParametro("@precio", nuevo.Precio);
               
                int idGenerado = datos.ejecutarAccionScalar();
               
                foreach (var img in nuevo.Imagenes)
                {
                    datos.cerrarConexion();
                    datos = new AccesoADatos();
                    
                    datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@idArt, @url)");
                    datos.setearParametro("@idArt", idGenerado);
                    datos.setearParametro("@url", img.Url);
                    datos.ejecutarAccion();
                }
                //datos.cerrarConexion();
                //datos = new AccesoADatos(); 

               // datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@idArti, @url)");
               
               // datos.setearParametro("@idArti", idGenerado);
                //datos.setearParametro("@url", nuevo.Imagen.Url);

               // datos.ejecutarAccion();
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

        public void modificar(Articulo modificar)
        {
            AccesoADatos datos = new AccesoADatos();
            try
            {
                datos.setearConsulta("update Articulos set Codigo = @codigo , Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @idCategoria, Precio = @precio where Id = @id");
                datos.setearParametro("@codigo", modificar.Codigo);
                datos.setearParametro("@nombre", modificar.Nombre);
                datos.setearParametro("@descripcion", modificar.Descripcion);
                datos.setearParametro("@idMarca", modificar.Marca.Id);
                datos.setearParametro("@idCategoria", modificar.Categoria.Id);
                datos.setearParametro("@precio", modificar.Precio);
                datos.setearParametro("@id", modificar.Id);

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
                AccesoADatos datos = new AccesoADatos();
                datos.setearConsulta("delete from ARTICULOS where id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public List<Imagen> listarImagenes(int idArticulo)
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoADatos datos = new AccesoADatos();
            try
            {
                datos.setearConsulta("SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES WHERE IdArticulo = @idArt");
                datos.setearParametro("@idArt", idArticulo);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen img = new Imagen();
                    img.Id = (int)datos.Lector["Id"];
                    img.IdArticulo = (int)datos.Lector["IdArticulo"];
                    img.Url = (string)datos.Lector["ImagenUrl"];
                    lista.Add(img);
                }
                return lista;
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }

    }

}





