namespace Projeto_PSI
{
    partial class MainGame
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
            this.inventoryToggle = new System.Windows.Forms.Button();
            this.cHealthText = new System.Windows.Forms.TextBox();
            this.cNameText = new System.Windows.Forms.TextBox();
            this.cHealth = new System.Windows.Forms.Label();
            this.cName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cLevel = new System.Windows.Forms.Label();
            this.cLevelText = new System.Windows.Forms.TextBox();
            this.saveExit = new System.Windows.Forms.Button();
            this.inventoryBox = new System.Windows.Forms.GroupBox();
            this.mapBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.currentMapArea = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.travelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.inventoryBox.SuspendLayout();
            this.mapBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryToggle
            // 
            this.inventoryToggle.BackColor = System.Drawing.Color.Gray;
            this.inventoryToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryToggle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inventoryToggle.Location = new System.Drawing.Point(393, 31);
            this.inventoryToggle.Name = "inventoryToggle";
            this.inventoryToggle.Size = new System.Drawing.Size(133, 56);
            this.inventoryToggle.TabIndex = 11;
            this.inventoryToggle.Text = "Open Inventory";
            this.inventoryToggle.UseVisualStyleBackColor = false;
            this.inventoryToggle.Click += new System.EventHandler(this.inventoryToggle_Click);
            // 
            // cHealthText
            // 
            this.cHealthText.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cHealthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cHealthText.ForeColor = System.Drawing.Color.White;
            this.cHealthText.Location = new System.Drawing.Point(95, 65);
            this.cHealthText.Name = "cHealthText";
            this.cHealthText.ReadOnly = true;
            this.cHealthText.Size = new System.Drawing.Size(89, 22);
            this.cHealthText.TabIndex = 10;
            // 
            // cNameText
            // 
            this.cNameText.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cNameText.ForeColor = System.Drawing.Color.White;
            this.cNameText.Location = new System.Drawing.Point(95, 31);
            this.cNameText.Name = "cNameText";
            this.cNameText.ReadOnly = true;
            this.cNameText.Size = new System.Drawing.Size(263, 22);
            this.cNameText.TabIndex = 9;
            // 
            // cHealth
            // 
            this.cHealth.AutoSize = true;
            this.cHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cHealth.ForeColor = System.Drawing.Color.White;
            this.cHealth.Location = new System.Drawing.Point(22, 68);
            this.cHealth.Name = "cHealth";
            this.cHealth.Size = new System.Drawing.Size(52, 16);
            this.cHealth.TabIndex = 8;
            this.cHealth.Text = "Health";
            // 
            // cName
            // 
            this.cName.AutoSize = true;
            this.cName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cName.ForeColor = System.Drawing.Color.White;
            this.cName.Location = new System.Drawing.Point(22, 34);
            this.cName.Name = "cName";
            this.cName.Size = new System.Drawing.Size(48, 16);
            this.cName.TabIndex = 7;
            this.cName.Text = "Nome";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(401, 442);
            this.dataGridView1.TabIndex = 6;
            // 
            // cLevel
            // 
            this.cLevel.AutoSize = true;
            this.cLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLevel.ForeColor = System.Drawing.Color.White;
            this.cLevel.Location = new System.Drawing.Point(22, 100);
            this.cLevel.Name = "cLevel";
            this.cLevel.Size = new System.Drawing.Size(45, 16);
            this.cLevel.TabIndex = 13;
            this.cLevel.Text = "Level";
            // 
            // cLevelText
            // 
            this.cLevelText.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cLevelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLevelText.ForeColor = System.Drawing.Color.White;
            this.cLevelText.Location = new System.Drawing.Point(95, 97);
            this.cLevelText.Name = "cLevelText";
            this.cLevelText.ReadOnly = true;
            this.cLevelText.Size = new System.Drawing.Size(89, 22);
            this.cLevelText.TabIndex = 14;
            // 
            // saveExit
            // 
            this.saveExit.BackColor = System.Drawing.Color.Gray;
            this.saveExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveExit.Location = new System.Drawing.Point(393, 465);
            this.saveExit.Name = "saveExit";
            this.saveExit.Size = new System.Drawing.Size(133, 45);
            this.saveExit.TabIndex = 15;
            this.saveExit.Text = "Save and Exit";
            this.saveExit.UseVisualStyleBackColor = false;
            this.saveExit.Click += new System.EventHandler(this.saveExit_Click);
            // 
            // inventoryBox
            // 
            this.inventoryBox.Controls.Add(this.dataGridView1);
            this.inventoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryBox.Location = new System.Drawing.Point(561, 31);
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.Size = new System.Drawing.Size(413, 485);
            this.inventoryBox.TabIndex = 16;
            this.inventoryBox.TabStop = false;
            this.inventoryBox.Text = "Inventory";
            // 
            // mapBox
            // 
            this.mapBox.Controls.Add(this.pictureBox1);
            this.mapBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapBox.ForeColor = System.Drawing.Color.White;
            this.mapBox.Location = new System.Drawing.Point(25, 258);
            this.mapBox.Name = "mapBox";
            this.mapBox.Size = new System.Drawing.Size(333, 252);
            this.mapBox.TabIndex = 17;
            this.mapBox.TabStop = false;
            this.mapBox.Text = "Map";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(6, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 221);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // currentMapArea
            // 
            this.currentMapArea.AutoSize = true;
            this.currentMapArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentMapArea.ForeColor = System.Drawing.Color.White;
            this.currentMapArea.Location = new System.Drawing.Point(376, 283);
            this.currentMapArea.Name = "currentMapArea";
            this.currentMapArea.Size = new System.Drawing.Size(156, 20);
            this.currentMapArea.TabIndex = 18;
            this.currentMapArea.Text = "Current Map Area,";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(377, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Omega Ville.";
            // 
            // travelBtn
            // 
            this.travelBtn.BackColor = System.Drawing.Color.Gray;
            this.travelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.travelBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.travelBtn.Location = new System.Drawing.Point(393, 100);
            this.travelBtn.Name = "travelBtn";
            this.travelBtn.Size = new System.Drawing.Size(133, 56);
            this.travelBtn.TabIndex = 20;
            this.travelBtn.Text = "Travel to a new location";
            this.travelBtn.UseVisualStyleBackColor = false;
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(544, 528);
            this.Controls.Add(this.travelBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentMapArea);
            this.Controls.Add(this.mapBox);
            this.Controls.Add(this.inventoryBox);
            this.Controls.Add(this.saveExit);
            this.Controls.Add(this.cLevelText);
            this.Controls.Add(this.cLevel);
            this.Controls.Add(this.inventoryToggle);
            this.Controls.Add(this.cHealthText);
            this.Controls.Add(this.cNameText);
            this.Controls.Add(this.cHealth);
            this.Controls.Add(this.cName);
            this.Name = "MainGame";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.inventoryBox.ResumeLayout(false);
            this.mapBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inventoryToggle;
        private System.Windows.Forms.TextBox cHealthText;
        private System.Windows.Forms.TextBox cNameText;
        private System.Windows.Forms.Label cHealth;
        private System.Windows.Forms.Label cName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label cLevel;
        private System.Windows.Forms.TextBox cLevelText;
        private System.Windows.Forms.Button saveExit;
        private System.Windows.Forms.GroupBox inventoryBox;
        private System.Windows.Forms.GroupBox mapBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label currentMapArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button travelBtn;
    }
}