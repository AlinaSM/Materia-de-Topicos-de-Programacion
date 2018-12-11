using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionActProyectosEmpleados
{
    public partial class Form1 : Form
    {
        


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
         }

        private void btnIrEmpleados_Click(object sender, EventArgs e)
        {

        }

        private void btnIrProyectos_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Close();

            proyectos p = new proyectos();
            p.Show();

  
            
        }
    }
}
