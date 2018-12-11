using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoPalabras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int c = 0;
        string[] Palabras = { "CAMA", "COMER", "ORO", "BEBE", "ARCO", "BARCO", "BOCA" };
        int[] PuntosP = { 4, 8, 10, 4, 6, 2, 6 };



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                if ((string.Compare(txtPalabra.Text, Palabras[i]) == 0))
                {

                    c = c + PuntosP[i];
                    String convPuntos = Convert.ToString(c);
                    txtPuntos.Text = convPuntos;
                    txtPalabra.Text = "";
                }
            }
            txtPalabra.Text = "";

        }

        private void btA_Click(object sender, EventArgs e)
        {
            txtPalabra.Text += "A";
        }

        private void btE_Click(object sender, EventArgs e)
        {
            txtPalabra.Text += "E";
        }

        private void btO_Click(object sender, EventArgs e)
        {
            txtPalabra.Text += "O";
        }

        private void btC_Click(object sender, EventArgs e)
        {
            txtPalabra.Text += "C";
        }

        private void btM_Click(object sender, EventArgs e)
        {
            txtPalabra.Text += "M";
        }

        private void btB_Click(object sender, EventArgs e)
        {
            txtPalabra.Text += "B";
        }

        private void btR_Click(object sender, EventArgs e)
        {
            txtPalabra.Text += "R";
        }
    }
}
