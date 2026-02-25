namespace AccountingLibrary
{
    partial class AdminForm
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
            this.кодкнигDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияАвтораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяАвтораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоАвтораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.учетКнигBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingLibraryDataSet = new AccountingLibrary.AccountingLibraryDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодчитательDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаДобавленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.учетЧитателейBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.кодвыдачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодкнигDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодчитательDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВыдачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусВыдачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.учетВыдачиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.idUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.кодкнигDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияАвтораDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяАвтораDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоАвтораDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусВыдачиDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.запрос1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.учет_книгTableAdapter = new AccountingLibrary.AccountingLibraryDataSetTableAdapters.Учет_книгTableAdapter();
            this.учет_читателейTableAdapter = new AccountingLibrary.AccountingLibraryDataSetTableAdapters.Учет_читателейTableAdapter();
            this.учет_выдачиTableAdapter = new AccountingLibrary.AccountingLibraryDataSetTableAdapters.Учет_выдачиTableAdapter();
            this.usersTableAdapter = new AccountingLibrary.AccountingLibraryDataSetTableAdapters.UsersTableAdapter();
            this.запрос1TableAdapter = new AccountingLibrary.AccountingLibraryDataSetTableAdapters.Запрос1TableAdapter();
            this.SaveButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетКнигBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingLibraryDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетЧитателейBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетВыдачиBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(713, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 38);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(13, 408);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(112, 41);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Выйти из аккаунта";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(704, 390);
            this.tabControl1.TabIndex = 6;
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
            // учетКнигBindingSource
            // 
            this.учетКнигBindingSource.DataMember = "Учет книг";
            this.учетКнигBindingSource.DataSource = this.accountingLibraryDataSet;
            // 
            // accountingLibraryDataSet
            // 
            this.accountingLibraryDataSet.DataSetName = "AccountingLibraryDataSet";
            this.accountingLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // учетЧитателейBindingSource
            // 
            this.учетЧитателейBindingSource.DataMember = "Учет читателей";
            this.учетЧитателейBindingSource.DataSource = this.accountingLibraryDataSet;
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
            // учетВыдачиBindingSource
            // 
            this.учетВыдачиBindingSource.DataMember = "Учет выдачи";
            this.учетВыдачиBindingSource.DataSource = this.accountingLibraryDataSet;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(696, 364);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Пользователи";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUserDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.adminDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.usersBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(687, 355);
            this.dataGridView4.TabIndex = 0;
            // 
            // idUserDataGridViewTextBoxColumn
            // 
            this.idUserDataGridViewTextBoxColumn.DataPropertyName = "Id_User";
            this.idUserDataGridViewTextBoxColumn.HeaderText = "Id_User";
            this.idUserDataGridViewTextBoxColumn.Name = "idUserDataGridViewTextBoxColumn";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // adminDataGridViewTextBoxColumn
            // 
            this.adminDataGridViewTextBoxColumn.DataPropertyName = "Admin";
            this.adminDataGridViewTextBoxColumn.HeaderText = "Admin";
            this.adminDataGridViewTextBoxColumn.Name = "adminDataGridViewTextBoxColumn";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.accountingLibraryDataSet;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(696, 364);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Запрос";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодкнигDataGridViewTextBoxColumn2,
            this.фамилияАвтораDataGridViewTextBoxColumn1,
            this.имяАвтораDataGridViewTextBoxColumn1,
            this.отчествоАвтораDataGridViewTextBoxColumn1,
            this.статусВыдачиDataGridViewTextBoxColumn1});
            this.dataGridView5.DataSource = this.запрос1BindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(6, 6);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(684, 352);
            this.dataGridView5.TabIndex = 0;
            // 
            // кодкнигDataGridViewTextBoxColumn2
            // 
            this.кодкнигDataGridViewTextBoxColumn2.DataPropertyName = "Код_книг";
            this.кодкнигDataGridViewTextBoxColumn2.HeaderText = "Код_книг";
            this.кодкнигDataGridViewTextBoxColumn2.Name = "кодкнигDataGridViewTextBoxColumn2";
            // 
            // фамилияАвтораDataGridViewTextBoxColumn1
            // 
            this.фамилияАвтораDataGridViewTextBoxColumn1.DataPropertyName = "Фамилия автора";
            this.фамилияАвтораDataGridViewTextBoxColumn1.HeaderText = "Фамилия автора";
            this.фамилияАвтораDataGridViewTextBoxColumn1.Name = "фамилияАвтораDataGridViewTextBoxColumn1";
            // 
            // имяАвтораDataGridViewTextBoxColumn1
            // 
            this.имяАвтораDataGridViewTextBoxColumn1.DataPropertyName = "Имя автора";
            this.имяАвтораDataGridViewTextBoxColumn1.HeaderText = "Имя автора";
            this.имяАвтораDataGridViewTextBoxColumn1.Name = "имяАвтораDataGridViewTextBoxColumn1";
            // 
            // отчествоАвтораDataGridViewTextBoxColumn1
            // 
            this.отчествоАвтораDataGridViewTextBoxColumn1.DataPropertyName = "Отчество автора";
            this.отчествоАвтораDataGridViewTextBoxColumn1.HeaderText = "Отчество автора";
            this.отчествоАвтораDataGridViewTextBoxColumn1.Name = "отчествоАвтораDataGridViewTextBoxColumn1";
            // 
            // статусВыдачиDataGridViewTextBoxColumn1
            // 
            this.статусВыдачиDataGridViewTextBoxColumn1.DataPropertyName = "Статус выдачи";
            this.статусВыдачиDataGridViewTextBoxColumn1.HeaderText = "Статус выдачи";
            this.статусВыдачиDataGridViewTextBoxColumn1.Name = "статусВыдачиDataGridViewTextBoxColumn1";
            // 
            // запрос1BindingSource
            // 
            this.запрос1BindingSource.DataMember = "Запрос1";
            this.запрос1BindingSource.DataSource = this.accountingLibraryDataSet;
            // 
            // учет_книгTableAdapter
            // 
            this.учет_книгTableAdapter.ClearBeforeFill = true;
            // 
            // учет_читателейTableAdapter
            // 
            this.учет_читателейTableAdapter.ClearBeforeFill = true;
            // 
            // учет_выдачиTableAdapter
            // 
            this.учет_выдачиTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // запрос1TableAdapter
            // 
            this.запрос1TableAdapter.ClearBeforeFill = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(714, 57);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 35);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетКнигBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingLibraryDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетЧитателейBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетВыдачиBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AccountingLibraryDataSet accountingLibraryDataSet;
        private System.Windows.Forms.BindingSource учетКнигBindingSource;
        private AccountingLibraryDataSetTableAdapters.Учет_книгTableAdapter учет_книгTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодкнигDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияАвтораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяАвтораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоАвтораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource учетЧитателейBindingSource;
        private AccountingLibraryDataSetTableAdapters.Учет_читателейTableAdapter учет_читателейTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодчитательDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаДобавленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource учетВыдачиBindingSource;
        private AccountingLibraryDataSetTableAdapters.Учет_выдачиTableAdapter учет_выдачиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодвыдачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодкнигDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодчитательDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВыдачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусВыдачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private AccountingLibraryDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.BindingSource запрос1BindingSource;
        private AccountingLibraryDataSetTableAdapters.Запрос1TableAdapter запрос1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодкнигDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияАвтораDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяАвтораDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоАвтораDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусВыдачиDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button SaveButton;
    }
}