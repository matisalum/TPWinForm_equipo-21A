using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TP_WinForm_Programacion3
{
    public class Marca
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
