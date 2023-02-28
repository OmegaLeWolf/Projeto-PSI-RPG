namespace Projeto_PSI
{
    partial class Trading
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
            this.label1 = new System.Windows.Forms.Label();
            this.eHealthText = new System.Windows.Forms.TextBox();
            this.healingBuy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.swordBuy = new System.Windows.Forms.Button();
            this.amuletBuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eHealth
            // 
            this.eHealth.AutoSize = true;
            this.eHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eHealth.ForeColor = System.Drawing.Color.White;
            this.eHealth.Location = new System.Drawing.Point(12, 32);
            this.eHealth.Name = "eHealth";
            this.eHealth.Size = new System.Drawing.Size(54, 16);
            this.eHealth.TabIndex = 20;
            this.eHealth.Text = "Trader";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Healing Potion";
            // 
            // eHealthText
            // 
            this.eHealthText.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.eHealthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eHealthText.ForeColor = System.Drawing.Color.White;
            this.eHealthText.Location = new System.Drawing.Point(171, 90);
            this.eHealthText.Name = "eHealthText";
            this.eHealthText.ReadOnly = true;
            this.eHealthText.Size = new System.Drawing.Size(102, 22);
            this.eHealthText.TabIndex = 22;
            this.eHealthText.Text = "100";
            this.eHealthText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // healingBuy
            // 
            this.healingBuy.BackColor = System.Drawing.Color.Gray;
            this.healingBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.healingBuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.healingBuy.Location = new System.Drawing.Point(315, 90);
            this.healingBuy.Name = "healingBuy";
            this.healingBuy.Size = new System.Drawing.Size(99, 22);
            this.healingBuy.TabIndex = 23;
            this.healingBuy.Text = "Buy";
            this.healingBuy.UseVisualStyleBackColor = false;
            this.healingBuy.Click += new System.EventHandler(this.healingBuy_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(315, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 22);
            this.button1.TabIndex = 24;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(171, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(102, 22);
            this.textBox1.TabIndex = 26;
            this.textBox1.Text = "5000";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Sword";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(171, 169);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(102, 22);
            this.textBox2.TabIndex = 28;
            this.textBox2.Text = "100000";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "The Golden Amulet";
            // 
            // swordBuy
            // 
            this.swordBuy.BackColor = System.Drawing.Color.Gray;
            this.swordBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.swordBuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.swordBuy.Location = new System.Drawing.Point(315, 129);
            this.swordBuy.Name = "swordBuy";
            this.swordBuy.Size = new System.Drawing.Size(99, 22);
            this.swordBuy.TabIndex = 29;
            this.swordBuy.Text = "Buy";
            this.swordBuy.UseVisualStyleBackColor = false;
            this.swordBuy.Click += new System.EventHandler(this.swordBuy_Click);
            // 
            // amuletBuy
            // 
            this.amuletBuy.BackColor = System.Drawing.Color.Gray;
            this.amuletBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.amuletBuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.amuletBuy.Location = new System.Drawing.Point(315, 169);
            this.amuletBuy.Name = "amuletBuy";
            this.amuletBuy.Size = new System.Drawing.Size(99, 22);
            this.amuletBuy.TabIndex = 30;
            this.amuletBuy.Text = "Buy";
            this.amuletBuy.UseVisualStyleBackColor = false;
            this.amuletBuy.Click += new System.EventHandler(this.amuletBuy_Click);
            // 
            // Trading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(426, 450);
            this.Controls.Add(this.amuletBuy);
            this.Controls.Add(this.swordBuy);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.healingBuy);
            this.Controls.Add(this.eHealthText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eHealth);
            this.Name = "Trading";
            this.Text = "Trading";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eHealth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eHealthText;
        private System.Windows.Forms.Button healingBuy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button swordBuy;
        private System.Windows.Forms.Button amuletBuy;
    }
}