using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TP_WinForm_Programacion3
{
    public partial class MenuArticulos : Form
    {
        public MenuArticulos()
        {
            InitializeComponent();

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregado_Click(object sender, EventArgs e)
        {
             
            Articulo arti = new Articulo();
            ArticuloDato nego = new ArticuloDato();

            try
            {
                arti.Nombre = txtNombre.Text;
                arti.Codigo = txtCodigo.Text;
                arti.Marca = (Marca)cboMarca.SelectedItem;
                arti.Categoria = (Categoria)cboCategoria.SelectedItem;
                arti.Precio = decimal.Parse(txtPrecio.Text);
                Imagen img = new Imagen();
                img.Url = txtURLImagen.Text;
                arti.Imagen = img;
                arti.Descripcion = txtDescripcion.Text;

                nego.agregar(arti);
                MessageBox.Show("Agregado Correctamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void MenuArticulos_Load(object sender, EventArgs e)
        {
            MarcaDato marcaDato = new MarcaDato();
            CategoriaDato cateDato = new CategoriaDato();
            try
            {
                cboMarca.DataSource = marcaDato.listar();

                cboCategoria.DataSource = cateDato.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtURLImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtURLImagen.Text);
        }

        private void cargarImagen(string imagen)
        {

            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://media.istockphoto.com/id/1980276924/es/vector/sin-elemento-gr%C3%A1fico-en-miniatura-de-la-foto-no-se-ha-encontrado-ninguna-imagen-o-est%C3%A1.jpg?s=612x612&w=0&k=20&c=artWlQoi5R1edWQBv9LfzeLXupOcH_alZnMgvXdYkF4=");
            }
        }

    }
}
