namespace AntennVerificator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelSildeMenu = new System.Windows.Forms.Panel();
            this.panelPresets = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.btnPresets = new System.Windows.Forms.Button();
            this.btnAntennaDB = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.panelSildeMenu.SuspendLayout();
            this.panelPresets.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSildeMenu
            // 
            resources.ApplyResources(this.panelSildeMenu, "panelSildeMenu");
            this.panelSildeMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(122)))));
            this.panelSildeMenu.Controls.Add(this.btnAbout);
            this.panelSildeMenu.Controls.Add(this.panelPresets);
            this.panelSildeMenu.Controls.Add(this.btnPresets);
            this.panelSildeMenu.Controls.Add(this.btnAntennaDB);
            this.panelSildeMenu.Controls.Add(this.btnSettings);
            this.panelSildeMenu.Controls.Add(this.calculateBtn);
            this.panelSildeMenu.Controls.Add(this.panelLogo);
            this.panelSildeMenu.Name = "panelSildeMenu";
            // 
            // panelPresets
            // 
            resources.ApplyResources(this.panelPresets, "panelPresets");
            this.panelPresets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.panelPresets.Controls.Add(this.button12);
            this.panelPresets.Controls.Add(this.button13);
            this.panelPresets.Controls.Add(this.button14);
            this.panelPresets.Controls.Add(this.button15);
            this.panelPresets.Name = "panelPresets";
            // 
            // button12
            // 
            resources.ApplyResources(this.button12, "button12");
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Name = "button12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            resources.ApplyResources(this.button13, "button13");
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Name = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            resources.ApplyResources(this.button14, "button14");
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Name = "button14";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            resources.ApplyResources(this.button15, "button15");
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Name = "button15";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // btnPresets
            // 
            resources.ApplyResources(this.btnPresets, "btnPresets");
            this.btnPresets.FlatAppearance.BorderSize = 0;
            this.btnPresets.ForeColor = System.Drawing.Color.White;
            this.btnPresets.Name = "btnPresets";
            this.btnPresets.UseVisualStyleBackColor = true;
            this.btnPresets.Click += new System.EventHandler(this.btnPresets_Click);
            // 
            // btnAntennaDB
            // 
            resources.ApplyResources(this.btnAntennaDB, "btnAntennaDB");
            this.btnAntennaDB.FlatAppearance.BorderSize = 0;
            this.btnAntennaDB.ForeColor = System.Drawing.Color.White;
            this.btnAntennaDB.Name = "btnAntennaDB";
            this.btnAntennaDB.UseVisualStyleBackColor = true;
            this.btnAntennaDB.Click += new System.EventHandler(this.btnAntennaDB_Click);
            // 
            // btnSettings
            // 
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // calculateBtn
            // 
            resources.ApplyResources(this.calculateBtn, "calculateBtn");
            this.calculateBtn.FlatAppearance.BorderSize = 0;
            this.calculateBtn.ForeColor = System.Drawing.Color.White;
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // panelLogo
            // 
            resources.ApplyResources(this.panelLogo, "panelLogo");
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Name = "panelLogo";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::AntennVerificator.Properties.Resources.emblem;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // panelChildForm
            // 
            resources.ApplyResources(this.panelChildForm, "panelChildForm");
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(115)))));
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Name = "panelChildForm";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::AntennVerificator.Properties.Resources._656;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnAbout
            // 
            resources.ApplyResources(this.btnAbout, "btnAbout");
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(193)))), ((int)(((byte)(213)))));
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSildeMenu);
            this.Name = "MainForm";
            this.panelSildeMenu.ResumeLayout(false);
            this.panelPresets.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSildeMenu;
        private System.Windows.Forms.Panel panelPresets;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button btnPresets;
        private System.Windows.Forms.Button btnAntennaDB;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAbout;
    }
}

