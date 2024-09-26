using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace тип
{
    public partial class ClientsWorkForm : Form
    {
        private string connectionString = "data source = ADCLG1;initial catalog = Кнороз_практика;trusted_connection = true;TrustServerCertificate = true;Pooling = false";
        public string UserName { get; set; }
        public ClientsWorkForm()
        {
            InitializeComponent();
            UserName = "admin";
            LoadEmployees();
        }

        private void AddServButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clinetNameTextBox.Text) || string.IsNullOrEmpty(numberTextBox.Text))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] clientNameParts = clinetNameTextBox.Text.Split(' ');
            if (clientNameParts.Length != 3)
            {
                MessageBox.Show("ФИО клиента должно состоять из 3 слов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isValidName = true;
            foreach (string part in clientNameParts)
            {
                if (!char.IsUpper(part[0]))
                {
                    isValidName = false;
                    break;
                }
            }
            if (!isValidName)
            {
                MessageBox.Show("Каждое слово в имени клиента должно начинаться с заглавной буквы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numberTextBox.Text.Length != 11 || !numberTextBox.Text.All(char.IsDigit))
            {
                MessageBox.Show("Номер телефона должен состоять из 11 цифр.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query =  $"INSERT INTO Клиенты (ФИО_клиента, Номер_телефона) VALUES ('{clinetNameTextBox.Text}', '{numberTextBox.Text}')";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Клиент добавлен", " ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                clinetNameTextBox.Text = string.Empty;
                numberTextBox.Text = string.Empty;
                LoadEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления клиента: " + ex.Message);
            }
        }

        private void servButton_Click(object sender, EventArgs e)
        {
            AdminMainForm adminMainForm = new AdminMainForm();
            adminMainForm.Location = new Point(200, 300);
            adminMainForm.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Location = new Point(200, 300);
            mainForm.Show();
            this.Hide();
        }
        private void LoadEmployees()
        {
            try
            {
                string query = "SELECT * FROM Клиенты";
                SqlConnection connection = new SqlConnection(connectionString);
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки клиентов: " + ex.Message);
            }
           
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            // Проверка на комбинацию клавиш Ctrl + O
            if (e.Control && e.KeyCode == Keys.O)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                if (rowIndex >= 0)
                {
                    try
                    {
                        int clientId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value);
                        DeleteClientFromDatabase(clientId);
                        dataGridView1.Rows.RemoveAt(rowIndex);
                        MessageBox.Show("Клиент успешно удален.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка удаления клиента: " + ex.Message);
                    }
                }
            }
            // Проверка на комбинацию клавиш Ctrl + P
            else if (e.Control && e.KeyCode == Keys.P)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                if (rowIndex >= 0)
                {
                    try
                    {
                        int clientId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value);
                        UpdateClientFromDatabase(clientId, clinetNameTextBox.Text,numberTextBox.Text);
                        LoadEmployees();
                        clinetNameTextBox.Text = string.Empty;
                        numberTextBox.Text = string.Empty;
                        MessageBox.Show("Клиент успешно отредактирован.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка редактирования клиента " + ex.Message);
                    }
                }
            }
        }

        private void UpdateClientFromDatabase(int clientId, string clientName, string clientPhone)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Клиенты SET ФИО_клиента = @ClientName, Номер_телефона = @ClientPhone WHERE ID_Клиента = @ClientId", connection))
                {
                    command.Parameters.AddWithValue("@ClientId", clientId);
                    command.Parameters.AddWithValue("@ClientName", clientName);
                    command.Parameters.AddWithValue("@ClientPhone", clientPhone);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void DeleteClientFromDatabase(int clientId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                 connection.Open();
                 using (SqlCommand command = new SqlCommand("DELETE FROM Клиенты WHERE ID_Клиента = @ClientId", connection))
                 {
                     command.Parameters.AddWithValue("@ClientId", clientId);
                     command.ExecuteNonQuery();
                 }
             }
        }
    }
}
