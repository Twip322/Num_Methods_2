using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Num_Mehods_6
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[] xLine = { 0.351,0.664,0.978,1.291,1.605,1.918,2.232,2.546,2.859 };
        double[] yLine = { 0.605, 0.265, 0.064, 0.116, 0.415, 0.728, 1.673, 3.138, 5.092 };
        double x0;

        private double[] reverse1(double[] triangleFunX,double[] triangleFunY)
        {
            double[] triRev=new double[triangleFunX.Length];
            for(int i=0;i<triRev.Length;i++)
            {
                triRev[i] = triangleFunX[i];
            }
            triRev[0] = triangleFunY[0];
            triRev[3] = triangleFunY[1];
            triRev[6] = triangleFunY[2];
            return triRev;
        }
        private double[] reverse2(double[] triangleFunX, double[] triangleFunY)
        {
            double[] triRev = new double[triangleFunX.Length];
            for (int i = 0; i < triRev.Length; i++)
            {
                triRev[i] = triangleFunX[i];
            }
            triRev[1] = triangleFunY[0];
            triRev[4] = triangleFunY[1];
            triRev[7] = triangleFunY[2];
            return triRev;
        }
        private double[] reverse3(double[] triangleFunX, double[] triangleFunY)
        {
            double[] triRev = new double[triangleFunX.Length];
            for (int i = 0; i < triRev.Length; i++)
            {
                triRev[i] = triangleFunX[i];
            }
            triRev[2] = triangleFunY[0];
            triRev[5] = triangleFunY[1];
            triRev[8] = triangleFunY[2];
            return triRev;
        }
        private double triangle(double[] triangleFunX)
        {
            double triunder;
            return triunder = triangleFunX[0] * triangleFunX[4] * triangleFunX[8] + triangleFunX[1] * triangleFunX[5] * triangleFunX[6] + triangleFunX[2] * triangleFunX[3] * triangleFunX[7] - triangleFunX[2] * triangleFunX[4] * triangleFunX[6] - triangleFunX[0] * triangleFunX[5] * triangleFunX[7] - triangleFunX[1] * triangleFunX[3] * triangleFunX[8];
        }
        private void approximationFirst()
        {
            double x4=0;
            for(int i=0;i<xLine.Length; i++)
            {
                x4 += Math.Pow(xLine[i], 4);
            }
            double x3 = 0;
            for (int i = 0; i < xLine.Length; i++)
            {
                x3 += Math.Pow(xLine[i], 3);
            }
            double x2 = 0;
            for (int i = 0; i < xLine.Length; i++)
            {
                x2 += Math.Pow(xLine[i], 2);
            }
            double x2y = 0;
            for (int i = 0; i < xLine.Length; i++)
            {
                x2y += Math.Pow(xLine[i], 2)*yLine[i];
            }
            double xy = 0;
            for (int i = 0; i < xLine.Length; i++)
            {
                xy += xLine[i]*yLine[i];
            }
            double x = 0;
            for (int i = 0; i < xLine.Length; i++)
            {
                x += xLine[i];
            }
            double y = 0;
            for (int i = 0; i < xLine.Length; i++)
            {
                y += yLine[i];
            }
            double[] triangleFunX = {x4,x3,x2,x3,x2,x,x2,x,9};
            double[] triangleFunY = {x2y,xy,y};
            double triangleUnder = triangle(triangleFunX);
            double triangle1 = triangle(reverse1(triangleFunX, triangleFunY));
            double triangle2 = triangle(reverse2(triangleFunX, triangleFunY));
            double triangle3 = triangle(reverse3(triangleFunX, triangleFunY));
            double a = triangle1/triangleUnder;
            double b = triangle2/triangleUnder;
            double c = triangle3/triangleUnder;
            richTextBoxLag.Text += $"Аналитическая формула первой функции:y={Math.Round(a,4)}*x^2{Math.Round(b,4)}*x+{Math.Round(c, 4)} \n";
            double disre = 0;
            for(int i=0;i<xLine.Length;i++)
            {
                disre += Math.Pow((a * (Math.Pow(xLine[i], 2)) + b * xLine[i] + c) - yLine[i],2) ;
            }
            disre = Math.Sqrt(disre);
            richTextBoxLag.Text += $"Невязка первой функции: {Math.Round(disre,4)} \n";
            double func = a * (Math.Pow(x0, 2)) + b * x0 + c;
            //int count = Math.Abs((int)Math.Log10(x0));
            richTextBoxLag.Text += $"Функция в точке {x0} = {Math.Round(func, 4)} \n";
        }

        private void approximationSecond()
        {
            double x = 0;
            for (int i = 0; i < xLine.Length; i++)
            {
                x += xLine[i];
            }
            double y = 0;
            for (int i = 0; i < yLine.Length; i++)
            {
                y += yLine[i];
            }
            double x2 = 0;
            for (int i = 0; i < xLine.Length; i++)
            {
                x2 += Math.Pow(xLine[i],2);
            }
            double e = 0;
            for (int i = 0; i < xLine.Length; i++)
            {
                e += Math.Exp(-xLine[i]);
            }
            double xe = 0;
            for (int i = 0; i < xLine.Length; i++)
            {
               xe += xLine[i]*Math.Exp(-xLine[i]);
            }
            double e2 = 0;
            for (int i = 0; i < xLine.Length; i++)
            {
                e2 += Math.Pow(Math.Exp(-xLine[i]),2);
            }
            double xy = 0;
            for (int i = 0; i < xLine.Length; i++)
            {
                xy += xLine[i]*yLine[i];
            }
            double ey = 0;
            for (int i = 0; i < xLine.Length; i++)
            {
                ey += Math.Exp(-xLine[i])*yLine[i];
            }
            double[] triangleFunX = { x2, xe, x, xe, e2, e, x, e, 9 };
            double[] triangleFunY = { xy, ey, y };
            double triangleUnder = triangle(triangleFunX);
            double triangle1 = triangle(reverse1(triangleFunX, triangleFunY));
            double triangle2 = triangle(reverse2(triangleFunX, triangleFunY));
            double triangle3 = triangle(reverse3(triangleFunX, triangleFunY));
            double a = triangle1 / triangleUnder;
            double b = triangle2 / triangleUnder;
            double c = triangle3 / triangleUnder;
            richTextBoxLag.Text += $"Аналитическая формула второй функции:y={Math.Round(a, 4)}*x+{Math.Round(b, 4)}*e^-x+{Math.Round(c, 4)} \n";
            double disre = 0;
            for (int i = 0; i < xLine.Length; i++)
            {
                disre += Math.Pow(a * xLine[i] + b * Math.Exp(-xLine[i]) + c-yLine[i], 2);
            }
            disre = Math.Sqrt(disre);
            richTextBoxLag.Text += $"Невязка  функции: {Math.Round(disre, 4)} \n";
            double func = a * x0 + b * Math.Exp(-x0) + c;
            //int count = Math.Abs((int)Math.Log10(x0));
            richTextBoxLag.Text += $"Функция в точке {x0} = {Math.Round(func, 4)}\n";
        }

        private void Start_Click(object sender, EventArgs e)
        {
            richTextBoxLag.Text = "";
            x0 = Convert.ToDouble(textBoxfirst.Text);
            approximationFirst();
            approximationSecond();
        }
    }
}
