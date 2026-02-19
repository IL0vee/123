using System;
using System.Windows.Forms;

namespace PhoneCompany
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "phoneCompanyDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.phoneCompanyDataSet.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "phoneCompanyDataSet.Payment". При необходимости она может быть перемещена или удалена.
            this.paymentTableAdapter.Fill(this.phoneCompanyDataSet.Payment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "phoneCompanyDataSet.Phones". При необходимости она может быть перемещена или удалена.
            this.phonesTableAdapter.Fill(this.phoneCompanyDataSet.Phones);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "phoneCompanyDataSet.Abonents". При необходимости она может быть перемещена или удалена.
            this.abonentsTableAdapter.Fill(this.phoneCompanyDataSet.Abonents);

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.abonentsTableAdapter.Update(this.phoneCompanyDataSet.Abonents);
            this.phonesTableAdapter.Update(this.phoneCompanyDataSet.Phones);
            this.paymentTableAdapter.Update(this.phoneCompanyDataSet.Payment);
            this.userTableAdapter.Update(this.phoneCompanyDataSet.User);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Registration Registration = new Registration();
            Registration.Show();
            Hide();
        }

        private void RequestsButton_Click(object sender, EventArgs e)
        {
            RequestsForm RequestsForm = new RequestsForm();
            RequestsForm.Show();
            Hide();
        }
    }
}
