namespace тип
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
            this.bgPicture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.profileIcon = new System.Windows.Forms.PictureBox();
            this.panelForEnter = new System.Windows.Forms.Panel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.mainButton = new System.Windows.Forms.Button();
            this.servicesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bgPicture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileIcon)).BeginInit();
            this.panelForEnter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // bgPicture
            // 
            this.bgPicture.Image = ((System.Drawing.Image)(resources.GetObject("bgPicture.Image")));
            this.bgPicture.Location = new System.Drawing.Point(541, 60);
            this.bgPicture.Name = "bgPicture";
            this.bgPicture.Size = new System.Drawing.Size(413, 524);
            this.bgPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bgPicture.TabIndex = 9;
            this.bgPicture.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-15, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 5);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.panel2.Location = new System.Drawing.Point(0, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 5);
            this.panel2.TabIndex = 3;
            // 
            // profileIcon
            // 
            this.profileIcon.Image = ((System.Drawing.Image)(resources.GetObject("profileIcon.Image")));
            this.profileIcon.Location = new System.Drawing.Point(130, 32);
            this.profileIcon.Name = "profileIcon";
            this.profileIcon.Size = new System.Drawing.Size(45, 44);
            this.profileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileIcon.TabIndex = 0;
            this.profileIcon.TabStop = false;
            // 
            // panelForEnter
            // 
            this.panelForEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(175)))), ((int)(((byte)(184)))));
            this.panelForEnter.Controls.Add(this.passwordTextBox);
            this.panelForEnter.Controls.Add(this.nameTextBox);
            this.panelForEnter.Controls.Add(this.profileIcon);
            this.panelForEnter.Location = new System.Drawing.Point(113, 167);
            this.panelForEnter.Name = "panelForEnter";
            this.panelForEnter.Size = new System.Drawing.Size(305, 280);
            this.panelForEnter.TabIndex = 14;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(22, 184);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(262, 20);
            this.passwordTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(22, 126);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(262, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.enterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enterButton.BackgroundImage")));
            this.enterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.enterButton.ForeColor = System.Drawing.Color.White;
            this.enterButton.Location = new System.Drawing.Point(205, 480);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(130, 45);
            this.enterButton.TabIndex = 15;
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // name
            // 
            this.name.Image = ((System.Drawing.Image)(resources.GetObject("name.Image")));
            this.name.Location = new System.Drawing.Point(91, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(203, 73);
            this.name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.name.TabIndex = 13;
            this.name.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(10, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(75, 73);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 8;
            this.logo.TabStop = false;
            // 
            // mainButton
            // 
            this.mainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(175)))), ((int)(((byte)(184)))));
            this.mainButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainButton.BackgroundImage")));
            this.mainButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainButton.Location = new System.Drawing.Point(663, -20);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(154, 98);
            this.mainButton.TabIndex = 11;
            this.mainButton.UseVisualStyleBackColor = false;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // servicesButton
            // 
            this.servicesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("servicesButton.BackgroundImage")));
            this.servicesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.servicesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.servicesButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.servicesButton.Location = new System.Drawing.Point(801, -12);
            this.servicesButton.Name = "servicesButton";
            this.servicesButton.Size = new System.Drawing.Size(159, 82);
            this.servicesButton.TabIndex = 12;
            this.servicesButton.UseVisualStyleBackColor = false;
            this.servicesButton.Click += new System.EventHandler(this.servicesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(953, 584);
            this.Controls.Add(this.bgPicture);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelForEnter);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.name);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.mainButton);
            this.Controls.Add(this.servicesButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ТипоГрафИя";
            ((System.ComponentModel.ISupportInitialize)(this.bgPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profileIcon)).EndInit();
            this.panelForEnter.ResumeLayout(false);
            this.panelForEnter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bgPicture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox profileIcon;
        private System.Windows.Forms.Panel panelForEnter;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.PictureBox name;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Button servicesButton;
    }
}

