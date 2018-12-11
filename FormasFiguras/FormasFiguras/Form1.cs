using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace FormasFiguras
{
    public partial class Form1 : Form
    {
        private Color colorFondo;
        private Color colorPrimerPlano;

        
        public Form1()
        {
            InitializeComponent();
            Graphics g = this.CreateGraphics();
        }

       

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private Graphics ObtenerObjetoGraphics() {
            Bitmap mapaBits = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = mapaBits;
            Graphics g = Graphics.FromImage(mapaBits);
            return g;
        }

         

        private void Form1_Load(object sender, EventArgs e)
        {
            colorFondo = Color.White;
            colorPrimerPlano = Color.Black;
            pictureBox1.BackColor = colorFondo;
        }
        
        /*
         * LINEAS Y RECTAS
        */
        private void btn_LineasRectangulos_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black, 3);
            g.DrawLine(lapiz, 10, 10, 240, 100);

            g.DrawRectangle(lapiz, 50, 80, 200, 100);

            Rectangle rect = new Rectangle(50, 80, 200, 100);
            g.DrawRectangle(lapiz, rect);
        }

        /*
         * ELIPSES Y ARCOS         
         */

        private void btn_ElipsesArcos_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);
            lapiz.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            g.DrawRectangle(lapiz, 10, 10, 230, 90);
            lapiz = new Pen(Color.Black, 3);
            g.DrawEllipse(lapiz, 10, 10, 230, 90);

            Rectangle rect = new Rectangle(10, 120, 230, 90);
            lapiz = new Pen(Color.Black, 3);
            lapiz.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            g.DrawEllipse(lapiz, rect);
            lapiz = new Pen(Color.Red, 3);
            g.DrawArc(lapiz, rect, 30, 10);

        }

        /*
         * TARTAS
         */

        private void btn_Tartas_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Blue);
            Rectangle rect = new Rectangle(10, 10, 40, 40);
            g.DrawPie(lapiz, rect, 180, 90);

        }

        /*
         * POLIGONOS         
         */

        private void btn_Poligonos_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Red);


            //Matriz de objetos Point(PointF)
            PointF[] pentagono = { 
                      new Point(20,150),
                      new Point(130,120),
                      new Point(230,155),
                      new Point(190,200),
                      new Point(45,195)                   
             };
            g.DrawPolygon(lapiz, pentagono);
        }

        /*
         * CURVAS
         */

        private void btn_Curvas_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen lapizRojo = new Pen(Color.Red);
            Pen lapizVerde = new Pen(Color.Green);
            Pen lapizNegro = new Pen(Color.Black);

            //Puntos que define la curva flexible cardinal//
            Point[] puntos = { 
                     //new Point(25,25),
                     //new Point(50,15),
                     //new Point(100,5),
                     //new Point(120,25),
                     //new Point(150,50),
                     //new Point(220,200),
                     //new Point(120,120)

                           new Point(340,420),
                    new Point(372,400),
                    new Point(380,320),
                    new Point(388,320),
                    new Point(388,304),
                    new Point(392,292),
                    new Point(392,284),
                    new Point(380,272),
                    new Point(388,240),
                    new Point(392,240),
                    new Point(392,268),
                    new Point(396,268),
                    new Point(396,260),
                    new Point(404,260),
                    new Point(404,268),
                    new Point(408,268),
                    new Point(408,240),
                    new Point(412,240),
                    new Point(420,272),
                    new Point(404,284),
                    new Point(404,292),
                    new Point(408,292),
                    new Point(412,304),
                    new Point(412,320),
                    new Point(420,320),
                    new Point(428,400),
                    new Point(460,420)                 
                                     

                  };
            //Dbujar lineas entre los puntos
            g.DrawLines(lapizRojo, puntos);
            //Dibujar la curva
            g.DrawCurve(lapizVerde, puntos);

            
            //Puntos que definen la curva flexible de Bezier
            Point p1 = new Point(30, 120);
            Point p2 = new Point(150, 200);
            Point c1 = new Point(75, 10);
            Point c2 = new Point(50, 210);
            //Dibujar la curva
            g.DrawBezier(lapizNegro, p1, c1, c2, p2);
            
        }
        
        private void btn_Trazados_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            GraphicsPath trazado = new GraphicsPath();
            Rectangle rect = new Rectangle(10, 10, 200, 100);

            trazado.AddArc(rect, 45, 135);
            trazado.AddLine(80, 100, 160, 200);
            trazado.CloseFigure();
            g.DrawPath(Pens.Blue, trazado); 
            

        }

        private void btn_Regiones_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();

            /*
            SolidBrush brocha = new SolidBrush(Color.Blue);
            Region region = new Region();
            g.FillRegion(brocha, region);
            */

            //Lapiz
            Pen lapiz = new Pen(Color.Black, 3);
            //Centro de superficie de dibujo
            int xCentro = pictureBox1.Width / 2;
            int yCentro = pictureBox1.Height / 2;
            // Trabformaciones: eje Y positivo hacia arriba y origen(0,0) en el centro
            g.Transform = new Matrix(1, 0, 0, -1, xCentro, yCentro);
            //Rectangulos para tres elipces
            Rectangle rect0 = new Rectangle(-50, 0, 100, 100);
            Rectangle rect1 = new Rectangle(-7, -75, 100, 100);
            Rectangle rect2 = new Rectangle(-93, -75, 100, 100);
            //Añadimos tres elipses a un trazado
            GraphicsPath trazado = new GraphicsPath();
            trazado.AddEllipse(rect0);
            trazado.AddEllipse(rect1);
            trazado.AddEllipse(rect2);
            //pintar el trazado
            g.FillPath(Brushes.Yellow, trazado);
            //Crear una region con el trazado
            Region region = new Region(trazado);
            //Definir la region de recorte:
            //Region de recorte actual interseccion objeto region
            g.SetClip(region, CombineMode.Intersect);
            //Dibujar radios desde el origen , de dos en dos grados
            float PI = 3.141596F;
            float radio = Math.Min(xCentro, yCentro);
            float a;
            float x;
            float y;

            for (a = 0; a <= 2 * PI; a += PI / 90) {
                x = System.Convert.ToSingle(radio * Math.Cos(a));
                y = System.Convert.ToSingle(radio * Math.Sin(a));
                g.DrawLine(Pens.Red, 0, 0, x, y);
            
            }




        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

    }
}
