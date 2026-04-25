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
       public  List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoADatos datos = new AccesoADatos();


            try
            {
                datos.setearConsulta("Select A.Id, codigo, nombre,A.descripcion , precio, M.descripcion Marca,C.descripcion Categoria, ImagenUrl From ARTICULOS A , IMAGENES I , MARCAS M , CATEGORIAS C Where A.Id = I.Id And A.IdMarca = M.id And A.IdCategoria = C.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read()){

                    Articulo arti = new Articulo();

                    arti.Id = (int)datos.Lector["id"];
                    arti.Codigo = (string)datos.Lector["codigo"];
                    arti.Nombre = (string)datos.Lector["nombre"];
                    arti.Descripcion = (string)datos.Lector["descripcion"];
                    arti.Precio = (decimal)datos.Lector["precio"];
                    arti.Imagen = new Imagen();
                    arti.Imagen.Url = (string)datos.Lector["imagenurl"];
                    arti.Marca = new Marca();
                    arti.Marca.Descripcion = (string)datos.Lector["marca"];
                    arti.Categoria = new Categoria();
                    arti.Categoria.Descripcion = (string)datos.Lector["categoria"];


                    lista.Add(arti);


                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }finally
            {

                datos.cerrarConexion();
            }

        }


        public void agregar(Articulo nuevo)
        {
            AccesoADatos datos = new AccesoADatos();

            try
            {
        
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES (@codigo, @nombre, @desc, @idMarca, @idCat, @precio)");

                datos.setearParametro("@codigo", nuevo.Codigo);
                datos.setearParametro("@nombre", nuevo.Nombre);
                datos.setearParametro("@desc", nuevo.Descripcion);
                datos.setearParametro("@idMarca", nuevo.Marca.Id);
                datos.setearParametro("@idCat", nuevo.Categoria.Id);
                datos.setearParametro("@precio", nuevo.Precio);

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





