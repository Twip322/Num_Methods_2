namespace Num_Methods_4
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxeps = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.richTextBoxIter = new System.Windows.Forms.RichTextBox();
            this.textBoxaplh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxfirst = new System.Windows.Forms.TextBox();
            this.textBoxsecond = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(607, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Эпсилон";
            // 
            // textBoxeps
            // 
            this.textBoxeps.Location = new System.Drawing.Point(610, 36);
            this.textBoxeps.Name = "textBoxeps";
            this.textBoxeps.Size = new System.Drawing.Size(100, 20);
            this.textBoxeps.TabIndex = 10;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(635, 142);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 9;
            this.Start.Text = "Gradient";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // richTextBoxIter
            // 
            this.richTextBoxIter.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxIter.Name = "richTextBoxIter";
            this.richTextBoxIter.Size = new System.Drawing.Size(417, 529);
            this.richTextBoxIter.TabIndex = 8;
            this.richTextBoxIter.Text = "";
            // 
            // textBoxaplh
            // 
            this.textBoxaplh.Location = new System.Drawing.Point(480, 36);
            this.textBoxaplh.Name = "textBoxaplh";
            this.textBoxaplh.ReadOnly = true;
            this.textBoxaplh.Size = new System.Drawing.Size(100, 20);
            this.textBoxaplh.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Альфа";
            // 
            // textBoxfirst
            // 
            this.textBoxfirst.Location = new System.Drawing.Point(480, 93);
            this.textBoxfirst.Name = "textBoxfirst";
            this.textBoxfirst.Size = new System.Drawing.Size(100, 20);
            this.textBoxfirst.TabIndex = 14;
            // 
            // textBoxsecond
            // 
            this.textBoxsecond.Location = new System.Drawing.Point(610, 93);
            this.textBoxsecond.Name = "textBoxsecond";
            this.textBoxsecond.Size = new System.Drawing.Size(100, 20);
            this.textBoxsecond.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "x1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "x2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxsecond);
            this.Controls.Add(this.textBoxfirst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxaplh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxeps);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.richTextBoxIter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxeps;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.RichTextBox richTextBoxIter;
        private System.Windows.Forms.TextBox textBoxaplh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxfirst;
        private System.Windows.Forms.TextBox textBoxsecond;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

