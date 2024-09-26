using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace тип
{
    public partial class NewOrderForm : Form
    {
        public string UserName { get; set; }
        public NewOrderForm(string user)
        {
            InitializeComponent();
            UserName = user;
            string[] words = UserName.Split(' ');
            if (words.Length >= 2)
            {
                string secondWord = words[1];
                label1.Text = $"Вы: {secondWord}";
            }
            else
            {
                label1.Text = "Ошибка: имя пользователя должно содержать минимум 2 слова.";
            }
            DataTable dataTable = new DataTable();

            dataTable = кнороз_практикаDataSet.Прайс;
            serviceComboBox.DataSource = dataTable;
            serviceComboBox.DisplayMember = "Название_услуги";
            serviceComboBox.ValueMember = "Id_услуги";
        }

        private void NewOrderForm_Load(object sender, EventArgs e)
        {
            this.прайсTableAdapter.Fill(this.кнороз_практикаDataSet.Прайс);
            DateTime now = DateTime.Now;
            string formattedDate = now.ToString("dd.MM.yyyy");
            string formattedTime = now.ToString("HH:mm");
            dateLabel.Text = formattedDate;
            timeLabel2.Text = formattedTime;
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(placeForCostLabel.Text) || string.IsNullOrEmpty(placeForTimeLabel.Text))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                placeForCostLabel.Text = string.Empty;
                placeForTimeLabel.Text = string.Empty;
                MessageBox.Show("Заказ создан!\nСпасибо за обращение!", "Информация", MessageBoxButtons.OK);
                
                var selectedId = serviceComboBox.SelectedValue;
                var selectedName = serviceComboBox.SelectedText;
            }
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            HelloForm helloForm = new HelloForm(UserName);
            helloForm.Location = new Point(200, 300);
            helloForm.Show();
            this.Hide();
        }
        private void serviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedId = serviceComboBox.SelectedValue;
            var row = кнороз_практикаDataSet.Прайс.Select($"ID_услуги = {selectedId}");
            placeForCostLabel.Text = row[0].ItemArray[2].ToString() + " руб.";
            placeForTimeLabel.Text = row[0].ItemArray[3].ToString();
        }
    }
}
