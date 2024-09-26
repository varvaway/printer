using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace тип
{
    public partial class MainForm : Form
    {

        private string connectionString = "data source = ADCLG1;initial catalog = Кнороз_практика; trusted_connection = true; TrustServerCertificate = true; Pooling = false";
        public MainForm()
        {
            InitializeComponent();
            SetRoundedShape(panelForEnter, 18);
            SetRoundedShape(nameTextBox, 20);
            SetRoundedShape(passwordTextBox, 20);
            SetRoundedShape(enterButton, 40);
        }

        static void SetRoundedShape(Control control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddLine(radius, 0, control.Width - radius, 0);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(control.Width, radius, control.Width, control.Height - radius);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddLine(control.Width - radius, control.Height, radius, control.Height);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.AddLine(0, control.Height - radius, 0, radius);
            path.AddArc(0, 0, radius, radius, 180, 90);
            control.Region = new Region(path);
        }

        private void servicesButton_Click(object sender, EventArgs e)
        {
            ServForm servForm = new ServForm();
            servForm.Show();
            this.Hide();
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обновление...", "Информация", MessageBoxButtons.OK);
            nameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = nameTextBox.Text;
            string password = passwordTextBox.Text;

            if (ValidateCredentials(username, password))
            {
                if (username == "admin" && password == "12345")
                {
                    ClientsWorkForm clientsWorkForm = new ClientsWorkForm();
                    clientsWorkForm.Show();
                    this.Hide();
                }
                else
                {
                    HelloForm helloForm = new HelloForm(username);
                    helloForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Неверные учетные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateCredentials(string username, string password)
        {
            if (username == "admin" && password == "12345")
                return true;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query =  $"SELECT COUNT(*) FROM Клиенты WHERE ФИО_клиента = '{username}' AND Номер_телефона = {password}";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при проверке учетных данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
    }
}