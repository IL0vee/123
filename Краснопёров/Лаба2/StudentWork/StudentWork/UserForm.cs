using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWork
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentWorkDataSet.Departments". При необходимости она может быть перемещена или удалена.
            this.departmentsTableAdapter.Fill(this.studentWorkDataSet.Departments);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentWorkDataSet.Directors". При необходимости она может быть перемещена или удалена.
            this.directorsTableAdapter.Fill(this.studentWorkDataSet.Directors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentWorkDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.studentWorkDataSet.Students);

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
    }
}
