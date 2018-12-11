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


namespace Actividad1VincularControles
{
    public partial class Form1 : Form
    {
   

        public Form1()
        {
            InitializeComponent();
        }

        private void mostrarPosicion() { 
            
            //Total de registros
            int iTotal = telefonosBindingSource1.Count;

            //Numeros(1,2,...) de registro
            int iPos;

            if (iTotal == 0)
                etPosicion.Text = "No registros";
            else {
                iPos = telefonosBindingSource1.Position + 1;

                //Mostrar informacion en la etiqueta
                etPosicion.Text = iPos.ToString() + " de " + iTotal.ToString();
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTelefonos.telefonos' Puede moverla o quitarla según sea necesario.
            this.telefonosTableAdapter.Fill(this.dsTelefonos.telefonos);
           // txbNombre.DataBindings.Add("Text", telefonosBindingSource, "telefonos.nombre");

            mostrarPosicion();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            telefonosBindingSource1.Position = 0;
            mostrarPosicion();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            telefonosBindingSource1.Position -= 1;
            mostrarPosicion();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            telefonosBindingSource1.Position += 1;
            mostrarPosicion();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            telefonosBindingSource1.Position = telefonosBindingSource1.Count - 1;
            mostrarPosicion();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            DataTable miTabla = dsTelefonos.telefonos;
            DataRowCollection cFilas = miTabla.Rows;
            DataRow nuevaFila;

            try
            {
                // Nueva fila
                nuevaFila = miTabla.NewRow();

                //Datos por omision para las columna de la nueva fila
                nuevaFila[0] = "Nombre";        //Columna 0
                nuevaFila[1] = "Direccion";     //Columna 1
                nuevaFila[2] = "Telefono";      //Columna 2
                nuevaFila[3] = "Notas";         //Columna 3
                
                cFilas.Add(nuevaFila);
                btnUltimo.PerformClick();   //Hacer clic en ultimo
                mostrarPosicion();
                txbNombre.Focus();
            }
            catch (ConstraintException ex) { 
                //Capturar posible error por clave duplicada (telefonos)
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DataRowView vistaFilaActual;
            string NL = Environment.NewLine;

            if (MessageBox.Show("¿Desea borrar este registro?" +
                NL, "Buscar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                    vistaFilaActual = ((DataRowView)telefonosBindingSource1.Current);
                    vistaFilaActual.Row.Delete();
                    mostrarPosicion();
                } 

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable miTabla = dsTelefonos.telefonos;
            DataRowCollection cFilas = miTabla.Rows;
            DataRow[] filaBusqueda; //Matriz de Filas
            string NL = Environment.NewLine;

            // Buscar la columna Nombre de cada fila
            string criterio = "Nombre Like '*" + txbBuscar.Text + "*'";
 
            /*  Utilizar el metodo Select para encontrar todas las filas que 
                pasen el filtro y almacenarlas en la matriz filaBusqueda      */

            filaBusqueda = miTabla.Select(criterio);

            if (filaBusqueda.GetUpperBound(0) == 1) {
                MessageBox.Show("No se encontraron los registros coincidentes", "Buscar");
                return;
            }

            //Seleccionar de las filas encontrada la que buscamos

            int i, j;

            for (i = 0; i <= filaBusqueda.GetUpperBound(0); i++) {

                if (MessageBox.Show("¿Es este el nombre buscado?" + NL +
                    (string)filaBusqueda[i]["nombre"] + NL, "Buscar", MessageBoxButtons.YesNo) == DialogResult.Yes) { 
                        
                    //  Si: mostrar en el formulario la fila seleccionada
                    for(j=0;j<=cFilas.Count -1;j++)
                        if (cFilas[j].Equals(filaBusqueda[i])) {
                            telefonosBindingSource1.Position = j;
                            mostrarPosicion();
                        }
                    break;
                }
            
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dsTelefonos.HasChanges()) {
                telefonosTableAdapter.Update(dsTelefonos.telefonos);
                MessageBox.Show("Origen de datos acrualizado");
            }
        }

    }
}
