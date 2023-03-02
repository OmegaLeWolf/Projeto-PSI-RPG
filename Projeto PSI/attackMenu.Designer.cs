namespace Projeto_PSI
{
    partial class attackMenu
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
            this.eHealth = new System.Windows.Forms.Label();
            this.eHealthText = new System.Windows.Forms.TextBox();
            this.cLevelText = new System.Windows.Forms.TextBox();
            this.cLevel = new System.Windows.Forms.Label();
            this.cHealthText = new System.Windows.Forms.TextBox();
            this.cHealth = new System.Windows.Forms.Label();
            this.cAttack = new System.Windows.Forms.Button();
            this.cHeal = new System.Windows.Forms.Button();
            this.cEscape = new System.Windows.Forms.Button();
            this.eLevelText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eHealth
            // 
            this.eHealth.AutoSize = true;
            this.eHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eHealth.ForeColor = System.Drawing.Color.White;
            this.eHealth.Location = new System.Drawing.Point(23, 33);
            this.eHealth.Name = "eHealth";
            this.eHealth.Size = new System.Drawing.Size(103, 16);
            this.eHealth.TabIndex = 19;
            this.eHealth.Text = "Enemy Health";
            // 
            // eHealthText
            // 
            this.eHealthText.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.eHealthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eHealthText.ForeColor = System.Drawing.Color.White;
            this.eHealthText.Location = new System.Drawing.Point(145, 30);
            this.eHealthText.Name = "eHealthText";
            this.eHealthText.ReadOnly = true;
            this.eHealthText.Size = new System.Drawing.Size(89, 22);
            this.eHealthText.TabIndex = 20;
            // 
            // cLevelText
            // 
            this.cLevelText.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cLevelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLevelText.ForeColor = System.Drawing.Color.White;
            this.cLevelText.Location = new System.Drawing.Point(96, 280);
            this.cLevelText.Name = "cLevelText";
            this.cLevelText.ReadOnly = true;
            this.cLevelText.Size = new System.Drawing.Size(89, 22);
            this.cLevelText.TabIndex = 18;
            // 
            // cLevel
            // 
            this.cLevel.AutoSize = true;
            this.cLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLevel.ForeColor = System.Drawing.Color.White;
            this.cLevel.Location = new System.Drawing.Point(23, 283);
            this.cLevel.Name = "cLevel";
            this.cLevel.Size = new System.Drawing.Size(45, 16);
            this.cLevel.TabIndex = 17;
            this.cLevel.Text = "Level";
            // 
            // cHealthText
            // 
            this.cHealthText.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cHealthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cHealthText.ForeColor = System.Drawing.Color.White;
            this.cHealthText.Location = new System.Drawing.Point(96, 248);
            this.cHealthText.Name = "cHealthText";
            this.cHealthText.ReadOnly = true;
            this.cHealthText.Size = new System.Drawing.Size(89, 22);
            this.cHealthText.TabIndex = 16;
            // 
            // cHealth
            // 
            this.cHealth.AutoSize = true;
            this.cHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cHealth.ForeColor = System.Drawing.Color.White;
            this.cHealth.Location = new System.Drawing.Point(23, 251);
            this.cHealth.Name = "cHealth";
            this.cHealth.Size = new System.Drawing.Size(52, 16);
            this.cHealth.TabIndex = 15;
            this.cHealth.Text = "Health";
            // 
            // cAttack
            // 
            this.cAttack.BackColor = System.Drawing.Color.Gray;
            this.cAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cAttack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cAttack.Location = new System.Drawing.Point(228, 248);
            this.cAttack.Name = "cAttack";
            this.cAttack.Size = new System.Drawing.Size(100, 56);
            this.cAttack.TabIndex = 21;
            this.cAttack.Text = "Attack";
            this.cAttack.UseVisualStyleBackColor = false;
            this.cAttack.Click += new System.EventHandler(this.cAttack_Click);
            // 
            // cHeal
            // 
            this.cHeal.BackColor = System.Drawing.Color.Gray;
            this.cHeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cHeal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cHeal.Location = new System.Drawing.Point(361, 248);
            this.cHeal.Name = "cHeal";
            this.cHeal.Size = new System.Drawing.Size(100, 56);
            this.cHeal.TabIndex = 22;
            this.cHeal.Text = "Heal";
            this.cHeal.UseVisualStyleBackColor = false;
            this.cHeal.Click += new System.EventHandler(this.cHeal_Click);
            // 
            // cEscape
            // 
            this.cEscape.BackColor = System.Drawing.Color.Gray;
            this.cEscape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cEscape.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cEscape.Location = new System.Drawing.Point(361, 344);
            this.cEscape.Name = "cEscape";
            this.cEscape.Size = new System.Drawing.Size(100, 56);
            this.cEscape.TabIndex = 23;
            this.cEscape.Text = "Run Away";
            this.cEscape.UseVisualStyleBackColor = false;
            this.cEscape.Click += new System.EventHandler(this.cEscape_Click);
            // 
            // eLevelText
            // 
            this.eLevelText.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.eLevelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eLevelText.ForeColor = System.Drawing.Color.White;
            this.eLevelText.Location = new System.Drawing.Point(145, 58);
            this.eLevelText.Name = "eLevelText";
            this.eLevelText.ReadOnly = true;
            this.eLevelText.Size = new System.Drawing.Size(89, 22);
            this.eLevelText.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Enemy Level";
            // 
            // attackMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.eLevelText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cEscape);
            this.Controls.Add(this.cHeal);
            this.Controls.Add(this.cAttack);
            this.Controls.Add(this.cLevelText);
            this.Controls.Add(this.cLevel);
            this.Controls.Add(this.eHealthText);
            this.Controls.Add(this.cHealthText);
            this.Controls.Add(this.eHealth);
            this.Controls.Add(this.cHealth);
            this.Name = "attackMenu";
            this.Text = "attackMenu";
            this.Load += new System.EventHandler(this.attackMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label eHealth;
        private System.Windows.Forms.TextBox eHealthText;
        private System.Windows.Forms.TextBox cLevelText;
        private System.Windows.Forms.Label cLevel;
        private System.Windows.Forms.TextBox cHealthText;
        private System.Windows.Forms.Label cHealth;
        private System.Windows.Forms.Button cAttack;
        private System.Windows.Forms.Button cHeal;
        private System.Windows.Forms.Button cEscape;
        private System.Windows.Forms.TextBox eLevelText;
        private System.Windows.Forms.Label label1;
    }
}