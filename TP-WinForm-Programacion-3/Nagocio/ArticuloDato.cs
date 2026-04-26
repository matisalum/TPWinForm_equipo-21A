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
                string consulta = "SELECT A.Id, codigo, nombre, A.descripcion, " +
                  "precio," +
                  "M.Id  IdMarca, M.descripcion Marca, " +
                  "C.Id IdCategoria, C.descripcion Categoria," +
                  "ImagenUrl " +
                  "FROM ARTICULOS A " +
                  "LEFT JOIN IMAGENES I ON A.Id = I.IdArticulo " +
                  "LEFT JOIN MARCAS M ON A.IdMarca = M.Id " +
                  "LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id";

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
               
                datos.cerrarConexion();
                datos = new AccesoADatos(); 

                datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@idArti, @url)");
               
                datos.setearParametro("@idArti", idGenerado);
                datos.setearParametro("@url", nuevo.Imagen.Url);

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

        public void modificar(Articulo modificar)
        {
            AccesoADatos datos = new AccesoADatos();
            try
            {
                datos.setearConsulta("update Articulos set Codigo = @codigo , Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @idCaegoria, Precio = @precio where Id = @id");
                datos.setearParametro("@codigo", modificar.Codigo);
                datos.setearParametro("@nombre", modificar.Nombre);
                datos.setearParametro("@descripcion", modificar.Descripcion);
                datos.setearParametro("@idMarca", modificar.Marca);
                datos.setearParametro("@idCaegoria", modificar.Categoria);
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

    }

}





