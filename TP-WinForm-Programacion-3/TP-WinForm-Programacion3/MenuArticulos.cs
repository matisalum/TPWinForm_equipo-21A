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
        private Articulo articulo = null;

        public MenuArticulos()
        {
            InitializeComponent();
        }
        public MenuArticulos(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregado_Click(object sender, EventArgs e)
        {
             
           // Articulo arti = new Articulo();
            ArticuloDato nego = new ArticuloDato();

            try
            {   if (articulo == null)
                    articulo = new Articulo();
                articulo.Nombre = txtNombre.Text;
                articulo.Codigo = txtCodigo.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                Imagen img = new Imagen();
                img.Url = txtURLImagen.Text;
                articulo.Imagen = img;
                articulo.Descripcion = txtDescripcion.Text;

                if (articulo.Id != 0)
                {
                    nego.modificar(articulo);
                    MessageBox.Show("Modificado Correctamente");
                }
                else
                {

                    nego.agregar(articulo);
                    MessageBox.Show("Agregado Correctamente");
                }


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
                /// valueMernber y displayMenber   le estamos asigando  los valores a Marca y Categoria
                cboMarca.DataSource = marcaDato.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = cateDato.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if(articulo != null)
                { //Validacion del modificar para que los datos esten precargados 
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtPrecio.Text = articulo.Precio.ToString(); ;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtURLImagen.Text = articulo.Imagen.Url;
                    cargarImagen(articulo.Imagen.Url);
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;

                }

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
