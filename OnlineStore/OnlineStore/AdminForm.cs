using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void ButtonExitFrom_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void RollUpForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "onlineStoreDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.onlineStoreDataSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "onlineStoreDataSet.Выборка_товаров". При необходимости она может быть перемещена или удалена.
            this.выборка_товаровTableAdapter.Fill(this.onlineStoreDataSet.Выборка_товаров);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "onlineStoreDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.onlineStoreDataSet.Orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "onlineStoreDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.onlineStoreDataSet.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "onlineStoreDataSet1.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.onlineStoreDataSet1.Clients);

        }

        private void TableClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}