using Dominio;
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

        public Detalles(Articulo art)
        {
            InitializeComponent();
            articulo = art;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                ptbImagen.Load(imagen);
            }
            catch (Exception)
            {
                ptbImagen.Load("https://media.istockphoto.com/id/1980276924/es/vector/sin-elemento-gr%C3%A1fico-en-miniatura-de-la-foto-no-se-ha-encontrado-ninguna-imagen-o-est%C3%A1.jpg?s=612x612&w=0&k=20&c=artWlQoi5R1edWQBv9LfzeLXupOcH_alZnMgvXdYkF4=");
            }
        }

        private void Detalles_Load(object sender, EventArgs e)
        {
            txbNombre.Text = articulo.Nombre.ToString();
            txbCodigo.Text = articulo.Codigo.ToString();
            txbMarca.Text = articulo.Marca.ToString();
            txbCategoria.Text = articulo.Categoria.ToString();
            txbPrecio.Text = "$ " + articulo.Precio.ToString();
            txbDescripcion.Text = articulo.Descripcion.ToString();
            cargarImagen(articulo.Imagen.Url);
        }
    }
}
