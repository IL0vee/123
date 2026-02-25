using System;
using System.Windows.Forms;

namespace StudentWork
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Registration Registration = new Registration();
            Registration.Show();
            Hide();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentWorkDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.studentWorkDataSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentWorkDataSet.Departments". При необходимости она может быть перемещена или удалена.
            this.departmentsTableAdapter.Fill(this.studentWorkDataSet.Departments);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentWorkDataSet.Directors". При необходимости она может быть перемещена или удалена.
            this.directorsTableAdapter.Fill(this.studentWorkDataSet.Directors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentWorkDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.studentWorkDataSet.Students);

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Update(studentWorkDataSet.Students);
            this.directorsTableAdapter.Update(studentWorkDataSet.Directors);
            this.departmentsTableAdapter.Update(studentWorkDataSet.Departments);
            this.usersTableAdapter.Update(studentWorkDataSet.Users);
        }

        private void RequestsButton_Click(object sender, EventArgs e)
        {
            Requests Requests = new Requests();
            Requests.Show();
            Hide();
        }
    }
}
