using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using Negocio;

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
               
                string consulta = @"SELECT A.Id, Codigo, Nombre, A.Descripcion, Precio, 
                            M.Descripcion AS Marca, C.Descripcion AS Categoria, I.ImagenUrl 
                            FROM ARTICULOS A 
                            INNER JOIN MARCAS M ON A.IdMarca = M.Id 
                            INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id 
                            LEFT JOIN IMAGENES I ON A.Id = I.IdArticulo";

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

                    arti.Marca = new Marca();
                    arti.Marca.Descripcion = (string)datos.Lector["Marca"];

                    arti.Categoria = new Categoria();
                    arti.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    arti.Imagen = new Imagen();
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                    {
                        arti.Imagen.Url = (string)datos.Lector["ImagenUrl"];
                    }
                    else
                    {
                        arti.Imagen.Url = "https://static.vecteezy.com/system/resources/previews/004/141/669/non_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg";
                    }

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



    }


}





