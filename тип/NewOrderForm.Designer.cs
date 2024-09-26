namespace тип
{
    partial class NewOrderForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOrderForm));
            this.serviceLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.orderButton = new System.Windows.Forms.Button();
            this.serviceComboBox = new System.Windows.Forms.ComboBox();
            this.прайсBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кнороз_практикаDataSet = new тип.Кнороз_практикаDataSet();
            this.placeForCostLabel = new System.Windows.Forms.Label();
            this.placeForTimeLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel2 = new System.Windows.Forms.Label();
            this.прайсTableAdapter = new тип.Кнороз_практикаDataSetTableAdapters.ПрайсTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.прайсBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кнороз_практикаDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serviceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.serviceLabel.Location = new System.Drawing.Point(60, 199);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(193, 25);
            this.serviceLabel.TabIndex = 22;
            this.serviceLabel.Text = "Выберите услугу: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 5);
            this.panel1.TabIndex = 25;
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
            this.name.Location = new System.Drawing.Point(65, 1);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(171, 69);
            this.name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.name.TabIndex = 24;
            this.name.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(2, 6);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(60, 56);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 23;
            this.logo.TabStop = false;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.costLabel.Location = new System.Drawing.Point(60, 296);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(126, 25);
            this.costLabel.TabIndex = 26;
            this.costLabel.Text = "Стоимость:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.timeLabel.Location = new System.Drawing.Point(60, 396);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(209, 25);
            this.timeLabel.TabIndex = 27;
            this.timeLabel.Text = "Время выполнения:";
            // 
            // orderButton
            // 
            this.orderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.orderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderButton.ForeColor = System.Drawing.Color.White;
            this.orderButton.Location = new System.Drawing.Point(394, 465);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(134, 37);
            this.orderButton.TabIndex = 28;
            this.orderButton.Text = "Заказать";
            this.orderButton.UseVisualStyleBackColor = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // serviceComboBox
            // 
            this.serviceComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(175)))), ((int)(((byte)(184)))));
            this.serviceComboBox.DataSource = this.прайсBindingSource;
            this.serviceComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.serviceComboBox.FormattingEnabled = true;
            this.serviceComboBox.Location = new System.Drawing.Point(361, 203);
            this.serviceComboBox.Name = "serviceComboBox";
            this.serviceComboBox.Size = new System.Drawing.Size(276, 21);
            this.serviceComboBox.TabIndex = 29;
            this.serviceComboBox.SelectedIndexChanged += new System.EventHandler(this.serviceComboBox_SelectedIndexChanged);
            // 
            // прайсBindingSource
            // 
            this.прайсBindingSource.DataMember = "Прайс";
            this.прайсBindingSource.DataSource = this.кнороз_практикаDataSet;
            // 
            // кнороз_практикаDataSet
            // 
            this.кнороз_практикаDataSet.DataSetName = "Кнороз_практикаDataSet";
            this.кнороз_практикаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // placeForCostLabel
            // 
            this.placeForCostLabel.AutoSize = true;
            this.placeForCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.placeForCostLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.placeForCostLabel.Location = new System.Drawing.Point(276, 296);
            this.placeForCostLabel.Name = "placeForCostLabel";
            this.placeForCostLabel.Size = new System.Drawing.Size(0, 25);
            this.placeForCostLabel.TabIndex = 30;
            // 
            // placeForTimeLabel
            // 
            this.placeForTimeLabel.AutoSize = true;
            this.placeForTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.placeForTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.placeForTimeLabel.Location = new System.Drawing.Point(324, 396);
            this.placeForTimeLabel.Name = "placeForTimeLabel";
            this.placeForTimeLabel.Size = new System.Drawing.Size(0, 25);
            this.placeForTimeLabel.TabIndex = 31;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(906, 83);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(35, 33);
            this.backButton.TabIndex = 32;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.ForeColor = System.Drawing.Color.Black;
            this.dateLabel.Location = new System.Drawing.Point(710, 25);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 25);
            this.dateLabel.TabIndex = 33;
            // 
            // timeLabel2
            // 
            this.timeLabel2.AutoSize = true;
            this.timeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel2.ForeColor = System.Drawing.Color.Black;
            this.timeLabel2.Location = new System.Drawing.Point(850, 25);
            this.timeLabel2.Name = "timeLabel2";
            this.timeLabel2.Size = new System.Drawing.Size(0, 25);
            this.timeLabel2.TabIndex = 34;
            // 
            // прайсTableAdapter
            // 
            this.прайсTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.label1.Location = new System.Drawing.Point(62, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 35;
            this.label1.Text = "label1";
            // 
            // NewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(953, 584);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeLabel2);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.placeForTimeLabel);
            this.Controls.Add(this.placeForCostLabel);
            this.Controls.Add(this.serviceComboBox);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.serviceLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewOrderForm";
            this.Text = "ТипоГрафИя";
            this.Load += new System.EventHandler(this.NewOrderForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.прайсBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кнороз_практикаDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox name;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.ComboBox serviceComboBox;
        private System.Windows.Forms.Label placeForCostLabel;
        private System.Windows.Forms.Label placeForTimeLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel2;
        private Кнороз_практикаDataSet кнороз_практикаDataSet;
        private System.Windows.Forms.BindingSource прайсBindingSource;
        private Кнороз_практикаDataSetTableAdapters.ПрайсTableAdapter прайсTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}