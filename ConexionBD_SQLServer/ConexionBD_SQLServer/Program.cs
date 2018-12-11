using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace ConexionBD_SQLServer
{
    class Program
    {
        public class BaseDeDatos
        {

            private SqlConnection ConexionConBD;
            private SqlCommand Orden;
            private SqlDataReader Lector;

            public void LeerDeBaseDeDatos()
            {
                //Crear la conexion con la base de datos
                String strConexion = "Data Source=LAPTOP-5BJT01BC\\SQLEXPRESS;Initial Catalog=bd_telefonos;Integrated Security=True";
                ConexionConBD = new SqlConnection(strConexion);

                // Crear consulta
                string Consulta = "SELECT nombre,telefono FROM telefonos";
                Orden = new SqlCommand(Consulta, ConexionConBD);
                
                //Abrir la base de datos 
                ConexionConBD.Open();

                //ExectuReader hace la consutla y devuelve un OleBdDataReader
                Lector = Orden.ExecuteReader();

                //Llamar siempre a Read antes de acceder a los datos
                while (Lector.Read()) //siguiente registro
                    Console.WriteLine(Lector["nombre"] + " " + Lector["telefono"]);

                //Llamar siempre a Close  una vez finalizada la lectura
                Lector.Close();
                Console.ReadKey();

            }

            public void CerrarConexion()
            {
                // Cerrar conexion cuando no sea necesaria
                if (Lector != null)
                    Lector.Close();
                if (ConexionConBD != null)
                    ConexionConBD.Close();


            }

            static void Main(string[] args)
            {
                BaseDeDatos bd = new BaseDeDatos();
                try
                {
                    bd.LeerDeBaseDeDatos();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
                finally
                {
                    bd.CerrarConexion();
                }



            }

        }
    }
}
