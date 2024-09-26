namespace тип
{
    partial class ServForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServForm));
            this.name = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.прайсBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кнорозпрактикаDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кнороз_практикаDataSet = new тип.Кнороз_практикаDataSet();
            this.прайсTableAdapter = new тип.Кнороз_практикаDataSetTableAdapters.ПрайсTableAdapter();
            this.iDуслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеуслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.срокDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.прайсBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кнорозпрактикаDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кнороз_практикаDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Image = ((System.Drawing.Image)(resources.GetObject("name.Image")));
            this.name.Location = new System.Drawing.Point(68, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(171, 69);
            this.name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.name.TabIndex = 15;
            this.name.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(4, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(60, 56);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 14;
            this.logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(4, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 5);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.panel2.Location = new System.Drawing.Point(0, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 5);
            this.panel2.TabIndex = 3;
            // 
            // mainButton
            // 
            this.mainButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainButton.BackgroundImage")));
            this.mainButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainButton.Location = new System.Drawing.Point(647, -8);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(167, 98);
            this.mainButton.TabIndex = 17;
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(806, -9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 98);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(573, 320);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(175)))), ((int)(((byte)(184)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDуслугиDataGridViewTextBoxColumn,
            this.названиеуслугиDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn,
            this.срокDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.прайсBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(68, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 279);
            this.dataGridView1.TabIndex = 20;
            // 
            // прайсBindingSource
            // 
            this.прайсBindingSource.DataMember = "Прайс";
            this.прайсBindingSource.DataSource = this.кнорозпрактикаDataSetBindingSource;
            // 
            // кнорозпрактикаDataSetBindingSource
            // 
            this.кнорозпрактикаDataSetBindingSource.DataSource = this.кнороз_практикаDataSet;
            this.кнорозпрактикаDataSetBindingSource.Position = 0;
            // 
            // кнороз_практикаDataSet
            // 
            this.кнороз_практикаDataSet.DataSetName = "Кнороз_практикаDataSet";
            this.кнороз_практикаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // прайсTableAdapter
            // 
            this.прайсTableAdapter.ClearBeforeFill = true;
            // 
            // iDуслугиDataGridViewTextBoxColumn
            // 
            this.iDуслугиDataGridViewTextBoxColumn.DataPropertyName = "ID_услуги";
            this.iDуслугиDataGridViewTextBoxColumn.HeaderText = "ID_услуги";
            this.iDуслугиDataGridViewTextBoxColumn.Name = "iDуслугиDataGridViewTextBoxColumn";
            this.iDуслугиDataGridViewTextBoxColumn.Visible = false;
            // 
            // названиеуслугиDataGridViewTextBoxColumn
            // 
            this.названиеуслугиDataGridViewTextBoxColumn.DataPropertyName = "Название_услуги";
            this.названиеуслугиDataGridViewTextBoxColumn.HeaderText = "Название_услуги";
            this.названиеуслугиDataGridViewTextBoxColumn.Name = "названиеуслугиDataGridViewTextBoxColumn";
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            // 
            // срокDataGridViewTextBoxColumn
            // 
            this.срокDataGridViewTextBoxColumn.DataPropertyName = "Срок";
            this.срокDataGridViewTextBoxColumn.HeaderText = "Срок";
            this.срокDataGridViewTextBoxColumn.Name = "срокDataGridViewTextBoxColumn";
            // 
            // ServForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(953, 584);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.mainButton);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServForm";
            this.Text = "ТипоГрафИя";
            this.Load += new System.EventHandler(this.ServForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.прайсBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кнорозпрактикаDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кнороз_практикаDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox name;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource кнорозпрактикаDataSetBindingSource;
        private Кнороз_практикаDataSet кнороз_практикаDataSet;
        private System.Windows.Forms.BindingSource прайсBindingSource;
        private Кнороз_практикаDataSetTableAdapters.ПрайсTableAdapter прайсTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDуслугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеуслугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn срокDataGridViewTextBoxColumn;
    }
}