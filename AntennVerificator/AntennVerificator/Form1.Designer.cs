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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.myToggleSwitch1 = new AntennVerificator.MyToggleSwitch();
            this.myButton3 = new AntennVerificator.MyButton();
            this.myButton2 = new AntennVerificator.MyButton();
            this.myButton1 = new AntennVerificator.MyButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.myCard3 = new AntennVerificator.MyCard();
            this.myCard2 = new AntennVerificator.MyCard();
            this.myCard1 = new AntennVerificator.MyCard();
            this.myTextBox1 = new AntennVerificator.MyTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.Controls.Add(this.myToggleSwitch1);
            this.panel1.Controls.Add(this.myButton3);
            this.panel1.Controls.Add(this.myButton2);
            this.panel1.Controls.Add(this.myButton1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 515);
            this.panel1.TabIndex = 4;
            // 
            // myToggleSwitch1
            // 
            this.myToggleSwitch1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.myToggleSwitch1.BackColor = System.Drawing.Color.SlateGray;
            this.myToggleSwitch1.backColorOn = System.Drawing.Color.MediumAquamarine;
            this.myToggleSwitch1.Checked = true;
            this.myToggleSwitch1.Font = new System.Drawing.Font("Verdana", 9F);
            this.myToggleSwitch1.Location = new System.Drawing.Point(12, 484);
            this.myToggleSwitch1.Name = "myToggleSwitch1";
            this.myToggleSwitch1.Size = new System.Drawing.Size(37, 19);
            this.myToggleSwitch1.strokeColor = System.Drawing.Color.Gray;
            this.myToggleSwitch1.TabIndex = 3;
            this.myToggleSwitch1.Text = "myToggleSwitch1";
            // 
            // myButton3
            // 
            this.myButton3.BackColor = System.Drawing.Color.SlateGray;
            this.myButton3.ForeColor = System.Drawing.Color.White;
            this.myButton3.Location = new System.Drawing.Point(12, 138);
            this.myButton3.Name = "myButton3";
            this.myButton3.Size = new System.Drawing.Size(197, 57);
            this.myButton3.TabIndex = 5;
            this.myButton3.Text = "myButton1";
            // 
            // myButton2
            // 
            this.myButton2.BackColor = System.Drawing.Color.SlateGray;
            this.myButton2.ForeColor = System.Drawing.Color.White;
            this.myButton2.Location = new System.Drawing.Point(12, 75);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(197, 57);
            this.myButton2.TabIndex = 5;
            this.myButton2.Text = "myButton1";
            // 
            // myButton1
            // 
            this.myButton1.BackColor = System.Drawing.Color.SlateGray;
            this.myButton1.ForeColor = System.Drawing.Color.White;
            this.myButton1.Location = new System.Drawing.Point(12, 12);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(197, 57);
            this.myButton1.TabIndex = 5;
            this.myButton1.Text = "myButton1";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel2.Controls.Add(this.myTextBox1);
            this.panel2.Controls.Add(this.myCard3);
            this.panel2.Controls.Add(this.myCard2);
            this.panel2.Controls.Add(this.myCard1);
            this.panel2.Location = new System.Drawing.Point(224, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 515);
            this.panel2.TabIndex = 5;
            // 
            // myCard3
            // 
            this.myCard3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.myCard3.BackColor = System.Drawing.Color.White;
            this.myCard3.BackColorCurtain = System.Drawing.Color.SlateGray;
            this.myCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myCard3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myCard3.Font = new System.Drawing.Font("Verdana", 9F);
            this.myCard3.FontDescription = new System.Drawing.Font("Verdana", 8.25F);
            this.myCard3.FontHeader = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.myCard3.ForeColorDescription = System.Drawing.Color.Black;
            this.myCard3.ForeColorHeader = System.Drawing.Color.White;
            this.myCard3.Location = new System.Drawing.Point(442, 12);
            this.myCard3.Name = "myCard3";
            this.myCard3.Size = new System.Drawing.Size(212, 243);
            this.myCard3.strokeColor = System.Drawing.Color.Gray;
            this.myCard3.TabIndex = 2;
            this.myCard3.Text = "1234567890";
            this.myCard3.TextDescription = "Antenna 3 description";
            this.myCard3.TextHeader = "Antenna 3";
            // 
            // myCard2
            // 
            this.myCard2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.myCard2.BackColor = System.Drawing.Color.White;
            this.myCard2.BackColorCurtain = System.Drawing.Color.SlateGray;
            this.myCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myCard2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myCard2.Font = new System.Drawing.Font("Verdana", 9F);
            this.myCard2.FontDescription = new System.Drawing.Font("Verdana", 8.25F);
            this.myCard2.FontHeader = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.myCard2.ForeColorDescription = System.Drawing.Color.Black;
            this.myCard2.ForeColorHeader = System.Drawing.Color.White;
            this.myCard2.Location = new System.Drawing.Point(224, 12);
            this.myCard2.Name = "myCard2";
            this.myCard2.Size = new System.Drawing.Size(212, 243);
            this.myCard2.strokeColor = System.Drawing.Color.Gray;
            this.myCard2.TabIndex = 2;
            this.myCard2.Text = "1234567890";
            this.myCard2.TextDescription = "Antenna 2 description";
            this.myCard2.TextHeader = "Antenna 2";
            // 
            // myCard1
            // 
            this.myCard1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.myCard1.BackColor = System.Drawing.Color.White;
            this.myCard1.BackColorCurtain = System.Drawing.Color.SlateGray;
            this.myCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myCard1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myCard1.Font = new System.Drawing.Font("Verdana", 9F);
            this.myCard1.FontDescription = new System.Drawing.Font("Verdana", 8.25F);
            this.myCard1.FontHeader = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.myCard1.ForeColorDescription = System.Drawing.Color.Black;
            this.myCard1.ForeColorHeader = System.Drawing.Color.White;
            this.myCard1.Location = new System.Drawing.Point(6, 12);
            this.myCard1.Name = "myCard1";
            this.myCard1.Size = new System.Drawing.Size(212, 243);
            this.myCard1.strokeColor = System.Drawing.Color.Gray;
            this.myCard1.TabIndex = 2;
            this.myCard1.Text = "1234567890";
            this.myCard1.TextDescription = "Antenna 1 description";
            this.myCard1.TextHeader = "Antenna 1";
            // 
            // myTextBox1
            // 
            this.myTextBox1.BackColor = System.Drawing.Color.White;
            this.myTextBox1.BorderColor = System.Drawing.Color.Blue;
            this.myTextBox1.BorderColorNotActive = System.Drawing.Color.DarkBlue;
            this.myTextBox1.Font = new System.Drawing.Font("Arial", 11.25F);
            this.myTextBox1.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.myTextBox1.ForeColor = System.Drawing.Color.Black;
            this.myTextBox1.Location = new System.Drawing.Point(301, 322);
            this.myTextBox1.Name = "myTextBox1";
            this.myTextBox1.Size = new System.Drawing.Size(150, 40);
            this.myTextBox1.TabIndex = 3;
            this.myTextBox1.TextInput = "";
            this.myTextBox1.TextPreview = "Input Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(889, 515);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(905, 554);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AntennVerificator";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MyCard myCard1;
        private System.Windows.Forms.Panel panel1;
        private MyButton myButton3;
        private MyButton myButton2;
        private MyButton myButton1;
        private System.Windows.Forms.Panel panel2;
        private MyCard myCard3;
        private MyCard myCard2;
        private MyToggleSwitch myToggleSwitch1;
        private MyTextBox myTextBox1;
    }
}

