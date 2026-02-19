namespace PhoneCompany
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.phoneCompanyDataSet = new PhoneCompany.PhoneCompanyDataSet();
            this.abonentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonentsTableAdapter = new PhoneCompany.PhoneCompanyDataSetTableAdapters.AbonentsTableAdapter();
            this.idAbonentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameabonentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.phonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phonesTableAdapter = new PhoneCompany.PhoneCompanyDataSetTableAdapters.PhonesTableAdapter();
            this.idPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceInDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTableAdapter = new PhoneCompany.PhoneCompanyDataSetTableAdapters.PaymentTableAdapter();
            this.idPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAbonentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPhoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datepaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricepaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new PhoneCompany.PhoneCompanyDataSetTableAdapters.UserTableAdapter();
            this.idUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bannedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.RequestsButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(713, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 38);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(678, 377);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(670, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Абоненты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(670, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Телефоны";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(670, 351);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Оплата";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(670, 351);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Пользователи";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAbonentDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.nameabonentDataGridViewTextBoxColumn,
            this.middlenameDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.houseDataGridViewTextBoxColumn,
            this.flatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.abonentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(657, 338);
            this.dataGridView1.TabIndex = 0;
            // 
            // phoneCompanyDataSet
            // 
            this.phoneCompanyDataSet.DataSetName = "PhoneCompanyDataSet";
            this.phoneCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // abonentsBindingSource
            // 
            this.abonentsBindingSource.DataMember = "Abonents";
            this.abonentsBindingSource.DataSource = this.phoneCompanyDataSet;
            // 
            // abonentsTableAdapter
            // 
            this.abonentsTableAdapter.ClearBeforeFill = true;
            // 
            // idAbonentDataGridViewTextBoxColumn
            // 
            this.idAbonentDataGridViewTextBoxColumn.DataPropertyName = "Id_Abonent";
            this.idAbonentDataGridViewTextBoxColumn.HeaderText = "Id_Abonent";
            this.idAbonentDataGridViewTextBoxColumn.Name = "idAbonentDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // nameabonentDataGridViewTextBoxColumn
            // 
            this.nameabonentDataGridViewTextBoxColumn.DataPropertyName = "Name_abonent";
            this.nameabonentDataGridViewTextBoxColumn.HeaderText = "Name_abonent";
            this.nameabonentDataGridViewTextBoxColumn.Name = "nameabonentDataGridViewTextBoxColumn";
            // 
            // middlenameDataGridViewTextBoxColumn
            // 
            this.middlenameDataGridViewTextBoxColumn.DataPropertyName = "Middle_name";
            this.middlenameDataGridViewTextBoxColumn.HeaderText = "Middle_name";
            this.middlenameDataGridViewTextBoxColumn.Name = "middlenameDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // houseDataGridViewTextBoxColumn
            // 
            this.houseDataGridViewTextBoxColumn.DataPropertyName = "House";
            this.houseDataGridViewTextBoxColumn.HeaderText = "House";
            this.houseDataGridViewTextBoxColumn.Name = "houseDataGridViewTextBoxColumn";
            // 
            // flatDataGridViewTextBoxColumn
            // 
            this.flatDataGridViewTextBoxColumn.DataPropertyName = "Flat";
            this.flatDataGridViewTextBoxColumn.HeaderText = "Flat";
            this.flatDataGridViewTextBoxColumn.Name = "flatDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPhoneDataGridViewTextBoxColumn,
            this.registrationnumberDataGridViewTextBoxColumn,
            this.priceInDayDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.phonesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(658, 339);
            this.dataGridView2.TabIndex = 0;
            // 
            // phonesBindingSource
            // 
            this.phonesBindingSource.DataMember = "Phones";
            this.phonesBindingSource.DataSource = this.phoneCompanyDataSet;
            // 
            // phonesTableAdapter
            // 
            this.phonesTableAdapter.ClearBeforeFill = true;
            // 
            // idPhoneDataGridViewTextBoxColumn
            // 
            this.idPhoneDataGridViewTextBoxColumn.DataPropertyName = "Id_Phone";
            this.idPhoneDataGridViewTextBoxColumn.HeaderText = "Id_Phone";
            this.idPhoneDataGridViewTextBoxColumn.Name = "idPhoneDataGridViewTextBoxColumn";
            // 
            // registrationnumberDataGridViewTextBoxColumn
            // 
            this.registrationnumberDataGridViewTextBoxColumn.DataPropertyName = "Registration_number";
            this.registrationnumberDataGridViewTextBoxColumn.HeaderText = "Registration_number";
            this.registrationnumberDataGridViewTextBoxColumn.Name = "registrationnumberDataGridViewTextBoxColumn";
            // 
            // priceInDayDataGridViewTextBoxColumn
            // 
            this.priceInDayDataGridViewTextBoxColumn.DataPropertyName = "Price in day";
            this.priceInDayDataGridViewTextBoxColumn.HeaderText = "Price in day";
            this.priceInDayDataGridViewTextBoxColumn.Name = "priceInDayDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPaymentDataGridViewTextBoxColumn,
            this.idAbonentDataGridViewTextBoxColumn1,
            this.idPhoneDataGridViewTextBoxColumn1,
            this.datepaymentDataGridViewTextBoxColumn,
            this.pricepaymentDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.paymentBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(4, 7);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(660, 338);
            this.dataGridView3.TabIndex = 0;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.phoneCompanyDataSet;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // idPaymentDataGridViewTextBoxColumn
            // 
            this.idPaymentDataGridViewTextBoxColumn.DataPropertyName = "Id_Payment";
            this.idPaymentDataGridViewTextBoxColumn.HeaderText = "Id_Payment";
            this.idPaymentDataGridViewTextBoxColumn.Name = "idPaymentDataGridViewTextBoxColumn";
            // 
            // idAbonentDataGridViewTextBoxColumn1
            // 
            this.idAbonentDataGridViewTextBoxColumn1.DataPropertyName = "Id_Abonent";
            this.idAbonentDataGridViewTextBoxColumn1.HeaderText = "Id_Abonent";
            this.idAbonentDataGridViewTextBoxColumn1.Name = "idAbonentDataGridViewTextBoxColumn1";
            // 
            // idPhoneDataGridViewTextBoxColumn1
            // 
            this.idPhoneDataGridViewTextBoxColumn1.DataPropertyName = "Id_Phone";
            this.idPhoneDataGridViewTextBoxColumn1.HeaderText = "Id_Phone";
            this.idPhoneDataGridViewTextBoxColumn1.Name = "idPhoneDataGridViewTextBoxColumn1";
            // 
            // datepaymentDataGridViewTextBoxColumn
            // 
            this.datepaymentDataGridViewTextBoxColumn.DataPropertyName = "Date_payment";
            this.datepaymentDataGridViewTextBoxColumn.HeaderText = "Date_payment";
            this.datepaymentDataGridViewTextBoxColumn.Name = "datepaymentDataGridViewTextBoxColumn";
            // 
            // pricepaymentDataGridViewTextBoxColumn
            // 
            this.pricepaymentDataGridViewTextBoxColumn.DataPropertyName = "Price_payment";
            this.pricepaymentDataGridViewTextBoxColumn.HeaderText = "Price_payment";
            this.pricepaymentDataGridViewTextBoxColumn.Name = "pricepaymentDataGridViewTextBoxColumn";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUserDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.adminDataGridViewTextBoxColumn,
            this.bannedDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.userBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(7, 7);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(657, 338);
            this.dataGridView4.TabIndex = 0;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.phoneCompanyDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
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
            // bannedDataGridViewTextBoxColumn
            // 
            this.bannedDataGridViewTextBoxColumn.DataPropertyName = "Banned";
            this.bannedDataGridViewTextBoxColumn.HeaderText = "Banned";
            this.bannedDataGridViewTextBoxColumn.Name = "bannedDataGridViewTextBoxColumn";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(13, 397);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(106, 41);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "<-------";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(697, 72);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(91, 41);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // RequestsButton
            // 
            this.RequestsButton.Location = new System.Drawing.Point(697, 119);
            this.RequestsButton.Name = "RequestsButton";
            this.RequestsButton.Size = new System.Drawing.Size(91, 41);
            this.RequestsButton.TabIndex = 6;
            this.RequestsButton.Text = "Запросы";
            this.RequestsButton.UseVisualStyleBackColor = true;
            this.RequestsButton.Click += new System.EventHandler(this.RequestsButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RequestsButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private PhoneCompanyDataSet phoneCompanyDataSet;
        private System.Windows.Forms.BindingSource abonentsBindingSource;
        private PhoneCompanyDataSetTableAdapters.AbonentsTableAdapter abonentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAbonentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameabonentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource phonesBindingSource;
        private PhoneCompanyDataSetTableAdapters.PhonesTableAdapter phonesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceInDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private PhoneCompanyDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAbonentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPhoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datepaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricepaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource userBindingSource;
        private PhoneCompanyDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bannedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button RequestsButton;
    }
}