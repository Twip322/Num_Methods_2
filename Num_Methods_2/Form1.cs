using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Num_Methods_2
{
    public partial class Form1 : Form
    {
        private float[,] systemlist =
        {
            {4.405F  ,0.472F   ,0.395F   ,0.0253F  ,0.623F },
            {0.227F  ,2.957F   ,0.342F   ,0.327F   ,0.072F},
            {0.419F  ,0.341F   ,3.238F   ,0.394F   ,0.143F },
            {0.325F  ,0.326F   ,0.401F   ,4.273F  ,0.065F}
        };
        float[,] transsyslist;
        float epsilon;
        public Form1()
        {
            InitializeComponent();
        }
        private void transformed()
        {
            transsyslist = new float[systemlist.GetLength(0), systemlist.GetLength(1)];
            int setter = 0;
            for(int i=0;i< systemlist.GetLength(0);i++)
            {
                for (int j = 0; j < systemlist.GetLength(1); j++)
                {
                    transsyslist[i, j] = (float)Math.Round(systemlist[i, j] / systemlist[i, setter],4)*-1;
                    if(transsyslist[i,j]==-1)
                    {
                        transsyslist[i, j] = 0;
                    }
                    if(j==systemlist.GetLength(1)-1)
                    {
                        transsyslist[i, j] = transsyslist[i, j]*-1;
                    }
                }
                setter++;
            }
            
            
        }
    private void matrixA()
        {
            string tmp="";
            for (int i = 0; i < systemlist.GetLength(0); i++)
            {
                tmp = "";
                for (int j = 0; j < systemlist.GetLength(1)-1; j++)
                {
                    tmp += systemlist[i, j] + "  ";
                }
                tmp += "\n\n";
                richTextBoxA.Text += tmp;
            }
        }
        private void matrixD()
        {
            string tmp = "";
            int line=0;
            for (int i = 0; i < systemlist.GetLength(0); i++)
            {
                tmp = "";
                for (int j = 0; j < systemlist.GetLength(1)-1; j++)
                {
                    if(j==line)
                    {
                        tmp += systemlist[i, j] + "  ";
                    }
                    else
                    {
                        tmp += 0 + "  ";
                    }
                }
                line++;
                tmp += "\n\n";
                richTextBoxD.Text += tmp;
            }
        }
        private void matrixL()
        {
            string tmp = "";
            int nums=0;
            for (int i = 0; i < systemlist.GetLength(0); i++)
            {
                int tmpnums = nums + i;
                tmp = "";
                for (int j = 0; j < systemlist.GetLength(1) - 1; j++)
                {
                    if (tmpnums!=0)
                    {
                        tmp += systemlist[i, j] + "  ";
                        tmpnums--;
                    }
                    else
                    {
                        tmp += 0 + "  ";
                    }

                }
                tmp += "\n\n";
                richTextBoxL.Text += tmp;
            }
        }
        private void matrixR()
        {
            string tmp = "";
            int nums = 1;
            for (int i = 0; i < systemlist.GetLength(0); i++)
            {
                int tmpnums = nums + i;
                tmp = "";
                for (int j = 0; j < systemlist.GetLength(1) - 1; j++)
                {
                    if (tmpnums != 0)
                    {
                        tmp += 0 + "  ";
                        tmpnums--;
                    }
                    else
                    {
                        tmp += systemlist[i, j] + "  ";

                    }

                }
                tmp += "\n\n";
                richTextBoxR.Text += tmp;
            }
        }
        private void matrixB()
        {
            string tmp = "";
            for (int i = 0; i < transsyslist.GetLength(0); i++)
            {
                tmp = "";
                for (int j = 0; j < transsyslist.GetLength(1)-1; j++)
                {
                    tmp += transsyslist[i, j] + "  ";
                }
                tmp += "\n\n";
                richTextBoxB.Text += tmp;
            }
        }
        private void vectorC()
        {
            string tmp = "";
            for (int i = 0; i < transsyslist.GetLength(0); i++)
            {
                tmp = "";
                tmp += transsyslist[i, transsyslist.GetLength(1)-1] + "  ";
                tmp += "\n\n";
                richTextBoxvecC.Text += tmp;
            }
        }
        private void convergences_check()
        {
            float x=0;
            float y=0;
            int setter=0;
            for(int i=0; i<systemlist.GetLength(0);i++)
            {
                x = systemlist[i, setter];
                for (int j = 0; j < systemlist.GetLength(1) - 1; j++)
                {
                    if(j!=setter)
                    {
                        y += systemlist[i, j];
                    }
                }

                richTextBoxConver.Text += x+" > "+y;
                if (x > y)
                {
                    richTextBoxConver.Text += "  true\n";
                }
                else
                    richTextBoxConver.Text += "  false\n";
                    setter++;
                y = 0;
            }
            
        }
        private void iterations()
        {
            float epsilon = (float)Convert.ToDouble(textBox1.Text);
            float max;
            int k = 0;
            float[] line = new float[transsyslist.GetLength(1) - 1];
            for (int i = 0; i < line.Length; i++)
            {
                line[i] = 0;
            }
            float[] templine = new float[transsyslist.GetLength(1) - 1];
            do
            {
                richTextBoxiter.Text += k + " ";
                for (int i = 0; i < line.Length; i++)
                {
                    for (int j = 0; j < transsyslist.GetLength(1); j++)
                    {
                        if (transsyslist[i, j] != 0)
                            templine[i] += transsyslist[i, j] * line[i];
                        if (j == transsyslist.GetLength(1) - 1)
                            templine[i] += transsyslist[i, j];
                    }
                    
                    richTextBoxiter.Text += (float)Math.Round(templine[i], 4) + " ";
                }
                max = (float)Math.Round(Math.Max(Math.Max(Math.Abs(templine[0] - line[0]), Math.Abs(templine[1] - line[1])), Math.Max(Math.Abs(templine[2] - line[2]), Math.Abs(templine[0] - line[0]))),4);
                richTextBoxiter.Text += max + "\n";
                k++;
                line = templine;
                templine = new float[transsyslist.GetLength(1) - 1];
            } while (max > epsilon);
        }
        private void Start_Click(object sender, EventArgs e)
        {
            transformed();
            matrixA();
            matrixD();
            matrixL();
            matrixR();
            matrixB();
            vectorC();
            convergences_check();
            iterations();
        }

       
    }
}
