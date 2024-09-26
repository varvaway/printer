namespace тип
{
    partial class AdminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.clientsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddServButton = new System.Windows.Forms.Button();
            this.serviceNameLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.servNameTextBox = new System.Windows.Forms.TextBox();
            this.servCostTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.servSrockTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 5);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.panel2.Location = new System.Drawing.Point(0, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 5);
            this.panel2.TabIndex = 3;
            // 
            // name
            // 
            this.name.Image = ((System.Drawing.Image)(resources.GetObject("name.Image")));
            this.name.Location = new System.Drawing.Point(69, 5);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(171, 69);
            this.name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.name.TabIndex = 20;
            this.name.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(5, 5);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(60, 56);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 19;
            this.logo.TabStop = false;
            // 
            // clientsButton
            // 
            this.clientsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clientsButton.BackgroundImage")));
            this.clientsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clientsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientsButton.Location = new System.Drawing.Point(549, -17);
            this.clientsButton.Name = "clientsButton";
            this.clientsButton.Size = new System.Drawing.Size(287, 98);
            this.clientsButton.TabIndex = 22;
            this.clientsButton.UseVisualStyleBackColor = true;
            this.clientsButton.Click += new System.EventHandler(this.clientsButton_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(800, -19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 98);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(175)))), ((int)(((byte)(184)))));
            this.panel.Controls.Add(this.dataGridView1);
            this.panel.Location = new System.Drawing.Point(100, 110);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(547, 280);
            this.panel.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(175)))), ((int)(((byte)(184)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 280);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // AddServButton
            // 
            this.AddServButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.AddServButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddServButton.BackgroundImage")));
            this.AddServButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddServButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddServButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.AddServButton.ForeColor = System.Drawing.Color.White;
            this.AddServButton.Location = new System.Drawing.Point(110, 451);
            this.AddServButton.Name = "AddServButton";
            this.AddServButton.Size = new System.Drawing.Size(236, 45);
            this.AddServButton.TabIndex = 25;
            this.AddServButton.UseVisualStyleBackColor = false;
            this.AddServButton.Click += new System.EventHandler(this.AddServButton_Click);
            // 
            // serviceNameLabel
            // 
            this.serviceNameLabel.AutoSize = true;
            this.serviceNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serviceNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.serviceNameLabel.Location = new System.Drawing.Point(424, 426);
            this.serviceNameLabel.Name = "serviceNameLabel";
            this.serviceNameLabel.Size = new System.Drawing.Size(115, 25);
            this.serviceNameLabel.TabIndex = 26;
            this.serviceNameLabel.Text = "Название:";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.costLabel.Location = new System.Drawing.Point(424, 468);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(126, 25);
            this.costLabel.TabIndex = 27;
            this.costLabel.Text = "Стоимость:";
            // 
            // servNameTextBox
            // 
            this.servNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(175)))), ((int)(((byte)(184)))));
            this.servNameTextBox.Location = new System.Drawing.Point(624, 426);
            this.servNameTextBox.Name = "servNameTextBox";
            this.servNameTextBox.Size = new System.Drawing.Size(265, 20);
            this.servNameTextBox.TabIndex = 28;
            // 
            // servCostTextBox
            // 
            this.servCostTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(175)))), ((int)(((byte)(184)))));
            this.servCostTextBox.Location = new System.Drawing.Point(624, 469);
            this.servCostTextBox.Name = "servCostTextBox";
            this.servCostTextBox.Size = new System.Drawing.Size(265, 20);
            this.servCostTextBox.TabIndex = 29;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(906, 85);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(35, 33);
            this.backButton.TabIndex = 42;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // servSrockTextBox
            // 
            this.servSrockTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(175)))), ((int)(((byte)(184)))));
            this.servSrockTextBox.Location = new System.Drawing.Point(624, 512);
            this.servSrockTextBox.Name = "servSrockTextBox";
            this.servSrockTextBox.Size = new System.Drawing.Size(265, 20);
            this.servSrockTextBox.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.label1.Location = new System.Drawing.Point(424, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Срок выполнения:";
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(953, 584);
            this.Controls.Add(this.servSrockTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.servCostTextBox);
            this.Controls.Add(this.servNameTextBox);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.serviceNameLabel);
            this.Controls.Add(this.AddServButton);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clientsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminMainForm";
            this.Text = "Админчик";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox name;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button clientsButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button AddServButton;
        private System.Windows.Forms.Label serviceNameLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox servNameTextBox;
        private System.Windows.Forms.TextBox servCostTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox servSrockTextBox;
        private System.Windows.Forms.Label label1;
    }
}