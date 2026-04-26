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
        private void MenuMarca_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }
        private List<Marca> listamarcas;
        private void cargar()
        {
            MarcaDato datos = new MarcaDato();
            listamarcas = datos.listar();
            dgvMarca.DataSource = listamarcas;
        }  
    }
}
