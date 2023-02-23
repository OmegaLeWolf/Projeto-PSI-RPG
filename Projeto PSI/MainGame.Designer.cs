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
            this.cInventory = new System.Windows.Forms.Label();
            this.cLevel = new System.Windows.Forms.Label();
            this.cLevelText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryToggle
            // 
            this.inventoryToggle.Location = new System.Drawing.Point(393, 31);
            this.inventoryToggle.Name = "inventoryToggle";
            this.inventoryToggle.Size = new System.Drawing.Size(133, 56);
            this.inventoryToggle.TabIndex = 11;
            this.inventoryToggle.Text = "Open Inventory";
            this.inventoryToggle.UseVisualStyleBackColor = true;
            this.inventoryToggle.Click += new System.EventHandler(this.inventoryToggle_Click);
            // 
            // cHealthText
            // 
            this.cHealthText.Enabled = false;
            this.cHealthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cHealthText.Location = new System.Drawing.Point(95, 65);
            this.cHealthText.Name = "cHealthText";
            this.cHealthText.Size = new System.Drawing.Size(263, 22);
            this.cHealthText.TabIndex = 10;
            // 
            // cNameText
            // 
            this.cNameText.Enabled = false;
            this.cNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cNameText.Location = new System.Drawing.Point(95, 31);
            this.cNameText.Name = "cNameText";
            this.cNameText.Size = new System.Drawing.Size(263, 22);
            this.cNameText.TabIndex = 9;
            // 
            // cHealth
            // 
            this.cHealth.AutoSize = true;
            this.cHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cName.Location = new System.Drawing.Point(22, 34);
            this.cName.Name = "cName";
            this.cName.Size = new System.Drawing.Size(48, 16);
            this.cName.TabIndex = 7;
            this.cName.Text = "Nome";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(559, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(415, 431);
            this.dataGridView1.TabIndex = 6;
            // 
            // cInventory
            // 
            this.cInventory.AutoSize = true;
            this.cInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cInventory.Location = new System.Drawing.Point(555, 34);
            this.cInventory.Name = "cInventory";
            this.cInventory.Size = new System.Drawing.Size(83, 20);
            this.cInventory.TabIndex = 12;
            this.cInventory.Text = "Inventory";
            // 
            // cLevel
            // 
            this.cLevel.AutoSize = true;
            this.cLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLevel.Location = new System.Drawing.Point(22, 100);
            this.cLevel.Name = "cLevel";
            this.cLevel.Size = new System.Drawing.Size(45, 16);
            this.cLevel.TabIndex = 13;
            this.cLevel.Text = "Level";
            // 
            // cLevelText
            // 
            this.cLevelText.Enabled = false;
            this.cLevelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLevelText.Location = new System.Drawing.Point(95, 97);
            this.cLevelText.Name = "cLevelText";
            this.cLevelText.Size = new System.Drawing.Size(89, 22);
            this.cLevelText.TabIndex = 14;
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 528);
            this.Controls.Add(this.cLevelText);
            this.Controls.Add(this.cLevel);
            this.Controls.Add(this.cInventory);
            this.Controls.Add(this.inventoryToggle);
            this.Controls.Add(this.cHealthText);
            this.Controls.Add(this.cNameText);
            this.Controls.Add(this.cHealth);
            this.Controls.Add(this.cName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainGame";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label cInventory;
        private System.Windows.Forms.Label cLevel;
        private System.Windows.Forms.TextBox cLevelText;
    }
}