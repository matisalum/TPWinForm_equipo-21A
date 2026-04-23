//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;
//namespace TP_WinForm_Programacion3
//{
//     class ArticuloDato
//    {
//        public List<Articulos> listar()
//        {

//            List<Articulos> lista = new List<Articulos>();
//            SqlConnection conexion = new SqlConnection();
//            SqlCommand comando = new SqlCommand();
//            SqlDataReader lector;

//            try
//            {
//                conexion.ConnectionString = "Server = .\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
//                comando.CommandType = System.Data.CommandType.Text;
//                comando.CommandText = "Select id, codigo, nombre, descripcion, precio From ARTICULOS";
//                comando.Connection = conexion;

//                conexion.Open();
//                lector=comando.ExecuteReader();
//                while (lector.Read())
//                {
//                    Articulo aux = new Articulo();
//                    aux. = (int)lector["id"];
//                    aux. = (int)lector["codigo"];
//                    aux. = (string)lector["nombre"];
//                    aux. = (string)lector["descripcion"];
//                    aux. = (decimal)lector["precio"]:

//                }

//                conexion.Close();
//                return lista;
//            }
//            catch (Exception ex)
//            {

//                throw ex;
//            }

//        }


//    }
//}
