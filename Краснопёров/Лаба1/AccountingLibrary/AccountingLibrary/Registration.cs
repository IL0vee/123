using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AccountingLibrary
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AccountingLibrary.accdb";
            OleDbConnection conn = new OleDbConnection(connection);

            string query = "INSERT INTO [Users] ([Login], [Password]) VALUES (?, ?)";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            conn.Open();

            cmd.Parameters.AddWithValue("Login", LoginTextBox.Text);
            cmd.Parameters.AddWithValue("Password", PasswordTextBox.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Вы зарегестрировались");
        }

        private void AutorizationButton_Click(object sender, EventArgs e)
        {
            string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AccountingLibrary.accdb";
            OleDbConnection conn = new OleDbConnection(connection);

            string query = "SELECT Admin FROM Users WHERE Login = ? AND Password = ?";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            conn.Open();

            cmd.Parameters.AddWithValue("Login", LoginTextBox.Text);
            cmd.Parameters.AddWithValue("Password", PasswordTextBox.Text);

            object admin = cmd.ExecuteScalar();

            OleDbDataAdapter oda = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            conn.Close();
            if (dt.Rows.Count > 0)
            {
                if (Convert.ToInt32(admin) == 1)
                {
                    MessageBox.Show("Вы администратор");
                    AdminForm AdminForm = new AdminForm();
                    AdminForm.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Вы пользователь");
                    UserForm UserForm = new UserForm();
                    UserForm.Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
        }
    }
}
