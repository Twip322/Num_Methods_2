namespace Num_Methods_3
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
            this.richTextBoxIter = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxeps = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxIter
            // 
            this.richTextBoxIter.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxIter.Name = "richTextBoxIter";
            this.richTextBoxIter.Size = new System.Drawing.Size(421, 177);
            this.richTextBoxIter.TabIndex = 4;
            this.richTextBoxIter.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(607, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Эпсилон";
            // 
            // textBoxeps
            // 
            this.textBoxeps.Location = new System.Drawing.Point(610, 36);
            this.textBoxeps.Name = "textBoxeps";
            this.textBoxeps.Size = new System.Drawing.Size(100, 20);
            this.textBoxeps.TabIndex = 6;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(610, 84);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 5;
            this.Start.Text = "Hords";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

        private System.Windows.Forms.RichTextBox richTextBoxIter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxeps;
        private System.Windows.Forms.Button Start;
    }
}

