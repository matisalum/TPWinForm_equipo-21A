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
        private List<Imagen> listaImagenesTemp = new List<Imagen>();
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
            ArticuloDato nego = new ArticuloDato();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                // 1. Cargamos los datos básicos
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;

                // 2. Lógica de Imágenes
                if (articulo.Id == 0)
                {
                    // SI ES NUEVO: 
                    // Usamos la lista que fuimos llenando con el botón "+"
                    articulo.Imagenes = listaImagenesTemp;

                    // Opcional: Si el usuario pegó algo en el cuadro de texto pero se olvidó 
                    // de apretar el "+", lo agregamos acá para que no se pierda esa última URL
                    if (!string.IsNullOrEmpty(txtUrlImagen.Text))
                    {
                        Imagen ultimaImg = new Imagen { Url = txtUrlImagen.Text };
                        articulo.Imagenes.Add(ultimaImg);
                    }

                    nego.agregar(articulo);
                    MessageBox.Show("Agregado Correctamente");
                }
                else
                {
                    // SI ES MODIFICACIÓN:
                    // Por ahora mantenemos tu lógica (o podrías adaptar modificar luego)
                    Imagen img = new Imagen();
                    img.Url = txtUrlImagen.Text;
                    articulo.Imagen = img;

                    nego.modificar(articulo);
                    MessageBox.Show("Modificado Correctamente");
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
                    txtUrlImagen.Text = articulo.Imagen.Url;
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
            cargarImagen(txtUrlImagen.Text);
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

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrlImagen.Text))
            {
               
                Imagen nueva = new Imagen();
                nueva.Url = txtUrlImagen.Text;

                listaImagenesTemp.Add(nueva);

                
                lbUrls.Items.Add(nueva.Url);

                
                txtUrlImagen.Clear();

                
                cargarImagen(nueva.Url);
                MessageBox.Show("Imagen acumulada para el nuevo artículo.");
            }
        }
    }
}
