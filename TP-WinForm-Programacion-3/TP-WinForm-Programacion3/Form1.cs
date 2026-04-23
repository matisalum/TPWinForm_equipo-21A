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
//using static TP_WinForm_Programacion3.Articulo;


namespace TP_WinForm_Programacion3
{
    public partial class FrmPrincipal : Form
    {   
        
        public FrmPrincipal()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }



        private void btnAgregando_Click(object sender, EventArgs e)
        {
            MenuArticulos frm = new MenuArticulos();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuMarca ventana = new MenuMarca();
            ventana.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuCategoria ventana = new MenuCategoria();
            ventana.ShowDialog();
        }

        private List<Articulo> listaImgArticulo;
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            ArticuloDato datos = new ArticuloDato();
            listaImgArticulo = datos.listar();
            dgvArticulos.DataSource = listaImgArticulo;
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
            catch (Exception ex)
            {
                pbxArticulo.Load("https://media.istockphoto.com/id/1980276924/es/vector/sin-elemento-gr%C3%A1fico-en-miniatura-de-la-foto-no-se-ha-encontrado-ninguna-imagen-o-est%C3%A1.jpg?s=612x612&w=0&k=20&c=artWlQoi5R1edWQBv9LfzeLXupOcH_alZnMgvXdYkF4=");
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
    

