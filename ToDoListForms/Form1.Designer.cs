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
            loginButton.Location = new Point(59, 228);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(76, 26);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
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

        private Label loginLabel;
        private TextBox userNameBox;
        private TextBox passwordBox;
        private Label userNameLabel;
        private Label passwordLabel;
        private Button loginButton;
    }
}
