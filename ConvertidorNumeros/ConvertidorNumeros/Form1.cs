using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertidorNumeros
{
    public partial class Form1 : Form
    {

        //Clase para convertir un valor numerico a texto
        class Conversion
        {
            public string enletras(string num)
            {
                string res, dec = "";
                Int64 entero;
                int decimales;
                double nro;

                try
                {
                    nro = Convert.ToDouble(num);
                }
                catch
                {
                    return "";
                }

                entero = Convert.ToInt64(Math.Truncate(nro));
                decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));
                if (decimales > 0)
                {
                    dec = " CON " + decimales.ToString() + "/100";
                }

                res = toText(Convert.ToDouble(entero)) + dec;
                return res;
            }

            private string toText(double value)
            {
                string Num2Text = "";
                value = Math.Truncate(value);
                if (value == 0) Num2Text = "CERO";
                else if (value == 1) Num2Text = "UNO";
                else if (value == 2) Num2Text = "DOS";
                else if (value == 3) Num2Text = "TRES";
                else if (value == 4) Num2Text = "CUATRO";
                else if (value == 5) Num2Text = "CINCO";
                else if (value == 6) Num2Text = "SEIS";
                else if (value == 7) Num2Text = "SIETE";
                else if (value == 8) Num2Text = "OCHO";
                else if (value == 9) Num2Text = "NUEVE";
                else if (value == 10) Num2Text = "DIEZ";
                else if (value == 11) Num2Text = "ONCE";
                else if (value == 12) Num2Text = "DOCE";
                else if (value == 13) Num2Text = "TRECE";
                else if (value == 14) Num2Text = "CATORCE";
                else if (value == 15) Num2Text = "QUINCE";
                else if (value < 20) Num2Text = "DIECI" + toText(value - 10);
                else if (value == 20) Num2Text = "VEINTE";
                else if (value < 30) Num2Text = "VEINTI" + toText(value - 20);
                else if (value == 30) Num2Text = "TREINTA";
                else if (value == 40) Num2Text = "CUARENTA";
                else if (value == 50) Num2Text = "CINCUENTA";
                else if (value == 60) Num2Text = "SESENTA";
                else if (value == 70) Num2Text = "SETENTA";
                else if (value == 80) Num2Text = "OCHENTA";
                else if (value == 90) Num2Text = "NOVENTA";
                else if (value < 100) Num2Text = toText(Math.Truncate(value / 10) * 10) + " Y " + toText(value % 10);
                else if (value == 100) Num2Text = "CIEN";
                else if (value < 200) Num2Text = "CIENTO " + toText(value - 100);
                else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = toText(Math.Truncate(value / 100)) + "CIENTOS";
                else if (value == 500) Num2Text = "QUINIENTOS";
                else if (value == 700) Num2Text = "SETECIENTOS";
                else if (value == 900) Num2Text = "NOVECIENTOS";
                else if (value < 1000) Num2Text = toText(Math.Truncate(value / 100) * 100) + " " + toText(value % 100);
                else if (value == 1000) Num2Text = "MIL";
                else if (value < 2000) Num2Text = "MIL " + toText(value % 1000);
                else if (value < 1000000)
                {
                    Num2Text = toText(Math.Truncate(value / 1000)) + " MIL";
                    if ((value % 1000) > 0) Num2Text = Num2Text + " " + toText(value % 1000);
                }

                else if (value == 1000000) Num2Text = "UN MILLON";
                else if (value < 2000000) Num2Text = "UN MILLON " + toText(value % 1000000);
                else if (value < 1000000000000)
                {
                    Num2Text = toText(Math.Truncate(value / 1000000)) + " MILLONES ";
                    if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000) * 1000000);
                }

                else if (value == 1000000000000) Num2Text = "UN BILLON";
                else if (value < 2000000000000) Num2Text = "UN BILLON " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);

                else
                {
                    Num2Text = toText(Math.Truncate(value / 1000000000000)) + " BILLONES";
                    if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
                }
                return Num2Text;

            }

        }  //Termina la clase de convercion de valor nuemerico a texto
      
       
        class Ubicacion{

            public int DineroX(int c)
            {
                int n = 0;

                if ((c == 0) || (c == 1) || (c == 2) || (c == 3) || (c == 4)) { n = 185; }
                if ((c == 5) || (c == 6) || (c == 7) || (c == 8)) { n = 470; }
                return n;
            }

            public int DineroY(int c)
            {
                int n = 0;
                if (c == 0) { n = 170; }
                if (c == 1) { n = 244; }
                if (c == 2) { n = 320; }
                if (c == 3) { n = 390; }
                if (c == 4) { n = 467; }
                if (c == 5) { n = 170; }
                if (c == 6) { n = 255; }
                if (c == 7) { n = 355; }
                if (c == 8) { n = 455; }

                return n;
            }

            public int CajaCantX(int c)
            {
                int n = 0;

                if ((c == 0) || (c == 1) || (c == 2) || (c == 3) || (c == 4)) { n = 90; }
                if ((c == 5) || (c == 6) || (c == 7) || (c == 8)) { n = 395; }
                return n;
            }

            public int CajaCantY(int c)
            {
                int n = 0;

                if (c == 0) { n = 195; }
                if (c == 1) { n = 268; }
                if (c == 2) { n = 345; }
                if (c == 3) { n = 414; }
                if (c == 4) { n = 467; }
                if (c == 5) { n = 198; }
                if (c == 6) { n = 287; }
                if (c == 7) { n = 390; }
                if (c == 8) { n = 487; }

                return n;
            }

            public int EtiqPorX(int c)
            {
                int n = 0;

                if ((c == 0) || (c == 1) || (c == 2) || (c == 3) || (c == 4)) { n = 146; }
                if ((c == 5) || (c == 6) || (c == 7) || (c == 8)) { n = 435; }
                return n;
            }

            public int EtiqPorY(int c)
            {
                int n = 0;

                if (c == 0) { n = 195; }
                if (c == 1) { n = 268; }
                if (c == 2) { n = 345; }
                if (c == 3) { n = 414; }
                if (c == 4) { n = 467; }
                if (c == 5) { n = 198; }
                if (c == 6) { n = 287; }
                if (c == 7) { n = 390; }
                if (c == 8) { n = 487; }

                return n;
            }

            public int EtiqMasX(int c)
            {
                int n = 0;

                if ((c == 1) || (c == 2) || (c == 3) || (c == 4)) { n = 70; }
                if ((c == 5) || (c == 6) || (c == 7) || (c == 8)) { n = 360; }
                return n;
            }

            public int EtiqMasY(int c)
            {
                int n = 0;

                if (c == 1) { n = 244; }
                if (c == 2) { n = 317; }
                if (c == 3) { n = 394; }
                if (c == 4) { n = 463; }
                if (c == 5) { n = 170; }
                if (c == 6) { n = 244; }
                if (c == 7) { n = 346; }
                if (c == 8) { n = 463; }

                return n;
            }
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                txb_Letra.Text = "";
                ptb_Mil.Hide();
                ptb_quinientos.Hide();
                ptb_doscientos.Hide();
                ptb_cien.Hide();
                ptb_cincuenta.Hide();
                ptb_veinte.Hide();
                ptb_diez.Hide();
                ptb_cinco.Hide();
                ptb_uno.Hide();

                txb_cantMil.Hide();
                txb_cantQuinientos.Hide();
                txb_cantDoscientos.Hide();
                txb_cantCien.Hide();
                txb_cantCincuenta.Hide();
                txb_cantVeinte.Hide();
                txb_cantDiez.Hide();
                txb_cantCinco.Hide();
                txb_cantUno.Hide();

                x1.Hide();
                x2.Hide();
                x3.Hide();
                x4.Hide();
                x5.Hide();
                x6.Hide();
                x7.Hide();
                x8.Hide();
                x9.Hide();

                mas1.Hide();
                mas2.Hide();
                mas3.Hide();
                mas4.Hide();
                mas5.Hide();
                mas6.Hide();
                mas7.Hide();
                mas8.Hide();

                Ubicacion loc = new Ubicacion();


                if ((Convert.ToInt32(txb_Cantidad.Text)) <= 0)
                {
                    MessageBox.Show("Introdusca numeros mayores de 0");
                    txb_Cantidad.Text = "";
                }
                else
                {
                    Conversion conver = new Conversion();

                    txb_Letra.Text = conver.enletras(txb_Cantidad.Text);
                }


                int N;
                N = Convert.ToInt32(txb_Cantidad.Text);


                int c = 0;
                int Ncantidad;
                int Nmodulo;
                int x = 185;
                int y = 170;

                Ncantidad = N / 1000;
                Nmodulo = N % 1000;

                if (Ncantidad > 0)
                {

                    ptb_Mil.Location = new Point(loc.DineroX(c), loc.DineroY(c));
                    ptb_Mil.Show();

                    txb_cantMil.Location = new Point(loc.CajaCantX(c), loc.CajaCantY(c));
                    txb_cantMil.Show();

                    x1.Location = new Point(loc.EtiqPorX(c), loc.EtiqPorY(c));
                    x1.Show();

                    txb_cantMil.Text = Ncantidad.ToString();
                    c++;
                }

                Ncantidad = Nmodulo / 500;
                Nmodulo = Nmodulo % 500;

                if (Ncantidad > 0)
                {

                    mas1.Location = new Point(loc.EtiqMasX(c), loc.EtiqMasY(c));
                    mas1.Show();

                    x2.Location = new Point(loc.EtiqPorX(c), loc.EtiqPorY(c));
                    x2.Show();

                    ptb_quinientos.Location = new Point(loc.DineroX(c), loc.DineroY(c));
                    ptb_quinientos.Show();
                    txb_cantQuinientos.Location = new Point(loc.CajaCantX(c), loc.CajaCantY(c));
                    txb_cantQuinientos.Show();
                    txb_cantQuinientos.Text = Ncantidad.ToString();
                    c++;
                }

                Ncantidad = Nmodulo / 200;
                Nmodulo = Nmodulo % 200;

                if (Ncantidad > 0)
                {

                    mas2.Location = new Point(loc.EtiqMasX(c), loc.EtiqMasY(c));
                    mas2.Show();

                    x3.Location = new Point(loc.EtiqPorX(c), loc.EtiqPorY(c));
                    x3.Show();

                    ptb_doscientos.Location = new Point(loc.DineroX(c), loc.DineroY(c));
                    ptb_doscientos.Show();
                    txb_cantDoscientos.Location = new Point(loc.CajaCantX(c), loc.CajaCantY(c));
                    txb_cantDoscientos.Show();
                    txb_cantDoscientos.Text = Ncantidad.ToString();
                    c++;
                }

                Ncantidad = Nmodulo / 100;
                Nmodulo = Nmodulo % 100;

                if (Ncantidad > 0)
                {

                    mas3.Location = new Point(loc.EtiqMasX(c), loc.EtiqMasY(c));
                    mas3.Show();

                    x4.Location = new Point(loc.EtiqPorX(c), loc.EtiqPorY(c));
                    x4.Show();

                    ptb_cien.Location = new Point(loc.DineroX(c), loc.DineroY(c));
                    ptb_cien.Show();
                    txb_cantCien.Location = new Point(loc.CajaCantX(c), loc.CajaCantY(c));
                    txb_cantCien.Show();
                    txb_cantCien.Text = Ncantidad.ToString();
                    c++;
                }

                Ncantidad = Nmodulo / 50;
                Nmodulo = Nmodulo % 50;

                if (Ncantidad > 0)
                {
                    mas4.Location = new Point(loc.EtiqMasX(c), loc.EtiqMasY(c));
                    mas4.Show();

                    x5.Location = new Point(loc.EtiqPorX(c), loc.EtiqPorY(c));
                    x5.Show();

                    ptb_cincuenta.Location = new Point(loc.DineroX(c), loc.DineroY(c));
                    ptb_cincuenta.Show();
                    txb_cantCincuenta.Location = new Point(loc.CajaCantX(c), loc.CajaCantY(c));
                    txb_cantCincuenta.Show();
                    txb_cantCincuenta.Text = Ncantidad.ToString();
                    c++;
                }

                Ncantidad = Nmodulo / 20;
                Nmodulo = Nmodulo % 20;

                if (Ncantidad > 0)
                {
                    mas5.Location = new Point(loc.EtiqMasX(c), loc.EtiqMasY(c));
                    mas5.Show();

                    x6.Location = new Point(loc.EtiqPorX(c), loc.EtiqPorY(c));
                    x6.Show();

                    ptb_veinte.Location = new Point(loc.DineroX(c), loc.DineroY(c));
                    ptb_veinte.Show();
                    txb_cantVeinte.Location = new Point(loc.CajaCantX(c), loc.CajaCantY(c));
                    txb_cantVeinte.Show();
                    txb_cantVeinte.Text = Ncantidad.ToString();
                    c++;
                }

                Ncantidad = Nmodulo / 10;
                Nmodulo = Nmodulo % 10;

                if (Ncantidad > 0)
                {
                    mas6.Location = new Point(loc.EtiqMasX(c), loc.EtiqMasY(c));
                    mas6.Show();

                    x7.Location = new Point(loc.EtiqPorX(c), loc.EtiqPorY(c));
                    x7.Show();

                    ptb_diez.Location = new Point(loc.DineroX(c), loc.DineroY(c));
                    ptb_diez.Show();
                    txb_cantDiez.Location = new Point(loc.CajaCantX(c), loc.CajaCantY(c));
                    txb_cantDiez.Show();
                    txb_cantDiez.Text = Ncantidad.ToString();
                    c++;
                }

                Ncantidad = Nmodulo / 5;
                Nmodulo = Nmodulo % 5;

                if (Ncantidad > 0)
                {
                    mas7.Show();
                    mas7.Location = new Point(loc.EtiqMasX(c), loc.EtiqMasY(c));

                    x8.Location = new Point(loc.EtiqPorX(c), loc.EtiqPorY(c));
                    x8.Show();

                    ptb_cinco.Location = new Point(loc.DineroX(c), loc.DineroY(c));
                    ptb_cinco.Show();
                    txb_cantCinco.Location = new Point(loc.CajaCantX(c), loc.CajaCantY(c));
                    txb_cantCinco.Show();
                    txb_cantCinco.Text = Ncantidad.ToString();
                    c++;
                }
                Ncantidad = Nmodulo / 1;
                Nmodulo = Nmodulo % 1;

                if (Ncantidad > 0)
                {
                    mas8.Show();
                    mas8.Location = new Point(loc.EtiqMasX(c), loc.EtiqMasY(c));

                    x9.Location = new Point(loc.EtiqPorX(c), loc.EtiqPorY(c));
                    x9.Show();

                    ptb_uno.Location = new Point(loc.DineroX(c), loc.DineroY(c));
                    ptb_uno.Show();
                    txb_cantUno.Location = new Point(loc.CajaCantX(c), loc.CajaCantY(c));
                    txb_cantUno.Show();
                    txb_cantUno.Text = Ncantidad.ToString();
                    c++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Introdusca el numero en su formato numerico.");
               
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
