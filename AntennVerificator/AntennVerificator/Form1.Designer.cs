namespace AntennVerificator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.myCard1 = new AntennVerificator.MyCard();
            this.myButton1 = new AntennVerificator.MyButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(246, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // myCard1
            // 
            this.myCard1.BackColor = System.Drawing.Color.White;
            this.myCard1.backColorCurtain = System.Drawing.Color.Tomato;
            this.myCard1.Font = new System.Drawing.Font("Verdana", 9F);
            this.myCard1.fontDescription = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.myCard1.fontHeader = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.myCard1.foreColorDescription = System.Drawing.Color.Black;
            this.myCard1.foreColorHeader = System.Drawing.Color.White;
            this.myCard1.Location = new System.Drawing.Point(489, 179);
            this.myCard1.Name = "myCard1";
            this.myCard1.Size = new System.Drawing.Size(250, 200);
            this.myCard1.TabIndex = 2;
            this.myCard1.Text = "myCard1";
            this.myCard1.textDescription = "Your description";
            this.myCard1.textHeader = "Header";
            // 
            // myButton1
            // 
            this.myButton1.BackColor = System.Drawing.Color.Black;
            this.myButton1.ForeColor = System.Drawing.Color.White;
            this.myButton1.Location = new System.Drawing.Point(246, 85);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(199, 102);
            this.myButton1.TabIndex = 0;
            this.myButton1.Text = "myButton1";
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 515);
            this.Controls.Add(this.myCard1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.myButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyButton myButton1;
        private System.Windows.Forms.TextBox textBox1;
        private MyCard myCard1;
    }
}

