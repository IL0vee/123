using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkContracts
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workContractsDataSet.Employment". При необходимости она может быть перемещена или удалена.
            this.employmentTableAdapter.Fill(this.workContractsDataSet.Employment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workContractsDataSet.Project". При необходимости она может быть перемещена или удалена.
            this.projectTableAdapter.Fill(this.workContractsDataSet.Project);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workContractsDataSet.Role". При необходимости она может быть перемещена или удалена.
            this.roleTableAdapter.Fill(this.workContractsDataSet.Role);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workContractsDataSet.Staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this.workContractsDataSet.Staff);

        }
    }
}
