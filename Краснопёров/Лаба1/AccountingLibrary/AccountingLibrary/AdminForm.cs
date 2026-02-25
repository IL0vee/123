using System;
using System.Windows.Forms;

namespace AccountingLibrary
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountingLibraryDataSet.Запрос1". При необходимости она может быть перемещена или удалена.
            this.запрос1TableAdapter.Fill(this.accountingLibraryDataSet.Запрос1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountingLibraryDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.accountingLibraryDataSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountingLibraryDataSet.Учет_выдачи". При необходимости она может быть перемещена или удалена.
            this.учет_выдачиTableAdapter.Fill(this.accountingLibraryDataSet.Учет_выдачи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountingLibraryDataSet.Учет_читателей". При необходимости она может быть перемещена или удалена.
            this.учет_читателейTableAdapter.Fill(this.accountingLibraryDataSet.Учет_читателей);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountingLibraryDataSet.Учет_книг". При необходимости она может быть перемещена или удалена.
            this.учет_книгTableAdapter.Fill(this.accountingLibraryDataSet.Учет_книг);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.учет_книгTableAdapter.Update(this.accountingLibraryDataSet.Учет_книг);
            this.учет_читателейTableAdapter.Update(this.accountingLibraryDataSet.Учет_читателей);
            this.учет_выдачиTableAdapter.Update(this.accountingLibraryDataSet.Учет_выдачи);
            this.usersTableAdapter.Update(this.accountingLibraryDataSet.Users);
        }
    }
}
