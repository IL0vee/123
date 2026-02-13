namespace OnlineStore
{
    partial class Registration
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
            this.ButtonExitFrom = new System.Windows.Forms.Button();
            this.RollUpForm = new System.Windows.Forms.Button();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.Labellogin = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.AutorizationButton = new System.Windows.Forms.Button();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.AdminCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ButtonExitFrom
            // 
            this.ButtonExitFrom.Location = new System.Drawing.Point(713, 12);
            this.ButtonExitFrom.Name = "ButtonExitFrom";
            this.ButtonExitFrom.Size = new System.Drawing.Size(75, 23);
            this.ButtonExitFrom.TabIndex = 0;
            this.ButtonExitFrom.Text = "X";
            this.ButtonExitFrom.UseVisualStyleBackColor = true;
            this.ButtonExitFrom.Click += new System.EventHandler(this.ButtonExitFrom_Click);
            // 
            // RollUpForm
            // 
            this.RollUpForm.Location = new System.Drawing.Point(632, 11);
            this.RollUpForm.Name = "RollUpForm";
            this.RollUpForm.Size = new System.Drawing.Size(75, 23);
            this.RollUpForm.TabIndex = 1;
            this.RollUpForm.Text = "-";
            this.RollUpForm.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.RollUpForm.UseVisualStyleBackColor = true;
            this.RollUpForm.Click += new System.EventHandler(this.RollUpForm_Click);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(295, 162);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(100, 20);
            this.LoginTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(295, 212);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // Labellogin
            // 
            this.Labellogin.AutoSize = true;
            this.Labellogin.Location = new System.Drawing.Point(295, 143);
            this.Labellogin.Name = "Labellogin";
            this.Labellogin.Size = new System.Drawing.Size(41, 13);
            this.Labellogin.TabIndex = 4;
            this.Labellogin.Text = "Логин:";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(295, 193);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(48, 13);
            this.LabelPassword.TabIndex = 5;
            this.LabelPassword.Text = "Пароль:";
            // 
            // AutorizationButton
            // 
            this.AutorizationButton.Location = new System.Drawing.Point(298, 252);
            this.AutorizationButton.Name = "AutorizationButton";
            this.AutorizationButton.Size = new System.Drawing.Size(75, 23);
            this.AutorizationButton.TabIndex = 6;
            this.AutorizationButton.Text = "Авторизация";
            this.AutorizationButton.UseVisualStyleBackColor = true;
            this.AutorizationButton.Click += new System.EventHandler(this.AutorizationButton_Click);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(298, 281);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(75, 23);
            this.RegistrationButton.TabIndex = 7;
            this.RegistrationButton.Text = "Регистрация";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // AdminCheckBox
            // 
            this.AdminCheckBox.AutoSize = true;
            this.AdminCheckBox.Location = new System.Drawing.Point(298, 310);
            this.AdminCheckBox.Name = "AdminCheckBox";
            this.AdminCheckBox.Size = new System.Drawing.Size(59, 17);
            this.AdminCheckBox.TabIndex = 8;
            this.AdminCheckBox.Text = "Админ";
            this.AdminCheckBox.UseVisualStyleBackColor = true;
            this.AdminCheckBox.CheckedChanged += new System.EventHandler(this.AdminCheckBox_CheckedChanged);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdminCheckBox);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.AutorizationButton);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.Labellogin);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.RollUpForm);
            this.Controls.Add(this.ButtonExitFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonExitFrom;
        private System.Windows.Forms.Button RollUpForm;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label Labellogin;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Button AutorizationButton;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.CheckBox AdminCheckBox;
    }
}