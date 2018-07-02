namespace Calculator
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
            this.textBoxFirstIn = new System.Windows.Forms.TextBox();
            this.textBoxSecondIn = new System.Windows.Forms.TextBox();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFirstIn
            // 
            this.textBoxFirstIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFirstIn.Location = new System.Drawing.Point(65, 22);
            this.textBoxFirstIn.Name = "textBoxFirstIn";
            this.textBoxFirstIn.Size = new System.Drawing.Size(190, 20);
            this.textBoxFirstIn.TabIndex = 0;
            this.textBoxFirstIn.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBoxSecondIn
            // 
            this.textBoxSecondIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSecondIn.Location = new System.Drawing.Point(65, 60);
            this.textBoxSecondIn.Name = "textBoxSecondIn";
            this.textBoxSecondIn.Size = new System.Drawing.Size(190, 20);
            this.textBoxSecondIn.TabIndex = 1;
            this.textBoxSecondIn.TextChanged += new System.EventHandler(this.textBoxSecondIn_TextChanged);
            // 
            // textBoxOut
            // 
            this.textBoxOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOut.Location = new System.Drawing.Point(65, 98);
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.Size = new System.Drawing.Size(190, 20);
            this.textBoxOut.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(65, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 47);
            this.button3.TabIndex = 5;
            this.button3.Text = "*";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(180, 214);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 47);
            this.button4.TabIndex = 6;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 273);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.textBoxSecondIn);
            this.Controls.Add(this.textBoxFirstIn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstIn;
        private System.Windows.Forms.TextBox textBoxSecondIn;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

