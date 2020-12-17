namespace Num_Methods_5
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxfirst = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.richTextBoxLag = new System.Windows.Forms.RichTextBox();
            this.richTextBoxNewNote = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSplyne = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(703, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "x0";
            // 
            // textBoxfirst
            // 
            this.textBoxfirst.Location = new System.Drawing.Point(621, 23);
            this.textBoxfirst.Name = "textBoxfirst";
            this.textBoxfirst.Size = new System.Drawing.Size(100, 20);
            this.textBoxfirst.TabIndex = 26;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(646, 137);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 23;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // richTextBoxLag
            // 
            this.richTextBoxLag.Location = new System.Drawing.Point(28, 12);
            this.richTextBoxLag.Name = "richTextBoxLag";
            this.richTextBoxLag.Size = new System.Drawing.Size(514, 148);
            this.richTextBoxLag.TabIndex = 22;
            this.richTextBoxLag.Text = "";
            // 
            // richTextBoxNewNote
            // 
            this.richTextBoxNewNote.Location = new System.Drawing.Point(28, 177);
            this.richTextBoxNewNote.Name = "richTextBoxNewNote";
            this.richTextBoxNewNote.Size = new System.Drawing.Size(514, 148);
            this.richTextBoxNewNote.TabIndex = 29;
            this.richTextBoxNewNote.Text = "";
            // 
            // richTextBoxSplyne
            // 
            this.richTextBoxSplyne.Location = new System.Drawing.Point(28, 343);
            this.richTextBoxSplyne.Name = "richTextBoxSplyne";
            this.richTextBoxSplyne.Size = new System.Drawing.Size(514, 148);
            this.richTextBoxSplyne.TabIndex = 30;
            this.richTextBoxSplyne.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.richTextBoxSplyne);
            this.Controls.Add(this.richTextBoxNewNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxfirst);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.richTextBoxLag);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxfirst;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.RichTextBox richTextBoxLag;
        private System.Windows.Forms.RichTextBox richTextBoxNewNote;
        private System.Windows.Forms.RichTextBox richTextBoxSplyne;
    }
}

