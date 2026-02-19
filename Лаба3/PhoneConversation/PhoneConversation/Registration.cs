using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PhoneConversation
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
            string connection = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=PhoneConversation.accdb";
            OleDbConnection conn = new OleDbConnection(connection);
            conn.Open();

            string query = "INSERT INTO Users ([Login], [Password]) VALUES (?, ?)";
            OleDbCommand cmd = new OleDbCommand(query, conn);

            cmd.Parameters.AddWithValue("Login", LoginTextBox.Text);
            cmd.Parameters.AddWithValue("Password", PasswordTextBox.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Вы зарегестрировались");
            conn.Close();
        }

        private int loginAttempts = 0;
        private const int MAX_ATTEMPTS = 3;

        private void AutorizationButton_Click(object sender, EventArgs e)
        {
            string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PhoneConversation.accdb";

            using (var connection = new OleDbConnection(connStr))
            {
                connection.Open();

                string query = @"SELECT [Admin], [Banned] FROM [Users] WHERE [Login] = ? AND [Password] = ?";

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
            string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PhoneConversation.accdb";

            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                string sql = "UPDATE [Users] SET [Banned] = ? WHERE [Login] = ?";

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
