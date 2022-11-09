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
            public float floPrecio;
        }
        structRepuestos[] vecRepuestos = new structRepuestos[100];
        public int intIndiceRegistro = 0;
        public int intIndiceConsulta = 0;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            lstDatosRepuestos.Items.Clear();
            intIndiceConsulta = 0;
            if (optNacional.Checked == true)
            {
                lstDatosRepuestos.Items.Add("Repuestos Marca " + cmbMarcaConsulta.Text + " Origen Nacional:");
            }
            else
            {
                lstDatosRepuestos.Items.Add("Repuestos Marca " + cmbMarcaConsulta.Text + " Origen Importado");
            }
            while (intIndiceConsulta < vecRepuestos.Length)
            {
                if (vecRepuestos[intIndiceConsulta].strMarca == cmbMarcaConsulta.Text)
                {
                    if (optNacionalConsulta.Checked == true && vecRepuestos[intIndiceConsulta].strOrigen == "Nacional")
                    {
                        lstDatosRepuestos.Items.Add("Nº de Repuesto: " + vecRepuestos[intIndiceConsulta].intNumeroRepuesto);
                        lstDatosRepuestos.Items.Add("Precio: " + vecRepuestos[intIndiceConsulta].floPrecio);
                        lstDatosRepuestos.Items.Add("Descripción: " + vecRepuestos[intIndiceConsulta].strDescripcion);
                    }
                    else
                    {
                        lstDatosRepuestos.Items.Add("Nº de Repuesto: " + vecRepuestos[intIndiceConsulta].intNumeroRepuesto);
                        lstDatosRepuestos.Items.Add("Precio: " + vecRepuestos[intIndiceConsulta].floPrecio);
                        lstDatosRepuestos.Items.Add("Descripción: " + vecRepuestos[intIndiceConsulta].strDescripcion);
                    }
                }
                intIndiceConsulta++;
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            bool existeNroRepuesto = false;
            intIndiceConsulta = 0;
            while (intIndiceConsulta < vecRepuestos.Length)
            {
                if (vecRepuestos[intIndiceRegistro].intNumeroRepuesto == int.Parse(txtNumeroRepuesto.Text))
                {
                    existeNroRepuesto = true;
                    MessageBox.Show("El Nº de Repuesto " + txtNumeroRepuesto.Text + " ya está registrado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                intIndiceConsulta++;
            }
            if (existeNroRepuesto == false)
            {
                vecRepuestos[intIndiceRegistro].strMarca = cmbMarca.Text;
                if (optNacional.Checked == true)
                {
                    vecRepuestos[intIndiceRegistro].strOrigen = "Nacional";
                }
                else
                {
                    vecRepuestos[intIndiceRegistro].strOrigen = "Importado";
                }
                vecRepuestos[intIndiceRegistro].intNumeroRepuesto = int.Parse(txtNumeroRepuesto.Text);
                vecRepuestos[intIndiceRegistro].strDescripcion = txtDescripcion.Text;
                vecRepuestos[intIndiceRegistro].floPrecio = float.Parse(txtPrecio.Text);
                intIndiceRegistro++;
            }
        }
    }
}
