﻿namespace Num_Methods_7
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
            this.richTextBoxSimpson = new System.Windows.Forms.RichTextBox();
            this.Start = new System.Windows.Forms.Button();
            this.richTextBoxTrapeze = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxSimpson
            // 
            this.richTextBoxSimpson.Location = new System.Drawing.Point(26, 177);
            this.richTextBoxSimpson.Name = "richTextBoxSimpson";
            this.richTextBoxSimpson.Size = new System.Drawing.Size(514, 148);
            this.richTextBoxSimpson.TabIndex = 34;
            this.richTextBoxSimpson.Text = "";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(644, 137);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 31;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // richTextBoxTrapeze
            // 
            this.richTextBoxTrapeze.Location = new System.Drawing.Point(26, 12);
            this.richTextBoxTrapeze.Name = "richTextBoxTrapeze";
            this.richTextBoxTrapeze.Size = new System.Drawing.Size(514, 148);
            this.richTextBoxTrapeze.TabIndex = 30;
            this.richTextBoxTrapeze.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(619, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(619, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "h";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBoxSimpson);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.richTextBoxTrapeze);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxSimpson;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.RichTextBox richTextBoxTrapeze;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

