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
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnPresets = new System.Windows.Forms.Button();
            this.btnAntennaDB = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnMenu1 = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSildeMenu.SuspendLayout();
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
            this.panelSildeMenu.Controls.Add(this.btnPresets);
            this.panelSildeMenu.Controls.Add(this.btnAntennaDB);
            this.panelSildeMenu.Controls.Add(this.btnSettings);
            this.panelSildeMenu.Controls.Add(this.btnMenu1);
            this.panelSildeMenu.Controls.Add(this.panelLogo);
            this.panelSildeMenu.Name = "panelSildeMenu";
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
            // btnPresets
            // 
            resources.ApplyResources(this.btnPresets, "btnPresets");
            this.btnPresets.FlatAppearance.BorderSize = 0;
            this.btnPresets.ForeColor = System.Drawing.Color.White;
            this.btnPresets.Name = "btnPresets";
            this.btnPresets.UseVisualStyleBackColor = true;
            this.btnPresets.Click += new System.EventHandler(this.btnPresets_Click_1);
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
            // btnMenu1
            // 
            resources.ApplyResources(this.btnMenu1, "btnMenu1");
            this.btnMenu1.FlatAppearance.BorderSize = 0;
            this.btnMenu1.ForeColor = System.Drawing.Color.White;
            this.btnMenu1.Name = "btnMenu1";
            this.btnMenu1.UseVisualStyleBackColor = true;
            this.btnMenu1.Click += new System.EventHandler(this.btnMenu1_Click);
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
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(193)))), ((int)(((byte)(213)))));
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSildeMenu);
            this.Name = "MainForm";
            this.panelSildeMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSildeMenu;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnPresets;
        private System.Windows.Forms.Button btnAntennaDB;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnMenu1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

