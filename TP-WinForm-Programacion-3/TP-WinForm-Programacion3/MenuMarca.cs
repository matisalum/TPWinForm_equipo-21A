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
    public partial class MenuMarca : Form
    {
        public MenuMarca()
        {
            InitializeComponent();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MarcaDato datos = new MarcaDato();

            try
            {
                Marca nMarca = new Marca();

                nMarca.Descripcion = txbDescripcionMarca.Text.Trim();
                if (nMarca.Descripcion != "")
                {
                    datos.agregar(nMarca);
                    MessageBox.Show("Marca cargada exitosamente!");
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
        private List<Marca> listamarcas;
        private void cargar()
        {
            MarcaDato datos = new MarcaDato();
            listamarcas = datos.listar();
            dgvMarca.DataSource = listamarcas;
        }

        private void MenuMarca_Load_1(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Marca seleccion = (Marca)dgvMarca.CurrentRow.DataBoundItem;

            try
            {
                DialogResult respuesta = MessageBox.Show("Seguro quieres eliminar esta marca?",
                "Eliminar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    MarcaDato dato = new MarcaDato();
                    dato.eliminar(seleccion.Id);

                    MessageBox.Show("Marca eliminada correctamente.");
                    cargar();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la marca.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}

