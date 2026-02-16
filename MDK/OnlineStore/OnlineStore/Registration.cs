using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace OnlineStore
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void ButtonExitFrom_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void RollUpForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {

            int adminValue = AdminCheckBox.Checked ? 1 : 0;
            string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OnlineStore.accdb;";
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();

            string query = "INSERT INTO [Users] ([Login], [Password], [Admin]) VALUES (?, ?, ?)";
            OleDbCommand cmd = new OleDbCommand(query, conn);

            cmd.Parameters.Add("Login", OleDbType.VarChar).Value = LoginTextBox.Text;
            cmd.Parameters.Add("Password", OleDbType.VarChar).Value = PasswordTextBox.Text;
            cmd.Parameters.Add("Admin", OleDbType.VarChar).Value = adminValue;

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Регистрация успешна!");
        }

        private void AutorizationButton_Click(object sender, EventArgs e)
        {
            string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OnlineStore.accdb;";

            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();

                string query = "SELECT Admin FROM Users WHERE Login=? AND Password=?";
                using (var cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", LoginTextBox.Text);
                    cmd.Parameters.AddWithValue("?", PasswordTextBox.Text);
                    OleDbDataAdapter oda = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);

                    object adminValue = cmd.ExecuteScalar();
                    if(dt.Rows.Count > 0)
                    {
                        if (adminValue != null && Convert.ToInt32(adminValue) == 1)
                        {
                            MessageBox.Show("Вход выполнен! Вы — администратор");
                            AdminForm AdminForm = new AdminForm();
                            AdminForm.Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Вход выполнен! Обычный пользователь");
                            UserForm UserForm = new UserForm();
                            UserForm.Show();
                            Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                    }
                }
            }
        }

        private void AdminCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
