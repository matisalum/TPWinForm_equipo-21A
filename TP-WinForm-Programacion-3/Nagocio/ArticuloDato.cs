using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using Nagocio;

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

                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["id"];
                    aux.Codigo = (string)datos.Lector["codigo"];
                    aux.Nombre = (string)datos.Lector["nombre"];
                    aux.Descripcion = (string)datos.Lector["descripcion"];
                    aux.Precio = (decimal)datos.Lector["precio"];
                    aux.Imagen = new Imagen();
                    aux.Imagen.Url = (string)datos.Lector["imagenurl"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["categoria"];


                    lista.Add(aux);


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
       


    }
}





