namespace Num_Methods_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Start = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxA = new System.Windows.Forms.RichTextBox();
            this.richTextBoxD = new System.Windows.Forms.RichTextBox();
            this.richTextBoxL = new System.Windows.Forms.RichTextBox();
            this.richTextBoxR = new System.Windows.Forms.RichTextBox();
            this.richTextBoxB = new System.Windows.Forms.RichTextBox();
            this.richTextBoxvecC = new System.Windows.Forms.RichTextBox();
            this.richTextBoxConver = new System.Windows.Forms.RichTextBox();
            this.richTextBoxiter = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(647, 79);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Якоби";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(647, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(644, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Эпсилон";
            // 
            // richTextBoxA
            // 
            this.richTextBoxA.Location = new System.Drawing.Point(0, 31);
            this.richTextBoxA.Name = "richTextBoxA";
            this.richTextBoxA.Size = new System.Drawing.Size(153, 139);
            this.richTextBoxA.TabIndex = 3;
            this.richTextBoxA.Text = "";
            // 
            // richTextBoxD
            // 
            this.richTextBoxD.Location = new System.Drawing.Point(159, 31);
            this.richTextBoxD.Name = "richTextBoxD";
            this.richTextBoxD.Size = new System.Drawing.Size(153, 139);
            this.richTextBoxD.TabIndex = 4;
            this.richTextBoxD.Text = "";
            // 
            // richTextBoxL
            // 
            this.richTextBoxL.Location = new System.Drawing.Point(318, 31);
            this.richTextBoxL.Name = "richTextBoxL";
            this.richTextBoxL.Size = new System.Drawing.Size(153, 139);
            this.richTextBoxL.TabIndex = 5;
            this.richTextBoxL.Text = "";
            // 
            // richTextBoxR
            // 
            this.richTextBoxR.Location = new System.Drawing.Point(477, 31);
            this.richTextBoxR.Name = "richTextBoxR";
            this.richTextBoxR.Size = new System.Drawing.Size(153, 139);
            this.richTextBoxR.TabIndex = 6;
            this.richTextBoxR.Text = "";
            // 
            // richTextBoxB
            // 
            this.richTextBoxB.Location = new System.Drawing.Point(0, 207);
            this.richTextBoxB.Name = "richTextBoxB";
            this.richTextBoxB.Size = new System.Drawing.Size(153, 139);
            this.richTextBoxB.TabIndex = 7;
            this.richTextBoxB.Text = "";
            // 
            // richTextBoxvecC
            // 
            this.richTextBoxvecC.Location = new System.Drawing.Point(159, 207);
            this.richTextBoxvecC.Name = "richTextBoxvecC";
            this.richTextBoxvecC.Size = new System.Drawing.Size(153, 139);
            this.richTextBoxvecC.TabIndex = 8;
            this.richTextBoxvecC.Text = "";
            // 
            // richTextBoxConver
            // 
            this.richTextBoxConver.Location = new System.Drawing.Point(318, 207);
            this.richTextBoxConver.Name = "richTextBoxConver";
            this.richTextBoxConver.Size = new System.Drawing.Size(153, 139);
            this.richTextBoxConver.TabIndex = 9;
            this.richTextBoxConver.Text = "";
            // 
            // richTextBoxiter
            // 
            this.richTextBoxiter.Location = new System.Drawing.Point(12, 389);
            this.richTextBoxiter.Name = "richTextBoxiter";
            this.richTextBoxiter.Size = new System.Drawing.Size(399, 169);
            this.richTextBoxiter.TabIndex = 10;
            this.richTextBoxiter.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 570);
            this.Controls.Add(this.richTextBoxiter);
            this.Controls.Add(this.richTextBoxConver);
            this.Controls.Add(this.richTextBoxvecC);
            this.Controls.Add(this.richTextBoxB);
            this.Controls.Add(this.richTextBoxR);
            this.Controls.Add(this.richTextBoxL);
            this.Controls.Add(this.richTextBoxD);
            this.Controls.Add(this.richTextBoxA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxA;
        private System.Windows.Forms.RichTextBox richTextBoxD;
        private System.Windows.Forms.RichTextBox richTextBoxL;
        private System.Windows.Forms.RichTextBox richTextBoxR;
        private System.Windows.Forms.RichTextBox richTextBoxB;
        private System.Windows.Forms.RichTextBox richTextBoxvecC;
        private System.Windows.Forms.RichTextBox richTextBoxConver;
        private System.Windows.Forms.RichTextBox richTextBoxiter;
    }
}

