using System;
using System.Windows.Forms;

namespace StudentWork
{
    public partial class Requests : Form
    {
        public Requests()
        {
            InitializeComponent();
        }

        private void Requests_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentWorkDataSet.Суммарная_стипендия_во_всей_группе". При необходимости она может быть перемещена или удалена.
            this.суммарная_стипендия_во_всей_группеTableAdapter.Fill(this.studentWorkDataSet.Суммарная_стипендия_во_всей_группе);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentWorkDataSet.Подчёт_студентов_на_каждом_курсе". При необходимости она может быть перемещена или удалена.
            this.подчёт_студентов_на_каждом_курсеTableAdapter.Fill(this.studentWorkDataSet.Подчёт_студентов_на_каждом_курсе);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentWorkDataSet._Студенты_кафедры__Прикладная_математика_". При необходимости она может быть перемещена или удалена.
            this.студенты_кафедры__Прикладная_математика_TableAdapter.Fill(this.studentWorkDataSet._Студенты_кафедры__Прикладная_математика_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentWorkDataSet.Студенты_группы_М31". При необходимости она может быть перемещена или удалена.
            this.студенты_группы_М31TableAdapter.Fill(this.studentWorkDataSet.Студенты_группы_М31);

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminForm AdminForm = new AdminForm();
            AdminForm.Show();
            Hide();
        }
    }
}
