namespace AntennVerificator
{
    partial class DataBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBase));
            this.writeInDbBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.checkBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.changeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.tbID = new AntennVerificator.MyTextBox();
            this.tbName = new AntennVerificator.MyTextBox();
            this.tbFreqRange = new AntennVerificator.MyTextBox();
            this.tbDiscription = new System.Windows.Forms.RichTextBox();
            this.lbDiscription = new System.Windows.Forms.Label();
            this.tbFreqPoints = new System.Windows.Forms.RichTextBox();
            this.lbFreqPoints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // writeInDbBtn
            // 
            resources.ApplyResources(this.writeInDbBtn, "writeInDbBtn");
            this.writeInDbBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.writeInDbBtn.FlatAppearance.BorderSize = 0;
            this.writeInDbBtn.ForeColor = System.Drawing.Color.White;
            this.writeInDbBtn.Name = "writeInDbBtn";
            this.writeInDbBtn.UseVisualStyleBackColor = false;
            this.writeInDbBtn.Click += new System.EventHandler(this.writeInDbBtn_Click);
            // 
            // clearBtn
            // 
            resources.ApplyResources(this.clearBtn, "clearBtn");
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // checkBtn
            // 
            resources.ApplyResources(this.checkBtn, "checkBtn");
            this.checkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.checkBtn.FlatAppearance.BorderSize = 0;
            this.checkBtn.ForeColor = System.Drawing.Color.White;
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.UseVisualStyleBackColor = false;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // deleteBtn
            // 
            resources.ApplyResources(this.deleteBtn, "deleteBtn");
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // changeBtn
            // 
            resources.ApplyResources(this.changeBtn, "changeBtn");
            this.changeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.changeBtn.FlatAppearance.BorderSize = 0;
            this.changeBtn.ForeColor = System.Drawing.Color.White;
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.UseVisualStyleBackColor = false;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // addBtn
            // 
            resources.ApplyResources(this.addBtn, "addBtn");
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Name = "addBtn";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.IndianRed;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.closeBtn, "closeBtn");
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.button11_Click);
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(202)))), ((int)(((byte)(209)))));
            this.tbID.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.tbID.BorderColorNotActive = System.Drawing.Color.White;
            this.tbID.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.tbID, "tbID");
            this.tbID.fontTextPreview = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbID.FontTextPreview = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbID.ForeColor = System.Drawing.Color.Black;
            this.tbID.Name = "tbID";
            this.tbID.TextInput = "";
            this.tbID.TextPreview = "ID";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(202)))), ((int)(((byte)(209)))));
            this.tbName.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.tbName.BorderColorNotActive = System.Drawing.Color.White;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.fontTextPreview = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbName.FontTextPreview = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.Name = "tbName";
            this.tbName.TextInput = "";
            this.tbName.TextPreview = "Название";
            // 
            // tbFreqRange
            // 
            this.tbFreqRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(202)))), ((int)(((byte)(209)))));
            this.tbFreqRange.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.tbFreqRange.BorderColorNotActive = System.Drawing.Color.White;
            this.tbFreqRange.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.tbFreqRange, "tbFreqRange");
            this.tbFreqRange.fontTextPreview = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbFreqRange.FontTextPreview = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbFreqRange.ForeColor = System.Drawing.Color.Black;
            this.tbFreqRange.Name = "tbFreqRange";
            this.tbFreqRange.TextInput = "";
            this.tbFreqRange.TextPreview = "Частотый диапазон";
            // 
            // tbDiscription
            // 
            resources.ApplyResources(this.tbDiscription, "tbDiscription");
            this.tbDiscription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(202)))), ((int)(((byte)(209)))));
            this.tbDiscription.Name = "tbDiscription";
            // 
            // lbDiscription
            // 
            resources.ApplyResources(this.lbDiscription, "lbDiscription");
            this.lbDiscription.ForeColor = System.Drawing.Color.White;
            this.lbDiscription.Name = "lbDiscription";
            // 
            // tbFreqPoints
            // 
            resources.ApplyResources(this.tbFreqPoints, "tbFreqPoints");
            this.tbFreqPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(202)))), ((int)(((byte)(209)))));
            this.tbFreqPoints.Name = "tbFreqPoints";
            // 
            // lbFreqPoints
            // 
            resources.ApplyResources(this.lbFreqPoints, "lbFreqPoints");
            this.lbFreqPoints.ForeColor = System.Drawing.Color.White;
            this.lbFreqPoints.Name = "lbFreqPoints";
            // 
            // DataBase
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(115)))));
            this.Controls.Add(this.lbFreqPoints);
            this.Controls.Add(this.tbFreqPoints);
            this.Controls.Add(this.lbDiscription);
            this.Controls.Add(this.tbDiscription);
            this.Controls.Add(this.tbFreqRange);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.writeInDbBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "DataBase";
            this.Load += new System.EventHandler(this.AntennaFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button writeInDbBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button closeBtn;
        private MyTextBox tbID;
        private MyTextBox tbName;
        private MyTextBox tbFreqRange;
        private System.Windows.Forms.RichTextBox tbDiscription;
        private System.Windows.Forms.Label lbDiscription;
        private System.Windows.Forms.RichTextBox tbFreqPoints;
        private System.Windows.Forms.Label lbFreqPoints;
    }
}