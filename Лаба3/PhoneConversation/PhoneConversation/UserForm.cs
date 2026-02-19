using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneConversation
{
    public partial class UserForm : Form
    {
        public UserForm()
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

        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "phoneConversationDataSet.Payment". При необходимости она может быть перемещена или удалена.
            this.paymentTableAdapter.Fill(this.phoneConversationDataSet.Payment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "phoneConversationDataSet.Phones". При необходимости она может быть перемещена или удалена.
            this.phonesTableAdapter.Fill(this.phoneConversationDataSet.Phones);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "phoneConversationDataSet.Abonents". При необходимости она может быть перемещена или удалена.
            this.abonentsTableAdapter.Fill(this.phoneConversationDataSet.Abonents);

        }
    }
}
