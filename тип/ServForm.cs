using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace тип
{
    public partial class ServForm : Form
    {
        private string connectionString = "data source = ADCLG1;initial catalog = Кнороз_практика;trusted_connection = true;TrustServerCertificate = true;Pooling = false";

        public ServForm()
        {
            InitializeComponent();
  
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Location = new Point(200, 300);
            mainForm.Show();
            this.Hide();
        }

        private void ServForm_Load(object sender, EventArgs e)
        {
            this.прайсTableAdapter.Fill(this.кнороз_практикаDataSet.Прайс);
        }

    }
}
