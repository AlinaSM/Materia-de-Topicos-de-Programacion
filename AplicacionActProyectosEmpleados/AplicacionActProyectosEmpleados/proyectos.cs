using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AplicacionActProyectosEmpleados
{
    public partial class proyectos : Form
    {


        SqlDataAdapter da;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-5BJT01BC\\SQLEXPRESS;Initial Catalog=bd_AdmoProyectos;Integrated Security=True");

        public proyectos()
        {
            InitializeComponent();
        }

        private void proyectosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proyectosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsProyectos);

        }

        private void cargarDGV_Trabajadores() {
           // dgvTrabajadores.DataSource = proyectosBindingSource;
            da = new SqlDataAdapter("Select nombre FROM empleados, Empleado_Proyecto, proyectos where proyectos.proyecto = 'Realidad Virtual(VR)' AND (proyectos.id_proyecto = Empleado_Proyecto.id_proyecto)AND (Empleado_Proyecto.id_empleado = empleados.id_empleado)",con);
            
            da.Fill(dsProyectos);
            dgvTrabajadores.DataSource = dsProyectos.Tables[0];
            con.Close();
        
        }


        private void buscarProyecto() {
            

            
        }


        private void mostrarPosicion() {
            int iTotal = proyectosBindingSource.Count;

            int iPos;

            if (iTotal == 0)
                lblPosicion.Text = "NO REGISTROS";
            else {
                iPos = proyectosBindingSource.Position + 1;

                lblPosicion.Text = iPos.ToString() + " de " + iTotal.ToString();
            }
        }


        private void proyectos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsProyectos.proyectos' Puede moverla o quitarla según sea necesario.
            this.proyectosTableAdapter.Fill(this.dsProyectos.proyectos);
            cargarDGV_Trabajadores();


        }
    }
}
