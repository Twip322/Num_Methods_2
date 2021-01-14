using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Num_Methods_7
{
    public partial class Form1 : Form
    {
        public int a = 0;
        public int b = 2;
        public double h;
        public Form1()
        {
            InitializeComponent();
        }
        private double count(double x)
        {
            return (Math.Pow(x, 3) / (1 + Math.Pow(x, 2)));
        }
        private void Trapeze()
        {
            double offset = a;
            double answer = 0;

            while (offset < b)
            {
                if (offset == a)
                {
                    answer += count(offset) / 2;
                }
                else if (offset + h > b)
                {
                    answer += count(offset);
                    offset = b;
                    answer += count(offset) / 2;
                }
                else answer += count(offset);
                offset += h;
            }
            answer *= h;
            richTextBoxTrapeze.Text += $"При h={h} формула трапеций будет иметь значение: {Math.Round(answer, 4)}\n";
            offset = a;
            double hDouble = h * 2;
            double answerDouble = 0;
            while (offset < b)
            {
                if (offset == a)
                {
                    answerDouble += count(offset) / 2;
                }
                else if (offset + hDouble > b)
                {
                    answerDouble += count(offset);
                    offset = b;
                    answerDouble += count(offset) / 2;
                }
                else answerDouble += count(offset);
                offset += hDouble;
            }
            answerDouble *= hDouble;
            richTextBoxTrapeze.Text += $"При h={hDouble} формула трапеций будет иметь значение: {Math.Round(answerDouble, 4)}\n";
            double rule = Math.Abs(answer - answerDouble) / 3;
            richTextBoxTrapeze.Text += $"Вычислив по правилу Рунге погрешность, получаем : {Math.Round(rule, 5)}\n";
        }
        private void Simpson()
        {
            double offset = a;
            double answer = 0;
            bool period=true;
            while (offset < b)
            {
                if (offset == a)
                {
                    answer += count(offset) / 2;
                }
                else if(offset+h>b && period)
                {
                    answer += count(offset)*2;
                    offset = b;
                    answer += count(offset) / 2;
                }
                else if (period)
                {
                    answer += count(offset) * 2;
                    period = false;
                }
                else if (!period)
                {
                    answer += count(offset);
                    period = true;
                }
                else answer += count(offset);
                offset += h;
            }
            answer *= (2 * h) / 3;
            richTextBoxSimpson.Text += $"При h={h} формула Симпсона будет иметь значение: {Math.Round(answer, 4)}\n";
            offset = a;
            double hDouble = h * 2;
            double answerDouble = 0;

            while (offset < b)
            {
                if (offset == a)
                {
                    answerDouble += count(offset) / 2;
                }
                else if (offset + hDouble > b && period)
                {
                    answerDouble += count(offset) * 2;
                    offset = b;
                    answerDouble += count(offset) / 2;
                }
                else if (period)
                {
                    answerDouble += count(offset) * 2;
                    period = false;
                }
                else if (!period)
                {
                    answerDouble += count(offset);
                    period = true;
                }
                else answerDouble += count(offset);
                offset += hDouble;
            }
                answerDouble *= (2 * hDouble) / 3;
            richTextBoxSimpson.Text += $"При h={hDouble} формула Симпсона будет иметь значение: {Math.Round(answerDouble, 4)}\n";
            double rule = Math.Abs(answerDouble-answer) / 15;
            richTextBoxSimpson.Text += $"Вычислив по правилу Рунге погрешность, получаем : {Math.Round(rule, 7)}\n";
        }
        private void Start_Click(object sender, EventArgs e)
        {
            richTextBoxSimpson.Text = "";
            richTextBoxTrapeze.Text = "";
            h = Convert.ToDouble(textBox1.Text);
            Trapeze();
            Simpson();
        }
    }
}
