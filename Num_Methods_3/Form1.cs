﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Num_Methods_3
{
    public partial class Form1 : Form
    {
        private string function = "f(x)=sin(0,5x)+1-x^2";
        private double epsilon = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void iterations()
        {
            
            epsilon =Convert.ToDouble(textBoxeps.Text);
            double accur=epsilon+1;
            int n=0;
            double func = 0;
            double func1 = 0;
            double func2 = 0;
            double Xn=1;
            double Xn1=0;
            double Xn2=0;
            do
            {
                if (n > 1)
                {
                    richTextBoxIter.Text += n + "  ";
                    Xn = Xn2 - (func2 / (func1 - func2) * (Xn1 - Xn2));
                  
                    richTextBoxIter.Text += Math.Round(Xn, 6) + "  ";
                    func = Math.Round(Math.Sin(Xn / 2) + 1 - (Xn * Xn), 6);
                    richTextBoxIter.Text += func + "  ";
                    accur = Math.Round(Math.Abs(Xn - Xn1),6);
                    richTextBoxIter.Text += accur + "  ";
                    Xn2 = Xn1;
                    Xn1 = Xn;
                    func2 = func1;
                    func1 = func;
                    Xn++;
                    n++;
                    richTextBoxIter.Text += '\n';
                }
                else
                {
                    richTextBoxIter.Text += n + "  ";
                    richTextBoxIter.Text += Xn + "  ";

                    func = Math.Round(Math.Sin(Xn / 2) + 1 - (Xn * Xn),6);
                    richTextBoxIter.Text += func + "  ";
                    if (n != 0)
                    {
                        richTextBoxIter.Text += Math.Round(Math.Abs(Xn - Xn1), 6) + "  ";
                    }
                    else
                        richTextBoxIter.Text += "  ";
                    Xn2 = Xn1;
                    Xn1 = Xn;
                    func2 = func1;
                    func1 = func;
                    Xn++;
                    n++;
                    richTextBoxIter.Text += '\n';
                }
            } while (accur>epsilon);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            richTextBoxIter.Text = "";
            iterations();
        }
    }
}
