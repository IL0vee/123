namespace AccountingLibrary
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.accountingLibraryDataSet = new AccountingLibrary.AccountingLibraryDataSet();
            this.учетКнигBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.учет_книгTableAdapter = new AccountingLibrary.AccountingLibraryDataSetTableAdapters.Учет_книгTableAdapter();
            this.кодкнигDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияАвтораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяАвтораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоАвтораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.учетЧитателейBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.учет_читателейTableAdapter = new AccountingLibrary.AccountingLibraryDataSetTableAdapters.Учет_читателейTableAdapter();
            this.кодчитательDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаДобавленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.учетВыдачиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.учет_выдачиTableAdapter = new AccountingLibrary.AccountingLibraryDataSetTableAdapters.Учет_выдачиTableAdapter();
            this.кодвыдачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодкнигDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодчитательDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВыдачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусВыдачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетКнигBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетЧитателейBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетВыдачиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(713, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 38);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 407);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(112, 41);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Выйти из аккаунта";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(704, 390);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(696, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Книги";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодкнигDataGridViewTextBoxColumn,
            this.названиеКнигиDataGridViewTextBoxColumn,
            this.фамилияАвтораDataGridViewTextBoxColumn,
            this.имяАвтораDataGridViewTextBoxColumn,
            this.отчествоАвтораDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.учетКнигBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(684, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(696, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Читатели";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодчитательDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.датаДобавленияDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.учетЧитателейBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(684, 355);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(696, 364);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Выдачи";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодвыдачиDataGridViewTextBoxColumn,
            this.кодкнигDataGridViewTextBoxColumn1,
            this.кодчитательDataGridViewTextBoxColumn1,
            this.датаВыдачиDataGridViewTextBoxColumn,
            this.статусВыдачиDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.учетВыдачиBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(684, 352);
            this.dataGridView3.TabIndex = 0;
            // 
            // accountingLibraryDataSet
            // 
            this.accountingLibraryDataSet.DataSetName = "AccountingLibraryDataSet";
            this.accountingLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // учетКнигBindingSource
            // 
            this.учетКнигBindingSource.DataMember = "Учет книг";
            this.учетКнигBindingSource.DataSource = this.accountingLibraryDataSet;
            // 
            // учет_книгTableAdapter
            // 
            this.учет_книгTableAdapter.ClearBeforeFill = true;
            // 
            // кодкнигDataGridViewTextBoxColumn
            // 
            this.кодкнигDataGridViewTextBoxColumn.DataPropertyName = "Код_книг";
            this.кодкнигDataGridViewTextBoxColumn.HeaderText = "Код_книг";
            this.кодкнигDataGridViewTextBoxColumn.Name = "кодкнигDataGridViewTextBoxColumn";
            // 
            // названиеКнигиDataGridViewTextBoxColumn
            // 
            this.названиеКнигиDataGridViewTextBoxColumn.DataPropertyName = "Название книги";
            this.названиеКнигиDataGridViewTextBoxColumn.HeaderText = "Название книги";
            this.названиеКнигиDataGridViewTextBoxColumn.Name = "названиеКнигиDataGridViewTextBoxColumn";
            // 
            // фамилияАвтораDataGridViewTextBoxColumn
            // 
            this.фамилияАвтораDataGridViewTextBoxColumn.DataPropertyName = "Фамилия автора";
            this.фамилияАвтораDataGridViewTextBoxColumn.HeaderText = "Фамилия автора";
            this.фамилияАвтораDataGridViewTextBoxColumn.Name = "фамилияАвтораDataGridViewTextBoxColumn";
            // 
            // имяАвтораDataGridViewTextBoxColumn
            // 
            this.имяАвтораDataGridViewTextBoxColumn.DataPropertyName = "Имя автора";
            this.имяАвтораDataGridViewTextBoxColumn.HeaderText = "Имя автора";
            this.имяАвтораDataGridViewTextBoxColumn.Name = "имяАвтораDataGridViewTextBoxColumn";
            // 
            // отчествоАвтораDataGridViewTextBoxColumn
            // 
            this.отчествоАвтораDataGridViewTextBoxColumn.DataPropertyName = "Отчество автора";
            this.отчествоАвтораDataGridViewTextBoxColumn.HeaderText = "Отчество автора";
            this.отчествоАвтораDataGridViewTextBoxColumn.Name = "отчествоАвтораDataGridViewTextBoxColumn";
            // 
            // учетЧитателейBindingSource
            // 
            this.учетЧитателейBindingSource.DataMember = "Учет читателей";
            this.учетЧитателейBindingSource.DataSource = this.accountingLibraryDataSet;
            // 
            // учет_читателейTableAdapter
            // 
            this.учет_читателейTableAdapter.ClearBeforeFill = true;
            // 
            // кодчитательDataGridViewTextBoxColumn
            // 
            this.кодчитательDataGridViewTextBoxColumn.DataPropertyName = "Код_читатель";
            this.кодчитательDataGridViewTextBoxColumn.HeaderText = "Код_читатель";
            this.кодчитательDataGridViewTextBoxColumn.Name = "кодчитательDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // датаДобавленияDataGridViewTextBoxColumn
            // 
            this.датаДобавленияDataGridViewTextBoxColumn.DataPropertyName = "Дата добавления";
            this.датаДобавленияDataGridViewTextBoxColumn.HeaderText = "Дата добавления";
            this.датаДобавленияDataGridViewTextBoxColumn.Name = "датаДобавленияDataGridViewTextBoxColumn";
            // 
            // учетВыдачиBindingSource
            // 
            this.учетВыдачиBindingSource.DataMember = "Учет выдачи";
            this.учетВыдачиBindingSource.DataSource = this.accountingLibraryDataSet;
            // 
            // учет_выдачиTableAdapter
            // 
            this.учет_выдачиTableAdapter.ClearBeforeFill = true;
            // 
            // кодвыдачиDataGridViewTextBoxColumn
            // 
            this.кодвыдачиDataGridViewTextBoxColumn.DataPropertyName = "Код_выдачи";
            this.кодвыдачиDataGridViewTextBoxColumn.HeaderText = "Код_выдачи";
            this.кодвыдачиDataGridViewTextBoxColumn.Name = "кодвыдачиDataGridViewTextBoxColumn";
            // 
            // кодкнигDataGridViewTextBoxColumn1
            // 
            this.кодкнигDataGridViewTextBoxColumn1.DataPropertyName = "Код_книг";
            this.кодкнигDataGridViewTextBoxColumn1.HeaderText = "Код_книг";
            this.кодкнигDataGridViewTextBoxColumn1.Name = "кодкнигDataGridViewTextBoxColumn1";
            // 
            // кодчитательDataGridViewTextBoxColumn1
            // 
            this.кодчитательDataGridViewTextBoxColumn1.DataPropertyName = "Код_читатель";
            this.кодчитательDataGridViewTextBoxColumn1.HeaderText = "Код_читатель";
            this.кодчитательDataGridViewTextBoxColumn1.Name = "кодчитательDataGridViewTextBoxColumn1";
            // 
            // датаВыдачиDataGridViewTextBoxColumn
            // 
            this.датаВыдачиDataGridViewTextBoxColumn.DataPropertyName = "Дата выдачи";
            this.датаВыдачиDataGridViewTextBoxColumn.HeaderText = "Дата выдачи";
            this.датаВыдачиDataGridViewTextBoxColumn.Name = "датаВыдачиDataGridViewTextBoxColumn";
            // 
            // статусВыдачиDataGridViewTextBoxColumn
            // 
            this.статусВыдачиDataGridViewTextBoxColumn.DataPropertyName = "Статус выдачи";
            this.статусВыдачиDataGridViewTextBoxColumn.HeaderText = "Статус выдачи";
            this.статусВыдачиDataGridViewTextBoxColumn.Name = "статусВыдачиDataGridViewTextBoxColumn";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетКнигBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетЧитателейBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетВыдачиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private AccountingLibraryDataSet accountingLibraryDataSet;
        private System.Windows.Forms.BindingSource учетКнигBindingSource;
        private AccountingLibraryDataSetTableAdapters.Учет_книгTableAdapter учет_книгTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодкнигDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияАвтораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяАвтораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоАвтораDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource учетЧитателейBindingSource;
        private AccountingLibraryDataSetTableAdapters.Учет_читателейTableAdapter учет_читателейTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодчитательDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаДобавленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource учетВыдачиBindingSource;
        private AccountingLibraryDataSetTableAdapters.Учет_выдачиTableAdapter учет_выдачиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодвыдачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодкнигDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодчитательDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВыдачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусВыдачиDataGridViewTextBoxColumn;
    }
}