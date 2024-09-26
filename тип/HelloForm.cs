using System;
using System.Drawing;
using System.Windows.Forms;

namespace тип
{
    public partial class HelloForm : Form
    {
        public string UserName { get; set; }
        public HelloForm(string user)
        {
            InitializeComponent();
            UserName = user;
            string[] words = UserName.Split(' ');
            if (words.Length >= 2)
            {
                string secondWord = words[1];
                greetingLabel.Text = $"Приветствуем Вас, {secondWord}!";
            }
            else
            {
                greetingLabel.Text = "Ошибка: имя пользователя должно содержать минимум 2 слова.";
            }
        }
        private void mainButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Location = new Point(200, 300);
            mainForm.Show();
            this.Hide();
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            NewOrderForm newOrderForm = new NewOrderForm(UserName);
            newOrderForm.Location = new Point(200, 300);
            newOrderForm.Show();
            this.Hide();
        }
    }
}
