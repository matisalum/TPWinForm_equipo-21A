using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
//using static TP_WinForm_Programacion3.Articulo;


namespace TP_WinForm_Programacion3
{
    public partial class FrmPrincipal : Form
    {   
        
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregando_Click(object sender, EventArgs e)
        {
            MenuArticulos frm = new MenuArticulos();
            frm.ShowDialog();
            cargar();

        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            MenuArticulos frm = new MenuArticulos(seleccionado);
            frm.ShowDialog();
            cargar();
        }
        private void tsMarca_Click(object sender, EventArgs e)
        {
            MenuMarca ventana = new MenuMarca();
            ventana.ShowDialog();
            cargar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuMarca ventana = new MenuMarca();
            ventana.ShowDialog();
            cargar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuCategoria ventana = new MenuCategoria();
            ventana.ShowDialog();
        }

        private void OcultarColumna()
        {
            dgvArticulos.Columns[7].Visible = false;
        }

        private List<Articulo> listaImgArticulo;
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            cargar();
        }

        private void cargar()    
        {
            ArticuloDato datos = new ArticuloDato();
            listaImgArticulo = datos.listar();
            dgvArticulos.DataSource = listaImgArticulo;
            OcultarColumna();
            cargarImagen(listaImgArticulo[0].Imagen.Url);
        }
        

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
          Articulo seleccionado  = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagen.Url);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception )
            {
                pbxArticulo.Load("https://media.istockphoto.com/id/1980276924/es/vector/sin-elemento-gr%C3%A1fico-en-miniatura-de-la-foto-no-se-ha-encontrado-ninguna-imagen-o-est%C3%A1.jpg?s=612x612&w=0&k=20&c=artWlQoi5R1edWQBv9LfzeLXupOcH_alZnMgvXdYkF4=");
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tsSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            Detalles ventana = new Detalles(seleccionado);
            ventana.ShowDialog();
        }

        private void txbBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada = new List<Articulo>();
            string filtro = txbBusqueda.Text.ToLower();

            if(filtro != "")
            {
                listaFiltrada = listaImgArticulo.FindAll(x =>
                x.Nombre.ToLower().Contains(filtro) ||
                x.Marca.Descripcion.ToLower().Contains(filtro) ||
                x.Categoria.Descripcion.ToLower().Contains(filtro) ||
                x.Codigo.ToLower().Contains(filtro));
            }
            else
            {
                listaFiltrada = listaImgArticulo;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            OcultarColumna();

        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloDato arti = new ArticuloDato();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De Verdad Querés Elimarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    arti.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
    

