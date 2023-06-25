namespace Stock
{
    partial class AuthenticationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        public string Username => usernameTextBox.Text;
        public string Password => passwordTextBox.Text;

        private void InitializeComponent()
        {
            loginButton = new Button();
            cancelButton = new Button();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.BackColor = SystemColors.GradientActiveCaption;
            loginButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = SystemColors.ControlText;
            loginButton.ImageAlign = ContentAlignment.BottomLeft;
            loginButton.Location = new Point(58, 173);
            loginButton.Margin = new Padding(4, 3, 4, 3);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(117, 35);
            loginButton.TabIndex = 2;
            loginButton.Text = "Увійти";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.Location = new Point(175, 173);
            cancelButton.Margin = new Padding(4, 3, 4, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(117, 35);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Скасувати";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.ForeColor = SystemColors.Desktop;
            usernameTextBox.Location = new Point(58, 63);
            usernameTextBox.Margin = new Padding(4, 3, 4, 3);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(233, 29);
            usernameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.ForeColor = SystemColors.Desktop;
            passwordTextBox.Location = new Point(58, 115);
            passwordTextBox.Margin = new Padding(4, 3, 4, 3);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(233, 29);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveCaption;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(49, 20);
            label1.Name = "label1";
            label1.Size = new Size(252, 27);
            label1.TabIndex = 4;
            label1.Text = "Введіть логін та пароль";
            // 
            // AuthenticationForm
            // 
            AcceptButton = loginButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 231);
            Controls.Add(label1);
            Controls.Add(cancelButton);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AuthenticationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Аутентифікація";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private Button cancelButton;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label label1;
    }
}