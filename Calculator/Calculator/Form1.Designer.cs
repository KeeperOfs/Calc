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
            this.sum = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.root = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFirstIn
            // 
            this.textBoxFirstIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFirstIn.Location = new System.Drawing.Point(65, 22);
            this.textBoxFirstIn.Name = "textBoxFirstIn";
            this.textBoxFirstIn.Size = new System.Drawing.Size(190, 20);
            this.textBoxFirstIn.TabIndex = 0;
            // 
            // textBoxSecondIn
            // 
            this.textBoxSecondIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSecondIn.Location = new System.Drawing.Point(65, 60);
            this.textBoxSecondIn.Name = "textBoxSecondIn";
            this.textBoxSecondIn.Size = new System.Drawing.Size(190, 20);
            this.textBoxSecondIn.TabIndex = 1;
            // 
            // textBoxOut
            // 
            this.textBoxOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOut.Location = new System.Drawing.Point(65, 98);
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.Size = new System.Drawing.Size(190, 20);
            this.textBoxOut.TabIndex = 2;
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(24, 143);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(48, 47);
            this.sum.TabIndex = 3;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(78, 143);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(47, 47);
            this.minus.TabIndex = 4;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(24, 214);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(48, 47);
            this.multiply.TabIndex = 5;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(78, 214);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(47, 47);
            this.division.TabIndex = 6;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // root
            // 
            this.root.Location = new System.Drawing.Point(131, 143);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(47, 47);
            this.root.TabIndex = 7;
            this.root.Text = "Sqrt";
            this.root.UseVisualStyleBackColor = true;
            this.root.Click += new System.EventHandler(this.ln_Click);
            // 
            // ln
            // 
            this.ln.Location = new System.Drawing.Point(131, 214);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(47, 47);
            this.ln.TabIndex = 8;
            this.ln.Text = "ln";
            this.ln.UseVisualStyleBackColor = true;
            this.ln.Click += new System.EventHandler(this.ln_Click);
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(184, 143);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(47, 47);
            this.sin.TabIndex = 9;
            this.sin.Text = "Sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.ln_Click);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(184, 214);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(47, 47);
            this.cos.TabIndex = 10;
            this.cos.Text = "Cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.ln_Click);
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(237, 143);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(47, 47);
            this.tan.TabIndex = 11;
            this.tan.Text = "Tan";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.ln_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 273);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.root);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.sum);
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
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button root;
        private System.Windows.Forms.Button ln;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button tan;
    }
}

