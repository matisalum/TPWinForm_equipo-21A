using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TP_WinForm_Programacion3.Articulos;

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
    }
}
