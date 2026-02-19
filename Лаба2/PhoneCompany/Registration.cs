using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PhoneCompany
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
            if (string.IsNullOrWhiteSpace(LoginTextBox.Text) || string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                MessageBox.Show("Введите логин и пароль.");
                return;
            }

            string conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PhoneCompany.accdb";
            string query = "INSERT INTO [User] ([Login], [Password], [Admin], [Banned]) VALUES (?, ?, ?, ?)";

            try
            {
                using (var connection = new OleDbConnection(conn))
                {
                    connection.Open();
                    using (var cmd = new OleDbCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("Login", LoginTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("Password", PasswordTextBox.Text);
                        cmd.Parameters.AddWithValue("Admin", false);
                        cmd.Parameters.AddWithValue("Banned", false);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Вы успешно зарегистрировались!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при регистрации: " + ex.Message);
            }
        }

        private int loginAttempts = 0;
        private const int MAX_ATTEMPTS = 3;

        private void AutorizationButton_Click(object sender, EventArgs e)
        {
            string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PhoneCompany.accdb";

            using (var connection = new OleDbConnection(connStr))
            {
                connection.Open();

                string query = @"SELECT [Admin], [Banned] FROM [User] WHERE [Login] = ? AND [Password] = ?";

                using (var cmd = new OleDbCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("Login", LoginTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("Password", PasswordTextBox.Text);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bool isBanned = false;
                            object bannedObj = reader["Banned"];
                            if (bannedObj != DBNull.Value)
                                isBanned = Convert.ToBoolean(bannedObj);

                            if (isBanned)
                            {
                                MessageBox.Show("Учётная запись заблокирована.", "Доступ запрещён");
                                return;
                            }

                            bool isAdmin = false;
                            object adminObj = reader["Admin"];
                            if (adminObj != DBNull.Value)
                                isAdmin = Convert.ToBoolean(adminObj);

                            loginAttempts = 0;

                            if (isAdmin)
                            {
                                MessageBox.Show("Добро пожаловать, администратор!");
                                var frm = new AdminForm();
                                frm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Добро пожаловать!");
                                var frm = new UserForm();
                                frm.Show();
                            }

                            this.Hide();
                            return;
                        }
                    }
                }

                loginAttempts++;
                int left = MAX_ATTEMPTS - loginAttempts;

                if (left > 0)
                {
                    MessageBox.Show($"Неверный логин или пароль.\nОсталось попыток: {left}", "Ошибка авторизации");
                }
                else
                {
                    BanUser(LoginTextBox.Text.Trim());
                    MessageBox.Show("Превышено количество попыток. Учётная запись заблокирована.", "Доступ запрещён");
                }
            }
        }

        private void BanUser(string login)
        {
            string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PhoneCompany.accdb";

            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                string sql = "UPDATE [User] SET [Banned] = ? WHERE [Login] = ?";

                using (var cmd = new OleDbCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("Banned", true);
                    cmd.Parameters.AddWithValue("Login", login);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
