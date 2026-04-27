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
    public partial class MenuCategoria : Form
    {
        public MenuCategoria()
        {
            InitializeComponent();
        }

        private List<Categoria> listaCategoria;

        private void cargar()
        {
            CategoriaDato datos = new CategoriaDato();
            listaCategoria = datos.listar();
            dgvCategoria.DataSource = listaCategoria;
        }


        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            CategoriaDato datos = new CategoriaDato();

            try
            {
            Categoria nueva = new Categoria();

            nueva.Descripcion = txbDescripcionCategoria.Text.Trim();
                if (nueva.Descripcion != "")
                {
                    datos.agregar(nueva);
                    MessageBox.Show("Categoria agregada correctamente");
                    txbDescripcionCategoria.Clear();
                    cargar();
                }
                else
                {
                    MessageBox.Show("La descripción no puede estar vacía");
                    return;

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }




        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            CategoriaDato cate = new CategoriaDato();
            Categoria seleccionado;

            try
            {
                DialogResult repuesta = MessageBox.Show("¿De verdad queres eliminarlo?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (repuesta == DialogResult.Yes)
                {
                    seleccionado = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
                    cate.eliminar(seleccionado.Id);
                    cargar();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void MenuCategoria_Load_1(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
