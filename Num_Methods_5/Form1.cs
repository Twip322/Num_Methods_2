using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Num_Methods_5
{
    public partial class Form1 : Form
    {
        double[] tableX = { 0.248, 0.663, 1.238, 2.092, 2.939 };
        double[] tableY = { -3.642, 0.802, 0.841, 0.513, 0.328 };
        double x0;
        double[] differ = new double[5];
        public Form1()
        {
            InitializeComponent();
        }
        private void diff()
        {
            double[] first = new double[4];
            double[] second = new double[3];
            double[] third = new double[2];
            double fourth;
            int step = 0;
            int forstep = step + 1;
            for (int i=0;i<first.Length;i++)
            {
                first[i] = (tableY[i + 1] - tableY[i])/(tableX[forstep] - tableX[i]);
                forstep++;
            }
            step++;
            forstep = step + 1;
            for (int i=0;i<second.Length;i++)
            {
                second[i] = (first[i + 1] - first[i]) / (tableX[forstep] - tableX[i]);
                forstep++;
            }
            step++;
            forstep = step + 1;
            for (int i = 0; i < third.Length; i++)
            {
                third[i] = (second[i + 1] - second[i]) / (tableX[forstep] - tableX[i]);
                forstep++;
            }
            step++;
            forstep = step + 1;
            fourth = (third[1] - third[0]) / (tableX[forstep] - tableX[0]);
            differ[0] = Math.Round(first[0],3);
            differ[1] = Math.Round(second[0],3);
            differ[2] = Math.Round(third[0],3);
            differ[3] = Math.Round(fourth,3);
        }
        private void Lagrange()
        {
            double[] coefficients = new double[5];
            coefficients[0] = Math.Round(((1 / ((tableX[0] - tableX[1]) * (tableX[0] - tableX[2]) * (tableX[0] - tableX[3]) * (tableX[0] - tableX[4]))) * tableY[0]),3);
            coefficients[1] = Math.Round(((1 / ((tableX[1] - tableX[0]) * (tableX[1] - tableX[2]) * (tableX[1] - tableX[3]) * (tableX[1] - tableX[4]))) * tableY[1]),3);
            coefficients[2] = Math.Round(((1 / ((tableX[2] - tableX[0]) * (tableX[2] - tableX[1]) * (tableX[2] - tableX[3]) * (tableX[2] - tableX[4]))) * tableY[2]),3);
            coefficients[3] = Math.Round(((1 / ((tableX[3] - tableX[0]) * (tableX[3] - tableX[1]) * (tableX[3] - tableX[2]) * (tableX[3] - tableX[4]))) * tableY[3]),3);
            coefficients[4] = Math.Round(((1 / ((tableX[4] - tableX[0]) * (tableX[4] - tableX[1]) * (tableX[4] - tableX[2]) * (tableX[4] - tableX[3]))) * tableY[4]),3);
            double Lx = Math.Round(coefficients[0] * (x0 - tableX[1]) * (x0 - tableX[2]) * (x0 - tableX[3]) * (x0 - tableX[4]) + coefficients[1] * (x0 - tableX[0]) * (x0 - tableX[2]) * (x0 - tableX[3]) * (x0 - tableX[4]) + coefficients[2] * (x0 - tableX[0]) * (x0 - tableX[1]) * (x0 - tableX[3]) * (x0 - tableX[4]) + coefficients[3] * (x0 - tableX[0]) * (x0 - tableX[1]) * (x0 - tableX[2]) * (x0 - tableX[4]) + coefficients[4] * (x0 - tableX[0]) * (x0 - tableX[1]) * (x0 - tableX[2]) * (x0 - tableX[3]),3);
            richTextBoxLag.Text += "Лагранж : " + Lx.ToString() + '\n';
            richTextBoxLag.Text += $" Формула с коеффициентами: \n" +
                   $"{coefficients[0]}*(x - {tableX[1]})*(x - {tableX[2]})*(x - {tableX[3]})*(x - {tableX[4]})" + '\n' +
                   $"{coefficients[1]}*(x - {tableX[0]})*(x - {tableX[2]})*(x - {tableX[3]})*(x - {tableX[4]})" + '\n' +
                   $"{coefficients[2]}*(x - {tableX[0]})*(x - {tableX[1]})*(x - {tableX[3]})*(x - {tableX[4]})" + '\n' +
                   $"{coefficients[3]}*(x - {tableX[0]})*(x - {tableX[1]})*(x - {tableX[2]})*(x - {tableX[4]})" + '\n' +
                   $"{coefficients[4]}*(x - {tableX[0]})*(x - {tableX[1]})*(x - {tableX[2]})*(x - {tableX[3]})" + '\n';

        }
        private void NewTone()
        {
            double coefN=Math.Round(tableY[0] + differ[0] * (x0 - tableX[0]) + differ[1] * (x0 - tableX[0]) * (x0 - tableX[1]) + 
             differ[2] * (x0 - tableX[0]) * (x0 - tableX[1]) * (x0 - tableX[2]) +
             differ[3] * (x0 - tableX[0]) * (x0 - tableX[1]) * (x0 - tableX[2]) * (x0 - tableX[3]),3);

            richTextBoxNewNote.Text += "Ньютон : " + coefN.ToString();
            richTextBoxNewNote.Text += " Формула с коеффициентами: \n"+
                $"{tableY[0]} + {differ[0]} *(x - {tableX[0]}) + {differ[1]} * (x - {tableX[0]}) * (x - {tableX[1]}) + {differ[2]} * (x - {tableX[0]}) * (x - {tableX[1]}) * (x - {tableX[2]}) + {differ[3]} * (x - {tableX[0]}) * (x - {tableX[1]}) * (x - {tableX[2]}) * (x - {tableX[3]})";
        }
        private void Splyne()
        {
            double[] a = new double[4];
            double[] b = new double[4];
            for (int i = 0; i < a.Length; i++)
            {
                a[i]=Math.Round((tableY[i + 1] - tableY[i]) / (tableX[i + 1] - tableX[i]),3);
            }
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = Math.Round(tableY[i] - a[i] * tableX[i],3);
            }
            
            double Splx = 0.00000001;
            for (int i = 0; i < a.Length; i++)
            {
                if(x0>=tableX[i] && x0<=tableX[i+1])
                {
                    Splx = a[i] * x0 + b[i];
                }
            }
            if (Splx != 0.00000001)
            {
                richTextBoxSplyne.Text += "Сплайн равен " + Splx.ToString();
                richTextBoxSplyne.Text += $"φ(x) = \n {a[0]}x + {b[0]}, {tableX[0]}<=x<={tableX[1]}" + '\n' +
                $"{a[1]}x + {b[1]}, {tableX[1]}<=x<={tableX[2]}" + '\n' +
                $"{a[2]}x + {b[2]}, {tableX[2]}<=x<={tableX[3]}" + '\n' +
                $"{a[3]}x + {b[3]}, {tableX[3]}<=x<={tableX[4]}" + '\n';
            }
            else
                richTextBoxSplyne.Text = "X вне границ";
        }
        private void Start_Click(object sender, EventArgs e)
        {
            richTextBoxSplyne.Text = "";
            richTextBoxNewNote.Text = "";
            richTextBoxLag.Text = "";
            x0 = Convert.ToDouble(textBoxfirst.Text);
            diff();
            Lagrange();
            NewTone();
            Splyne();
        }
    }
}
