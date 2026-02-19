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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Registration Registration = new Registration();
            Registration.Show();
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "phoneConversationDataSet._Выборка_Клиенты_которые_потратили_больше_50руб_за_последний_мес_". При необходимости она может быть перемещена или удалена.
            this.выборка_Клиенты_которые_потратили_больше_50руб_за_последний_мес_TableAdapter.Fill(this.phoneConversationDataSet._Выборка_Клиенты_которые_потратили_больше_50руб_за_последний_мес_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "phoneConversationDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.phoneConversationDataSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "phoneConversationDataSet.Payment". При необходимости она может быть перемещена или удалена.
            this.paymentTableAdapter.Fill(this.phoneConversationDataSet.Payment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "phoneConversationDataSet.Phones". При необходимости она может быть перемещена или удалена.
            this.phonesTableAdapter.Fill(this.phoneConversationDataSet.Phones);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "phoneConversationDataSet.Abonents". При необходимости она может быть перемещена или удалена.
            this.abonentsTableAdapter.Fill(this.phoneConversationDataSet.Abonents);

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.abonentsTableAdapter.Update(this.phoneConversationDataSet.Abonents);
            this.phonesTableAdapter.Update(this.phoneConversationDataSet.Phones);
            this.paymentTableAdapter.Update(this.phoneConversationDataSet.Payment);
            this.usersTableAdapter.Update(this.phoneConversationDataSet.Users);
        }
    }
}
