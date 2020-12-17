using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Num_Methods_4
{
    public partial class Form1 : Form
    {
        double alpha=0.15;
        public Form1()
        {
            InitializeComponent();
        }

        private void iterations()
        {
            double epsilon=Convert.ToDouble(textBoxeps.Text);
            textBoxaplh.Text = alpha.ToString();
            int count = Math.Abs((int)Math.Log10(epsilon));
            int n=0;
            double x1=0;
            double x2=0;
            double tx1=Convert.ToDouble(textBoxfirst.Text);
            double tx2= Convert.ToDouble(textBoxsecond.Text);
            double f1=0;
            double f2=0;
            double tf1;
            double tf2;
            double max=epsilon+1;
            bool first=true;
            do
            {
                if (first)
                {
                    first = false;
                    richTextBoxIter.Text += n + "  ";
                    richTextBoxIter.Text += Math.Round(tx1, count) + "  ";
                    richTextBoxIter.Text += Math.Round(tx2, count) + "  ";
                    tf1 =Math.Round(2 * ((Math.Cos(tx1 + 0.5) + tx2 - 1) * (-Math.Sin(tx1 + 0.5))) + 2 * ((Math.Sin(tx2) - 2 * tx1 - 2) * -2),count);
                    richTextBoxIter.Text += tf1 + "  ";
                    tf2 =Math.Round( 2 * ((Math.Cos(tx1 + 0.5) + tx2 - 1) * 1) + 2 * ((Math.Sin(tx2) - 2 * tx1 - 2) * Math.Cos(tx2)), count);
                    richTextBoxIter.Text += tf2;
                    richTextBoxIter.Text += '\n';
                    x1 = tx1;
                    x2 = tx2;
                    f1 = tf1;
                    f2 = tf2;
                    n++;
                    continue;
                }
                else
                {
                    richTextBoxIter.Text += n + "  ";
                    tx1 = Math.Round(x1 - f1 * alpha, count);
                    richTextBoxIter.Text += tx1 + "  ";
                    tx2 = Math.Round(x2 - f2 * alpha, count);
                    richTextBoxIter.Text += Math.Round(tx2, count) + "  ";
                    tf1 = Math.Round(2 * ((Math.Cos(tx1 + 0.5) + tx2 - 1) * (-Math.Sin(tx1 + 0.5))) + 2 * ((Math.Sin(tx2) - 2 * tx1 - 2) * -2), count);
                    richTextBoxIter.Text += tf1 + "  ";
                    tf2 = Math.Round(2 * ((Math.Cos(tx1 + 0.5) + tx2 - 1) * 1) + 2 * ((Math.Sin(tx2) - 2 * tx1 - 2) * Math.Cos(tx2)), count);
                    richTextBoxIter.Text +=tf2 + "  ";
                    max = Math.Round(Math.Max(Math.Abs(tx1 - x1), Math.Abs(tx2 - x2)), count);
                    richTextBoxIter.Text += Math.Round(max, count) + "\n";
                    x1 = tx1;
                    x2 = tx2;
                    f1 = tf1;
                    f2 = tf2;
                    n++;
                }
            } while (max > epsilon);
        }
        
        private void Start_Click(object sender, EventArgs e)
        {
            richTextBoxIter.Text = "";
            iterations();
        }
    }
}
