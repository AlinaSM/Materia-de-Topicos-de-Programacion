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

namespace FiguraLogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
           
            
            g.TranslateTransform(0, 0);
            Pen lapizNegro = new Pen(Color.Black, 1);
            
            g.SmoothingMode = SmoothingMode.HighQuality;



            /*   Brochas   */
            SolidBrush brochaSolidaNegro = new SolidBrush(Color.Black);
            SolidBrush brochaSolidaInterior = new SolidBrush(Color.Silver);
            SolidBrush brochaSolidaDorada = new SolidBrush(Color.DarkGoldenrod);
            SolidBrush brochaSolidaPlateada = new SolidBrush(Color.WhiteSmoke);


            /*      La parte del arco superior  */

            Rectangle rect1 = new Rectangle(40, 120, 720, 80);
            Rectangle rect2 = new Rectangle(60, 140, 680, 80);

            g.DrawArc(lapizNegro, rect1, 180, 180);
            g.DrawArc(lapizNegro, rect2, 180, 180);

            /*      Las tartas del dibujo  */

            Rectangle rectP1 = new Rectangle(68, 188, 50, 50);

           

            /*  Lineas Laterales   */

            //Linea lado izquierdo
            Point aLinea = new Point(60, 180);
            Point bLinea = new Point(60, 360);
            g.DrawLine(lapizNegro, aLinea, bLinea);

            Point a1_Linea = new Point(40, 160);
            Point b1_Linea = new Point(40, 380);
            g.DrawLine(lapizNegro, a1_Linea, b1_Linea);

            //Linea lado derecho
            Point cLinea = new Point(760, 160);
            Point dLinea = new Point(760, 380);
            g.DrawLine(lapizNegro, cLinea, dLinea);

            Point c1_Linea = new Point(740, 180);
            Point d1_Linea = new Point(740, 360);
            g.DrawLine(lapizNegro, c1_Linea, d1_Linea);

            //Lineas Inclinadas
            Point LineaInclinadaA1 = new Point(40, 160);
            Point LineaInclinadaA2 = new Point(60, 180);


            Point LineaInclinadaB1 = new Point(760, 160);
            Point LineaInclinadaB2 = new Point(740, 180);


            /*   Curva Inferior   */
            Point[] puntosI = {
                new Point(40,380),
                new Point(220,420),
                new Point(400,440),
                new Point(600,420),
                new Point(760,380)
            };

            Point[] puntosS = {
                new Point(60,360),
                new Point(220,400),
                new Point(400,420),
                new Point(600,400),
                new Point(740,360)
            };

            g.DrawCurve(lapizNegro, puntosI);
            g.DrawCurve(lapizNegro, puntosS);




            /*       Elipse      */
            Rectangle rectOvalo1 = new Rectangle(200, 260, 120, 40);
            Rectangle rectOvalo2 = new Rectangle(480, 260, 120, 40);

            
            /*      Poligono del centro     */
            PointF[] figuraCentral = { 
                    
                    new Point(340,419),
                    new Point(372,400),
                    new Point(380,320),
                    new Point(388,320),
                    new Point(388,304),
                    new Point(392,292),
                    new Point(396,292),
                    new Point(396,284),
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
                    new Point(460,419)                 
                                     
                    };
            /*  Decorados   */
            PointF[] ed1 = {
                   new Point(196,395),
                   new Point(180,392),
                   new Point(180,356),
                   new Point(204,356),
                   new Point(204,372),
                   new Point(196,372),
                   new Point(196,395),
                   new Point(216,399),
                   new Point(216,372),
                   new Point(196,372)
                   

                 };

            PointF[] ed2 = {
                   new Point(252,372),
                   new Point(252,408),
                   new Point(280,412),
                   new Point(280,348)
                   };

            PointF[] edi3 = {
                     new Point(340,419),
                     new Point(320,416),
                     new Point(320,368),
                     new Point(328,368),
                     new Point(340,380)
                     };

            PointF[] edi4 = {
                     new Point(540,409),
                     new Point(520,412),
                     new Point(520,360),
                     new Point(540,340)   
                     };

            PointF[] baseEdi= {
                     new Point(680,380),
                     new Point(600,400),
                     new Point(600,380),
                     };

            PointF[] supTri1 = {
                     new Point(180,188),
                     new Point(316,172),
                     new Point(316,200),
                     };

            PointF[] supTri2 = {
                     new Point(640,188),
                     new Point(484,172),
                     new Point(484,200),
                     };

            PointF[] SupTri3 = {
                     new Point(364,208),
                     new Point(332,200),
                     new Point(332,168),
                     new Point(352,188),
                     new Point(364,188)
                     };

            PointF[] SupTri4 = {
                         new Point(468,200),
                         new Point(436,208),
                         new Point(436,188),
                         new Point(452,188),
                         new Point(468,168)
                     };

            PointF[] SupTri5 = {
                         new Point(392,212),
                         new Point(372,208),
                         new Point(372,184),
                         new Point(392,160)
                     };

            PointF[] SupTri6 = {
                         new Point(408,212),
                         new Point(428,208),
                         new Point(428,184),
                         new Point(408,160)
                     };

            PointF[] SupTri7 = {
                         new Point(396,212),
                         new Point(396,180),
                         new Point(404,172),
                         new Point(404,212),
                         new Point(400,213)
                     };



            Rectangle rect1AdornoSup = new Rectangle(320, 164, 8, 44);
            Rectangle rect2AdornoSup = new Rectangle(472, 164, 8, 44); 


            //Exterior del logo

            GraphicsPath trazadoSupArc = new GraphicsPath();

            trazadoSupArc.AddArc(rect1, 180, 180);
            trazadoSupArc.AddLine(a1_Linea, b1_Linea);
            trazadoSupArc.AddCurve(puntosI);
            trazadoSupArc.AddLine(dLinea, cLinea);

            g.FillPath(brochaSolidaNegro, trazadoSupArc);


            //Interior del logo
            GraphicsPath trazadoInterior = new GraphicsPath();
            trazadoInterior.AddArc(rect2, 180, 180);
            trazadoInterior.AddLine(aLinea, bLinea);
            trazadoInterior.AddCurve(puntosS);
            trazadoInterior.AddLine(d1_Linea, c1_Linea);

            GraphicsPath trazadoFiguraC = new GraphicsPath();


            g.FillPath(brochaSolidaInterior, trazadoInterior);


            g.DrawLine(lapizNegro, LineaInclinadaA1, LineaInclinadaA2);
            g.DrawLine(lapizNegro, LineaInclinadaB1, LineaInclinadaB2);


            g.DrawEllipse(lapizNegro, rectOvalo1);
            g.DrawEllipse(lapizNegro, rectOvalo2);
            g.FillEllipse(brochaSolidaDorada, rectOvalo1);
            g.FillEllipse(brochaSolidaDorada, rectOvalo2);
            g.FillPolygon(brochaSolidaPlateada, figuraCentral);
            g.DrawPolygon(lapizNegro, figuraCentral);
            g.DrawPolygon(lapizNegro, ed1);
            g.FillPolygon(brochaSolidaDorada, ed1);
            g.DrawPolygon(lapizNegro, ed1);

            //Esquina superior izquierda.
            g.FillPie(brochaSolidaDorada, 44, 164, 48, 48, 340, 110);
            g.DrawPie(lapizNegro, 44, 164, 48, 48, 340, 110);
            
            //Esquina Superior Derecha
            g.FillPie(brochaSolidaDorada, 708, 164, 48, 48, 90, 110);
            g.DrawPie(lapizNegro, 708, 164, 48, 48, 90, 110);

            //Esquina Inferior izquierda.
            g.FillPie(brochaSolidaDorada, 44, 324, 48, 48, -340, -110);
            g.DrawPie(lapizNegro, 44, 324, 48, 48, -340, -110);
            
            //Esquina Inferior Derecha
            g.FillPie(brochaSolidaDorada, 708, 316, 48, 48, -90, -110);
            g.DrawPie(lapizNegro, 708, 316, 48, 48, -90, -110);

            
            g.DrawPolygon(lapizNegro, ed2);
            g.FillPie(brochaSolidaDorada, 252, 348, 56, 48, 180, 90);
            g.DrawPie(lapizNegro, 252, 348, 56, 48, 180, 90);
            g.FillPolygon(brochaSolidaDorada, ed2);

            g.FillRectangle(brochaSolidaDorada, rect1AdornoSup);
            g.DrawRectangle(lapizNegro, rect1AdornoSup);

            g.FillRectangle(brochaSolidaDorada, rect2AdornoSup);
            g.DrawRectangle(lapizNegro, rect2AdornoSup);

            g.FillPolygon(brochaSolidaDorada, edi3);
            g.DrawPolygon(lapizNegro, edi3);

            g.FillPolygon(brochaSolidaDorada, edi4);
            g.DrawPolygon(lapizNegro, edi4);

            g.FillPie(brochaSolidaDorada,600,340,80,80,180,180);
            g.DrawPie(lapizNegro,600, 340, 80, 80, 180, 180);
            g.FillPolygon(brochaSolidaDorada, baseEdi);
            g.DrawPolygon(lapizNegro, baseEdi);

            g.FillPolygon(brochaSolidaDorada, supTri1);
            g.DrawPolygon(lapizNegro, supTri1);

            g.FillPolygon(brochaSolidaDorada, supTri2);
            g.DrawPolygon(lapizNegro, supTri2);

            g.FillPolygon(brochaSolidaDorada, SupTri3);
            g.DrawPolygon(lapizNegro, SupTri3);

            g.FillPolygon(brochaSolidaDorada, SupTri4);
            g.DrawPolygon(lapizNegro, SupTri4);

            g.FillPolygon(brochaSolidaDorada, SupTri5);
            g.DrawPolygon(lapizNegro, SupTri5);

            g.FillPolygon(brochaSolidaDorada, SupTri6);
            g.DrawPolygon(lapizNegro, SupTri6);

            g.FillPolygon(brochaSolidaDorada, SupTri7);
            g.DrawPolygon(lapizNegro, SupTri7);

        }


    }
}




