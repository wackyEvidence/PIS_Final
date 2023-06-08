namespace PIS_final
{
    partial class AuthorizationForm
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
            headerLabel = new Label();
            loginLabel = new Label();
            passwordLabel = new Label();
            authorizeButton = new Button();
            loginTextBox = new TextBox();
            passwordTextBox = new TextBox();
            authorizationGroupBox = new GroupBox();
            authorizationGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.FromArgb(53, 153, 255);
            headerLabel.Location = new Point(15, 9);
            headerLabel.Margin = new Padding(6, 0, 6, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(330, 62);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Вход в систему";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.ForeColor = Color.FromArgb(53, 153, 255);
            loginLabel.Location = new Point(32, 23);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(101, 38);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "Логин:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = Color.FromArgb(53, 153, 255);
            passwordLabel.Location = new Point(32, 121);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(118, 38);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Пароль:";
            // 
            // authorizeButton
            // 
            authorizeButton.ForeColor = Color.FromArgb(53, 153, 255);
            authorizeButton.Location = new Point(32, 226);
            authorizeButton.Name = "authorizeButton";
            authorizeButton.Size = new Size(118, 52);
            authorizeButton.TabIndex = 3;
            authorizeButton.Text = "ОК";
            authorizeButton.UseVisualStyleBackColor = true;
            authorizeButton.Click += authorizeButton_Click;
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(32, 64);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(282, 43);
            loginTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(32, 162);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(282, 43);
            passwordTextBox.TabIndex = 5;
            // 
            // authorizationGroupBox
            // 
            authorizationGroupBox.BackColor = Color.White;
            authorizationGroupBox.Controls.Add(authorizeButton);
            authorizationGroupBox.Controls.Add(passwordTextBox);
            authorizationGroupBox.Controls.Add(loginLabel);
            authorizationGroupBox.Controls.Add(loginTextBox);
            authorizationGroupBox.Controls.Add(passwordLabel);
            authorizationGroupBox.Location = new Point(80, 96);
            authorizationGroupBox.Name = "authorizationGroupBox";
            authorizationGroupBox.Size = new Size(361, 302);
            authorizationGroupBox.TabIndex = 6;
            authorizationGroupBox.TabStop = false;
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(528, 446);
            Controls.Add(authorizationGroupBox);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 7, 6, 7);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AuthorizationForm";
            Text = "Авторизация пользователя";
            authorizationGroupBox.ResumeLayout(false);
            authorizationGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label loginLabel;
        private Label passwordLabel;
        private Button authorizeButton;
        private TextBox loginTextBox;
        private TextBox passwordTextBox;
        private GroupBox authorizationGroupBox;
    }
}