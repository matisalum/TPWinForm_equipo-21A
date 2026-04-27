using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_WinForm_Programacion3
{
    public partial class Detalles : Form
    {
        private Articulo articulo;
        private List<Imagen> listaImagenes;
        private int indiceImagen = 0;

        public Detalles(Articulo seleccionado)
        {
            InitializeComponent();
            this.articulo = seleccionado;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void Detalles_Load(object sender, EventArgs e)
        {
            txbNombre.Text = articulo.Nombre.ToString();
            txbCodigo.Text = articulo.Codigo.ToString();
            txbMarca.Text = articulo.Marca.ToString();
            txbCategoria.Text = articulo.Categoria.ToString();
            txbPrecio.Text = "$ " + articulo.Precio.ToString();
            txbDescripcion.Text = articulo.Descripcion.ToString();

            ArticuloDato negocio = new ArticuloDato();
            listaImagenes = negocio.listarImagenes(articulo.Id);

            cargarImagen();
        }

        private void cargarImagen()
        {
            
            string urlPlaceholder = "https://agroworldspain.com/img/noimage.png";

            if (listaImagenes != null && listaImagenes.Count > 0)
            {
                try
                {
                    pbxArticulo.Load(listaImagenes[indiceImagen].Url);
                }
                catch (Exception)
                {
                    
                    pbxArticulo.Load(urlPlaceholder);
                }
            }
            else
            {
                pbxArticulo.Load(urlPlaceholder);
            }
        }


        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            if (indiceImagen < listaImagenes.Count - 1)
            {
                indiceImagen++;
                cargarImagen();
            }
        }

        private void btnAnterior_Click_1(object sender, EventArgs e)
        {
            if (indiceImagen > 0)
            {
                indiceImagen--;
                cargarImagen();
            }
        }
    }
}
