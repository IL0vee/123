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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workContractsDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.workContractsDataSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workContractsDataSet.Вывод_сотрудников_со_срочным_проектоми_зарплата". При необходимости она может быть перемещена или удалена.
            this.вывод_сотрудников_со_срочным_проектоми_зарплатаTableAdapter.Fill(this.workContractsDataSet.Вывод_сотрудников_со_срочным_проектоми_зарплата);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workContractsDataSet.Employment". При необходимости она может быть перемещена или удалена.
            this.employmentTableAdapter.Fill(this.workContractsDataSet.Employment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workContractsDataSet.Project". При необходимости она может быть перемещена или удалена.
            this.projectTableAdapter.Fill(this.workContractsDataSet.Project);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workContractsDataSet.Role". При необходимости она может быть перемещена или удалена.
            this.roleTableAdapter.Fill(this.workContractsDataSet.Role);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workContractsDataSet.Staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this.workContractsDataSet.Staff);

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.staffTableAdapter.Update(this.workContractsDataSet.Staff);
            this.roleTableAdapter.Update(this.workContractsDataSet.Role);
            this.projectTableAdapter.Update(this.workContractsDataSet.Project);
            this.employmentTableAdapter.Update(this.workContractsDataSet.Employment);
            this.usersTableAdapter.Update(this.workContractsDataSet.Users);
        }
    }
}
