namespace beta_application1
{
    partial class create_new_day
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
            this.logo = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btBack = new System.Windows.Forms.Button();
            this.btHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btGo_Day = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(195, 200);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(400, 400);
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(62, 932);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(661, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(0, 0);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(108, 49);
            this.btBack.TabIndex = 3;
            this.btBack.Text = "Назад";
            this.btBack.UseVisualStyleBackColor = true;
            // 
            // btHome
            // 
            this.btHome.Location = new System.Drawing.Point(660, 0);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(108, 49);
            this.btHome.TabIndex = 4;
            this.btHome.Text = "Домой";
            this.btHome.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(283, 982);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 52);
            this.label1.TabIndex = 5;
            this.label1.Text = "Тематика";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 1037);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(661, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // btGo_Day
            // 
            this.btGo_Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btGo_Day.Location = new System.Drawing.Point(0, 1388);
            this.btGo_Day.Name = "btGo_Day";
            this.btGo_Day.Size = new System.Drawing.Size(768, 187);
            this.btGo_Day.TabIndex = 7;
            this.btGo_Day.Text = "Начать тренировку ";
            this.btGo_Day.UseVisualStyleBackColor = true;
            this.btGo_Day.Click += new System.EventHandler(this.btGo_Day_Click);
            // 
            // create_new_day
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 1570);
            this.Controls.Add(this.btGo_Day);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btHome);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.logo);
            this.Name = "create_new_day";
            this.Text = "create_new_day";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btGo_Day;
    }
}