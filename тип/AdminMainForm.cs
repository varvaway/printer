using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace тип
{
    public partial class AdminMainForm : Form
    {
        private string connectionString = "data source = ADCLG1;initial catalog = Кнороз_практика;trusted_connection = true;TrustServerCertificate = true;Pooling = false";
        public string UserName { get; set; }
        public AdminMainForm()
        {
            InitializeComponent();
            LoadServ();
            SetRoundedShape(panel, 18);
            SetRoundedShape(AddServButton, 40);
            SetRoundedShape(servNameTextBox, 18);
            SetRoundedShape(servCostTextBox, 18);
            SetRoundedShape(servSrockTextBox, 18);
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

        private void clientsButton_Click(object sender, EventArgs e)
        {
            ClientsWorkForm clientsWorkForm = new ClientsWorkForm();
            clientsWorkForm.Location = new Point(200, 300);
            clientsWorkForm.Show();
            this.Hide();
        }

        private void AddServButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"INSERT INTO Прайс (Название_услуги, Стоимость, Срок) VALUES ('{servNameTextBox.Text}', '{servCostTextBox.Text}', '{servSrockTextBox.Text}')";
                    using (SqlCommand command = new SqlCommand(query, connection))
                        command.ExecuteNonQuery();
                }

                MessageBox.Show("Услуга добавлена", " ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                servNameTextBox.Text = string.Empty;
                servCostTextBox.Text = string.Empty;
                servSrockTextBox.Text = string.Empty;
                LoadServ();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления услуги: " + ex.Message);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            HelloForm helloForm = new HelloForm(UserName);
            helloForm.Location = new Point(200, 300);
            helloForm.Show();
            this.Hide();
        }
        private void LoadServ()
        {
            try
            {
                string query = "SELECT * FROM Прайс";
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
                MessageBox.Show("Ошибка загрузки услуг: " + ex.Message);
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
                        DeleteServFromDatabase(clientId);
                        dataGridView1.Rows.RemoveAt(rowIndex);
                        MessageBox.Show("Услуга успешно удалена.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка удаления услуги " + ex.Message);
                    }
                }
            }
        }
        private void DeleteServFromDatabase(int servId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Прайс WHERE ID_услуги = @ServId", connection))
                {
                    command.Parameters.AddWithValue("@ServId", servId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
