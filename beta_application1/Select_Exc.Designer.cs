namespace beta_application1
{
    partial class Select_Exc
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
            this.btHome = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.LDate = new System.Windows.Forms.Label();
            this.LTheme = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btHome
            // 
            this.btHome.Location = new System.Drawing.Point(661, 0);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(108, 49);
            this.btHome.TabIndex = 6;
            this.btHome.Text = "Домой";
            this.btHome.UseVisualStyleBackColor = true;
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(1, 0);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(108, 49);
            this.btBack.TabIndex = 5;
            this.btBack.Text = "Назад";
            this.btBack.UseVisualStyleBackColor = true;
            // 
            // LDate
            // 
            this.LDate.AutoSize = true;
            this.LDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LDate.Location = new System.Drawing.Point(245, 172);
            this.LDate.Name = "LDate";
            this.LDate.Size = new System.Drawing.Size(285, 59);
            this.LDate.TabIndex = 7;
            this.LDate.Text = "29.02.2020";
            this.LDate.Click += new System.EventHandler(this.LDate_Click);
            // 
            // LTheme
            // 
            this.LTheme.AutoSize = true;
            this.LTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LTheme.Location = new System.Drawing.Point(316, 292);
            this.LTheme.Name = "LTheme";
            this.LTheme.Size = new System.Drawing.Size(141, 59);
            this.LTheme.TabIndex = 8;
            this.LTheme.Text = "Ноги";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(364, 495);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Select_Exc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 1570);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LTheme);
            this.Controls.Add(this.LDate);
            this.Controls.Add(this.btHome);
            this.Controls.Add(this.btBack);
            this.Name = "Select_Exc";
            this.Text = "Select_Exc";
            this.Load += new System.EventHandler(this.Select_Exc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label LDate;
        private System.Windows.Forms.Label LTheme;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}