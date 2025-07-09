namespace ToDoListForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userNameBox = new TextBox();
            passwordBox = new TextBox();
            userNameLabel = new Label();
            passwordLabel = new Label();
            loginButton = new Button();
            orLabel = new Label();
            lastNameBox = new TextBox();
            firstNameBox = new TextBox();
            passwordRegBox = new TextBox();
            userNameRegBox = new TextBox();
            loginLabel = new Label();
            regPasswordLabel = new Label();
            userRegLabel = new Label();
            registrationLabel = new Label();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            regButton = new Button();
            SuspendLayout();
            // 
            // userNameBox
            // 
            userNameBox.Location = new Point(29, 135);
            userNameBox.Name = "userNameBox";
            userNameBox.Size = new Size(132, 23);
            userNameBox.TabIndex = 1;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(29, 187);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(132, 23);
            passwordBox.TabIndex = 2;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameLabel.Location = new Point(59, 111);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(81, 21);
            userNameLabel.TabIndex = 3;
            userNameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(59, 163);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(76, 21);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            // 
            // loginButton
            // 
            loginButton.BackColor = SystemColors.Highlight;
            loginButton.ForeColor = SystemColors.ButtonHighlight;
            loginButton.Location = new Point(59, 228);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(76, 26);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orLabel.Location = new Point(248, 163);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(46, 32);
            orLabel.TabIndex = 6;
            orLabel.Text = "OR";
            // 
            // lastNameBox
            // 
            lastNameBox.Location = new Point(366, 161);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(132, 23);
            lastNameBox.TabIndex = 8;
            // 
            // firstNameBox
            // 
            firstNameBox.Location = new Point(366, 115);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(132, 23);
            firstNameBox.TabIndex = 7;
            // 
            // passwordRegBox
            // 
            passwordRegBox.Location = new Point(366, 261);
            passwordRegBox.Name = "passwordRegBox";
            passwordRegBox.Size = new Size(132, 23);
            passwordRegBox.TabIndex = 10;
            // 
            // userNameRegBox
            // 
            userNameRegBox.Location = new Point(366, 211);
            userNameRegBox.Name = "userNameRegBox";
            userNameRegBox.Size = new Size(132, 23);
            userNameRegBox.TabIndex = 9;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginLabel.Location = new Point(53, 42);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(82, 32);
            loginLabel.TabIndex = 11;
            loginLabel.Text = "LOGIN";
            // 
            // regPasswordLabel
            // 
            regPasswordLabel.AutoSize = true;
            regPasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            regPasswordLabel.Location = new Point(366, 237);
            regPasswordLabel.Name = "regPasswordLabel";
            regPasswordLabel.Size = new Size(76, 21);
            regPasswordLabel.TabIndex = 13;
            regPasswordLabel.Text = "Password";
            // 
            // userRegLabel
            // 
            userRegLabel.AutoSize = true;
            userRegLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userRegLabel.Location = new Point(366, 187);
            userRegLabel.Name = "userRegLabel";
            userRegLabel.Size = new Size(81, 21);
            userRegLabel.TabIndex = 12;
            userRegLabel.Text = "Username";
            // 
            // registrationLabel
            // 
            registrationLabel.AutoSize = true;
            registrationLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registrationLabel.Location = new Point(368, 42);
            registrationLabel.Name = "registrationLabel";
            registrationLabel.Size = new Size(114, 32);
            registrationLabel.TabIndex = 14;
            registrationLabel.Text = "REGISTER";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLabel.Location = new Point(368, 141);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(84, 21);
            lastNameLabel.TabIndex = 15;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameLabel.Location = new Point(366, 91);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(86, 21);
            firstNameLabel.TabIndex = 16;
            firstNameLabel.Text = "First Name";
            // 
            // regButton
            // 
            regButton.BackColor = SystemColors.Highlight;
            regButton.ForeColor = SystemColors.ButtonHighlight;
            regButton.Location = new Point(390, 300);
            regButton.Name = "regButton";
            regButton.Size = new Size(76, 26);
            regButton.TabIndex = 17;
            regButton.Text = "Register";
            regButton.UseVisualStyleBackColor = false;
            regButton.Click += regButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(559, 348);
            Controls.Add(regButton);
            Controls.Add(firstNameLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(registrationLabel);
            Controls.Add(regPasswordLabel);
            Controls.Add(userRegLabel);
            Controls.Add(loginLabel);
            Controls.Add(passwordRegBox);
            Controls.Add(userNameRegBox);
            Controls.Add(lastNameBox);
            Controls.Add(firstNameBox);
            Controls.Add(orLabel);
            Controls.Add(loginButton);
            Controls.Add(passwordLabel);
            Controls.Add(userNameLabel);
            Controls.Add(passwordBox);
            Controls.Add(userNameBox);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox userNameBox;
        private TextBox passwordBox;
        private Label userNameLabel;
        private Label passwordLabel;
        private Button loginButton;
        private Label orLabel;
        private TextBox lastNameBox;
        private TextBox firstNameBox;
        private TextBox passwordRegBox;
        private TextBox userNameRegBox;
        private Label loginLabel;
        private Label regPasswordLabel;
        private Label userRegLabel;
        private Label registrationLabel;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private Button regButton;
    }
}
