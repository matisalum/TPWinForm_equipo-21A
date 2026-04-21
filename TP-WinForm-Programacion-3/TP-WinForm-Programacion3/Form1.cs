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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            


            MenuArticulos ventana = new MenuArticulos();
            this.Hide();
            ventana.FormClosed += (s, args) => this.Show();
           // ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
