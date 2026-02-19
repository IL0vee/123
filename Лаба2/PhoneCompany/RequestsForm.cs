using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneCompany
{
    public partial class RequestsForm : Form
    {
        public RequestsForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminForm AdminForm = new AdminForm();
            AdminForm.Show();
            Hide();
        }

        private void RequestsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "phoneCompanyDataSet._Выборка_Должники_месяца__либо_оплатили_меньше_50_рублей_". При необходимости она может быть перемещена или удалена.
            this.выборка_Должники_месяца__либо_оплатили_меньше_50_рублей_TableAdapter.Fill(this.phoneCompanyDataSet._Выборка_Должники_месяца__либо_оплатили_меньше_50_рублей_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "phoneCompanyDataSet._Выборка_Абоненты__которые_ещё_не_внесли_плату_за_текущий_месяц_". При необходимости она может быть перемещена или удалена.
            this.выборка_Абоненты__которые_ещё_не_внесли_плату_за_текущий_месяц_TableAdapter.Fill(this.phoneCompanyDataSet._Выборка_Абоненты__которые_ещё_не_внесли_плату_за_текущий_месяц_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "phoneCompanyDataSet._Выборка_Данные_об_абонентах_". При необходимости она может быть перемещена или удалена.
            this.выборка_Данные_об_абонентах_TableAdapter.Fill(this.phoneCompanyDataSet._Выборка_Данные_об_абонентах_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "phoneCompanyDataSet._Выборка_Пенсионеры_". При необходимости она может быть перемещена или удалена.
            this.выборка_Пенсионеры_TableAdapter.Fill(this.phoneCompanyDataSet._Выборка_Пенсионеры_);

        }
    }
}
