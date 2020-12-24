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
        public double h = 0.166;
        public Form1()
        {
            InitializeComponent();
        }

        private void Trapeze()
        {
            double offset = a;
            double answer = 0;

            while (offset < b)
            {
                if (offset == a)
                {
                    answer += (Math.Pow(offset, 3) / (1 + (Math.Pow(offset, 2)))) / 2;
                }
                else if (offset + h > b)
                {
                    answer += (Math.Pow(offset, 3) / (1 + (Math.Pow(offset, 2)))) / 2;
                }
                else answer += (Math.Pow(offset, 3) / (1 + (Math.Pow(offset, 2))));
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
                    answerDouble += (Math.Pow(offset, 3) / (1 + (Math.Pow(offset, 2)))) / 2;
                }
                else if (offset + h > b)
                {
                    answerDouble += (Math.Pow(offset, 3) / (1 + (Math.Pow(offset, 2)))) / 2;
                }
                else answerDouble += (Math.Pow(offset, 3) / (1 + (Math.Pow(offset, 2))));
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
            double testoffset = a;
            while (testoffset < b-h)
            {
                testoffset += h;
            }
            while (offset < b)
            {
                if (offset == a)
                {
                    answer += ((Math.Pow(offset, 3) / (1 + (Math.Pow(offset, 2)))) + (Math.Pow(testoffset, 3) / (1 + (Math.Pow(testoffset, 2))))) / 2;
                }
                else if (offset - h == a)
                {
                    answer += (Math.Pow(offset, 3) / (1 + (Math.Pow(offset, 2)))) * 2;
                }
                else if (offset + h > b)
                {
                    answer += (Math.Pow(offset-h, 3) / (1 + (Math.Pow(offset - h, 2)))) * 2;
                }
                else answer += (Math.Pow(offset, 3) / (1 + (Math.Pow(offset, 2))));
                offset += h;
            }
            answer *= (2 * h) / 3;
            richTextBoxSimpson.Text += $"При h={h} формула Симпсона будет иметь значение: {Math.Round(answer, 4)}\n";
            offset = a;
            double hDouble = h * 2;
            double answerDouble = 0;
            testoffset = a;
            while (testoffset < b - hDouble)
            {
                testoffset += hDouble;
            }
            while (offset < b)
            {
                if (offset == a)
                {
                    answerDouble += ((Math.Pow(offset, 3) / (1 + (Math.Pow(offset, 2)))) + (Math.Pow(testoffset, 3) / (1 + (Math.Pow(testoffset, 2))))) / 2;
                }
                else if (offset - hDouble == a)
                {
                    answerDouble += (Math.Pow(offset, 3) / (1 + (Math.Pow(offset, 2)))) * 2;
                }
                else if (offset + h > b)
                {
                    answerDouble += (Math.Pow(offset - hDouble, 3) / (1 + (Math.Pow(offset - hDouble, 2)))) * 2;
                }
                else answerDouble += (Math.Pow(offset, 3) / (1 + (Math.Pow(offset, 2))));
                offset += hDouble;
            }
            answerDouble *= (2 * hDouble) / 3;
            richTextBoxSimpson.Text += $"При h={hDouble} формула Симпсона будет иметь значение: {Math.Round(answerDouble, 4)}\n";
            double rule = Math.Abs(answer - answerDouble) / 15;
            richTextBoxSimpson.Text += $"Вычислив по правилу Рунге погрешность, получаем : {Math.Round(rule, 7)}\n";
        }
        private void Start_Click(object sender, EventArgs e)
        {
            richTextBoxSimpson.Text = "";
            richTextBoxTrapeze.Text = "";
            Trapeze();
            Simpson();
        }
    }
}
