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


        private double triangle(double[] triangleFunX)
        {
            double triunder = 0;
            return triunder = triangleFunX[0] * triangleFunX[4] * triangleFunX[8] + triangleFunX[1] * triangleFunX[5] * triangleFunX[6] +
                triangleFunX[2] * triangleFunX[3] * triangleFunX[7] - triangleFunX[2] * triangleFunX[4] * triangleFunX[6] - triangleFunX[0] * triangleFunX[5] * triangleFunX[7] - triangleFunX[1] * triangleFunX[4] * triangleFunX[8];
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
            double[] tmpTrianleA=triangleFunX;

            double a = 1.6162;
            double b = -3.5722;
            double c = 1.8549;
            richTextBoxLag.Text += $"Аналитическая формула первой функции:y={a}*x^2-{b}*x+{c} \n";
            double disre = 0;
            for(int i=0;i<xLine.Length;i++)
            {
                disre += Math.Pow((a * (Math.Pow(xLine[i], 2)) + b * xLine[i] + c) - yLine[i],2) ;
            }
            disre = Math.Sqrt(disre);
            richTextBoxLag.Text += $"Невязка первой функции: {disre} \n";
            double func = a * (Math.Pow(x0, 2)) + b * x0 + c;
            richTextBoxLag.Text += $"Функция в точке {x0} = {func}";

        }

        private void Start_Click(object sender, EventArgs e)
        {
            richTextBoxLag.Text = "";
            x0 = Convert.ToDouble(textBoxfirst.Text);
            approximationFirst();
        }
    }
}
