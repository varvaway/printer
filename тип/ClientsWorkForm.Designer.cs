namespace тип
{
    partial class ClientsWorkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsWorkForm));
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.clinetNameTextBox = new System.Windows.Forms.TextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.AddClientButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.servButton = new System.Windows.Forms.Button();
            this.clientsButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelForEnter = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelForEnter.SuspendLayout();
            this.SuspendLayout();
            // 
            // numberTextBox
            // 
            this.numberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(175)))), ((int)(((byte)(184)))));
            this.numberTextBox.Location = new System.Drawing.Point(617, 502);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(265, 20);
            this.numberTextBox.TabIndex = 40;
            // 
            // clinetNameTextBox
            // 
            this.clinetNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(175)))), ((int)(((byte)(184)))));
            this.clinetNameTextBox.Location = new System.Drawing.Point(617, 436);
            this.clinetNameTextBox.Name = "clinetNameTextBox";
            this.clinetNameTextBox.Size = new System.Drawing.Size(265, 20);
            this.clinetNameTextBox.TabIndex = 39;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.numberLabel.Location = new System.Drawing.Point(425, 498);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(189, 25);
            this.numberLabel.TabIndex = 38;
            this.numberLabel.Text = "Номер телефона:";
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.clientNameLabel.Location = new System.Drawing.Point(425, 436);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(67, 25);
            this.clientNameLabel.TabIndex = 37;
            this.clientNameLabel.Text = "ФИО:";
            // 
            // AddClientButton
            // 
            this.AddClientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.AddClientButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddClientButton.BackgroundImage")));
            this.AddClientButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddClientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.AddClientButton.ForeColor = System.Drawing.Color.White;
            this.AddClientButton.Location = new System.Drawing.Point(111, 456);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(236, 45);
            this.AddClientButton.TabIndex = 36;
            this.AddClientButton.UseVisualStyleBackColor = false;
            this.AddClientButton.Click += new System.EventHandler(this.AddServButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 5);
            this.panel1.TabIndex = 32;
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
            this.name.Location = new System.Drawing.Point(70, 10);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(171, 69);
            this.name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.name.TabIndex = 31;
            this.name.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(6, 10);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(60, 56);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 30;
            this.logo.TabStop = false;
            // 
            // servButton
            // 
            this.servButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("servButton.BackgroundImage")));
            this.servButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.servButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.servButton.Location = new System.Drawing.Point(801, -14);
            this.servButton.Name = "servButton";
            this.servButton.Size = new System.Drawing.Size(168, 98);
            this.servButton.TabIndex = 34;
            this.servButton.UseVisualStyleBackColor = true;
            this.servButton.Click += new System.EventHandler(this.servButton_Click);
            // 
            // clientsButton
            // 
            this.clientsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clientsButton.BackgroundImage")));
            this.clientsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clientsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientsButton.Location = new System.Drawing.Point(546, -12);
            this.clientsButton.Name = "clientsButton";
            this.clientsButton.Size = new System.Drawing.Size(287, 98);
            this.clientsButton.TabIndex = 33;
            this.clientsButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(906, 90);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(35, 33);
            this.backButton.TabIndex = 41;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
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
            // panelForEnter
            // 
            this.panelForEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(175)))), ((int)(((byte)(184)))));
            this.panelForEnter.Controls.Add(this.dataGridView1);
            this.panelForEnter.Location = new System.Drawing.Point(101, 115);
            this.panelForEnter.Name = "panelForEnter";
            this.panelForEnter.Size = new System.Drawing.Size(547, 280);
            this.panelForEnter.TabIndex = 35;
            // 
            // ClientsWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(953, 584);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.clinetNameTextBox);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.clientNameLabel);
            this.Controls.Add(this.AddClientButton);
            this.Controls.Add(this.panelForEnter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.servButton);
            this.Controls.Add(this.clientsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientsWorkForm";
            this.Text = "Админчик";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelForEnter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox clinetNameTextBox;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.Button AddClientButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox name;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button servButton;
        private System.Windows.Forms.Button clientsButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelForEnter;
    }
}