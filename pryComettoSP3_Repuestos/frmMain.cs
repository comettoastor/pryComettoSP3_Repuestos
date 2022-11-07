using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryComettoSP3_Repuestos
{
    public partial class frmMain : Form
    {
        public struct structRepuestos {
            public string strMarca;
            public string strOrigen;
            public int intNumeroRepuesto;
            public string strDescripcion;
            public int intPrecio;
        }
        structRepuestos[] vecRepuestos = new structRepuestos[100];
        public int intIndice = 0;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            vecRepuestos[intIndice].strMarca = textBox2.Text;
            i++;
        }
    }
}
