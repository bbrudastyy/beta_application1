namespace beta_application1
{
    partial class Application
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
            this.logo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCreateDay = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.CBDays = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(195, 200);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(400, 400);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(63, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(0, 0);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnCreateDay
            // 
            this.btnCreateDay.Location = new System.Drawing.Point(65, 790);
            this.btnCreateDay.Name = "btnCreateDay";
            this.btnCreateDay.Size = new System.Drawing.Size(661, 150);
            this.btnCreateDay.TabIndex = 2;
            this.btnCreateDay.Text = "создать новый день";
            this.btnCreateDay.UseVisualStyleBackColor = true;
            this.btnCreateDay.Click += new System.EventHandler(this.btnCreateDay_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(392, 1388);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(395, 187);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "button2";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(0, 1388);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(395, 187);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "button3";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // CBDays
            // 
            this.CBDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBDays.FormattingEnabled = true;
            this.CBDays.Location = new System.Drawing.Point(66, 982);
            this.CBDays.Name = "CBDays";
            this.CBDays.Size = new System.Drawing.Size(661, 45);
            this.CBDays.TabIndex = 6;
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 1570);
            this.Controls.Add(this.CBDays);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnCreateDay);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.logo);
            this.Name = "Application";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCreateDay;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ComboBox CBDays;
    }
}

