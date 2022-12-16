namespace AntennVerificator
{
    partial class Instruction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instruction));
            this.button11 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbFreqPoints = new System.Windows.Forms.Label();
            this.tbFreqPoints = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbDiscription = new System.Windows.Forms.Label();
            this.tbFreqRange = new System.Windows.Forms.RichTextBox();
            this.tbName = new System.Windows.Forms.RichTextBox();
            this.tbID = new System.Windows.Forms.RichTextBox();
            this.tbDiscription = new System.Windows.Forms.RichTextBox();
            this.writeInDbBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.checkBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.changeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.IndianRed;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(12, 12);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(30, 27);
            this.button11.TabIndex = 37;
            this.button11.Text = "X";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(202)))), ((int)(((byte)(209)))));
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 439);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(660, 110);
            this.richTextBox1.TabIndex = 38;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // lbFreqPoints
            // 
            this.lbFreqPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbFreqPoints.AutoSize = true;
            this.lbFreqPoints.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lbFreqPoints.ForeColor = System.Drawing.Color.White;
            this.lbFreqPoints.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbFreqPoints.Location = new System.Drawing.Point(8, 362);
            this.lbFreqPoints.Name = "lbFreqPoints";
            this.lbFreqPoints.Size = new System.Drawing.Size(189, 19);
            this.lbFreqPoints.TabIndex = 56;
            this.lbFreqPoints.Text = "Частотные точки (МГц)";
            // 
            // tbFreqPoints
            // 
            this.tbFreqPoints.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFreqPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(202)))), ((int)(((byte)(209)))));
            this.tbFreqPoints.Font = new System.Drawing.Font("Arial", 14F);
            this.tbFreqPoints.Location = new System.Drawing.Point(12, 384);
            this.tbFreqPoints.Name = "tbFreqPoints";
            this.tbFreqPoints.Size = new System.Drawing.Size(660, 38);
            this.tbFreqPoints.TabIndex = 51;
            this.tbFreqPoints.Text = "Например: 100 200 300 400 или 100; 200; 300; 400";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(8, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 19);
            this.label1.TabIndex = 57;
            this.label1.Text = "Частотный диапазон";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbName.Location = new System.Drawing.Point(8, 106);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(86, 19);
            this.lbName.TabIndex = 58;
            this.lbName.Text = "Название";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lbID.ForeColor = System.Drawing.Color.White;
            this.lbID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbID.Location = new System.Drawing.Point(11, 48);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(25, 19);
            this.lbID.TabIndex = 59;
            this.lbID.Text = "ID";
            // 
            // lbDiscription
            // 
            this.lbDiscription.AutoSize = true;
            this.lbDiscription.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lbDiscription.ForeColor = System.Drawing.Color.White;
            this.lbDiscription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbDiscription.Location = new System.Drawing.Point(11, 237);
            this.lbDiscription.Name = "lbDiscription";
            this.lbDiscription.Size = new System.Drawing.Size(87, 19);
            this.lbDiscription.TabIndex = 60;
            this.lbDiscription.Text = "Описание";
            // 
            // tbFreqRange
            // 
            this.tbFreqRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(202)))), ((int)(((byte)(209)))));
            this.tbFreqRange.Font = new System.Drawing.Font("Arial", 14F);
            this.tbFreqRange.Location = new System.Drawing.Point(12, 186);
            this.tbFreqRange.Name = "tbFreqRange";
            this.tbFreqRange.Size = new System.Drawing.Size(291, 31);
            this.tbFreqRange.TabIndex = 52;
            this.tbFreqRange.Text = "Например: 1-12 ГГц";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(202)))), ((int)(((byte)(209)))));
            this.tbName.Font = new System.Drawing.Font("Arial", 14F);
            this.tbName.Location = new System.Drawing.Point(12, 128);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(291, 31);
            this.tbName.TabIndex = 53;
            this.tbName.Text = "Например: П6-23А";
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(202)))), ((int)(((byte)(209)))));
            this.tbID.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbID.Location = new System.Drawing.Point(12, 70);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(291, 31);
            this.tbID.TabIndex = 54;
            this.tbID.Text = "Например: 6";
            // 
            // tbDiscription
            // 
            this.tbDiscription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDiscription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(202)))), ((int)(((byte)(209)))));
            this.tbDiscription.Font = new System.Drawing.Font("Arial", 14F);
            this.tbDiscription.Location = new System.Drawing.Point(12, 259);
            this.tbDiscription.Name = "tbDiscription";
            this.tbDiscription.Size = new System.Drawing.Size(660, 100);
            this.tbDiscription.TabIndex = 55;
            this.tbDiscription.Text = "Описание антенны";
            // 
            // writeInDbBtn
            // 
            this.writeInDbBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.writeInDbBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.writeInDbBtn.FlatAppearance.BorderSize = 0;
            this.writeInDbBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.writeInDbBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.writeInDbBtn.ForeColor = System.Drawing.Color.White;
            this.writeInDbBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.writeInDbBtn.Location = new System.Drawing.Point(525, 123);
            this.writeInDbBtn.Name = "writeInDbBtn";
            this.writeInDbBtn.Size = new System.Drawing.Size(150, 40);
            this.writeInDbBtn.TabIndex = 50;
            this.writeInDbBtn.Text = "Запись в БД";
            this.writeInDbBtn.UseVisualStyleBackColor = false;
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clearBtn.Location = new System.Drawing.Point(342, 123);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(150, 40);
            this.clearBtn.TabIndex = 49;
            this.clearBtn.Text = "Очистить";
            this.clearBtn.UseVisualStyleBackColor = false;
            // 
            // checkBtn
            // 
            this.checkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.checkBtn.FlatAppearance.BorderSize = 0;
            this.checkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.checkBtn.ForeColor = System.Drawing.Color.White;
            this.checkBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBtn.Location = new System.Drawing.Point(342, 181);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(150, 40);
            this.checkBtn.TabIndex = 48;
            this.checkBtn.Text = "Узнать";
            this.checkBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.deleteBtn.Location = new System.Drawing.Point(525, 181);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(150, 40);
            this.deleteBtn.TabIndex = 47;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // changeBtn
            // 
            this.changeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.changeBtn.FlatAppearance.BorderSize = 0;
            this.changeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.changeBtn.ForeColor = System.Drawing.Color.White;
            this.changeBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.changeBtn.Location = new System.Drawing.Point(525, 65);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(150, 40);
            this.changeBtn.TabIndex = 46;
            this.changeBtn.Text = "Изменить";
            this.changeBtn.UseVisualStyleBackColor = false;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Arial Black", 10F);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addBtn.Location = new System.Drawing.Point(342, 65);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(150, 40);
            this.addBtn.TabIndex = 45;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = false;
            // 
            // Instruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.lbFreqPoints);
            this.Controls.Add(this.tbFreqPoints);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbDiscription);
            this.Controls.Add(this.tbFreqRange);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbDiscription);
            this.Controls.Add(this.writeInDbBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button11);
            this.Name = "Instruction";
            this.Text = "Instruction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbFreqPoints;
        private System.Windows.Forms.RichTextBox tbFreqPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbDiscription;
        private System.Windows.Forms.RichTextBox tbFreqRange;
        private System.Windows.Forms.RichTextBox tbName;
        private System.Windows.Forms.RichTextBox tbID;
        private System.Windows.Forms.RichTextBox tbDiscription;
        private System.Windows.Forms.Button writeInDbBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Button addBtn;
    }
}