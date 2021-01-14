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
        private void approximationFirst()
        {
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
