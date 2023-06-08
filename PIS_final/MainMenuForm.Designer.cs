namespace UI
{
    partial class MainMenuForm
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
            headerLabel = new Label();
            openAnimalsRegistryButton = new Button();
            welcomeLabel = new Label();
            mainMenuGroupBox = new GroupBox();
            changeUserButton = new Button();
            exitButton = new Button();
            getReportButton = new Button();
            openContractsRegistryButton = new Button();
            openOrganizationsRegistryButton = new Button();
            userNameLabel = new Label();
            mainMenuGroupBox.SuspendLayout();
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
            headerLabel.Size = new Size(323, 62);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Главное меню";
            // 
            // openAnimalsRegistryButton
            // 
            openAnimalsRegistryButton.FlatAppearance.BorderColor = Color.Silver;
            openAnimalsRegistryButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            openAnimalsRegistryButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            openAnimalsRegistryButton.FlatStyle = FlatStyle.Flat;
            openAnimalsRegistryButton.Location = new Point(6, 26);
            openAnimalsRegistryButton.Name = "openAnimalsRegistryButton";
            openAnimalsRegistryButton.Size = new Size(295, 88);
            openAnimalsRegistryButton.TabIndex = 4;
            openAnimalsRegistryButton.Text = "Открыть реестр животных";
            openAnimalsRegistryButton.UseVisualStyleBackColor = true;
            openAnimalsRegistryButton.Click += openAnimalsRegistryButton_Click;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            welcomeLabel.Location = new Point(15, 104);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(335, 46);
            welcomeLabel.TabIndex = 3;
            welcomeLabel.Text = "Добро пожаловать, ";
            // 
            // mainMenuGroupBox
            // 
            mainMenuGroupBox.Controls.Add(changeUserButton);
            mainMenuGroupBox.Controls.Add(exitButton);
            mainMenuGroupBox.Controls.Add(getReportButton);
            mainMenuGroupBox.Controls.Add(openContractsRegistryButton);
            mainMenuGroupBox.Controls.Add(openOrganizationsRegistryButton);
            mainMenuGroupBox.Controls.Add(openAnimalsRegistryButton);
            mainMenuGroupBox.Location = new Point(126, 164);
            mainMenuGroupBox.Name = "mainMenuGroupBox";
            mainMenuGroupBox.Size = new Size(309, 624);
            mainMenuGroupBox.TabIndex = 2;
            mainMenuGroupBox.TabStop = false;
            // 
            // changeUserButton
            // 
            changeUserButton.FlatAppearance.BorderColor = Color.Silver;
            changeUserButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            changeUserButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            changeUserButton.FlatStyle = FlatStyle.Flat;
            changeUserButton.Location = new Point(6, 426);
            changeUserButton.Name = "changeUserButton";
            changeUserButton.Size = new Size(295, 88);
            changeUserButton.TabIndex = 9;
            changeUserButton.Text = "Сменить пользователя";
            changeUserButton.UseVisualStyleBackColor = true;
            changeUserButton.Click += changeUserButton_Click;
            // 
            // exitButton
            // 
            exitButton.FlatAppearance.BorderColor = Color.Silver;
            exitButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            exitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Location = new Point(6, 526);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(295, 88);
            exitButton.TabIndex = 8;
            exitButton.Text = "Выход";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // getReportButton
            // 
            getReportButton.FlatAppearance.BorderColor = Color.Silver;
            getReportButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            getReportButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            getReportButton.FlatStyle = FlatStyle.Flat;
            getReportButton.Location = new Point(6, 326);
            getReportButton.Name = "getReportButton";
            getReportButton.Size = new Size(295, 88);
            getReportButton.TabIndex = 7;
            getReportButton.Text = "Генерация отчета";
            getReportButton.UseVisualStyleBackColor = true;
            getReportButton.Click += getReportButton_Click;
            // 
            // openContractsRegistryButton
            // 
            openContractsRegistryButton.FlatAppearance.BorderColor = Color.Silver;
            openContractsRegistryButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            openContractsRegistryButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            openContractsRegistryButton.FlatStyle = FlatStyle.Flat;
            openContractsRegistryButton.Location = new Point(6, 226);
            openContractsRegistryButton.Name = "openContractsRegistryButton";
            openContractsRegistryButton.Size = new Size(295, 88);
            openContractsRegistryButton.TabIndex = 6;
            openContractsRegistryButton.Text = "Открыть реестр контрактов";
            openContractsRegistryButton.UseVisualStyleBackColor = true;
            openContractsRegistryButton.Click += openContractsRegistryButton_Click;
            // 
            // openOrganizationsRegistryButton
            // 
            openOrganizationsRegistryButton.FlatAppearance.BorderColor = Color.Silver;
            openOrganizationsRegistryButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            openOrganizationsRegistryButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            openOrganizationsRegistryButton.FlatStyle = FlatStyle.Flat;
            openOrganizationsRegistryButton.Location = new Point(6, 126);
            openOrganizationsRegistryButton.Name = "openOrganizationsRegistryButton";
            openOrganizationsRegistryButton.Size = new Size(295, 88);
            openOrganizationsRegistryButton.TabIndex = 5;
            openOrganizationsRegistryButton.Text = "Открыть реестр организаций";
            openOrganizationsRegistryButton.UseVisualStyleBackColor = true;
            openOrganizationsRegistryButton.Click += openOrganizationsRegistryButton_Click;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            userNameLabel.Location = new Point(331, 104);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(218, 46);
            userNameLabel.TabIndex = 4;
            userNameLabel.Text = "<userName>";
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(588, 795);
            Controls.Add(userNameLabel);
            Controls.Add(welcomeLabel);
            Controls.Add(mainMenuGroupBox);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(53, 153, 255);
            Margin = new Padding(6);
            Name = "MainMenuForm";
            Text = "Главное меню";
            FormClosed += MainMenuForm_FormClosed;
            mainMenuGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Button openAnimalsRegistryButton;
        private Label welcomeLabel;
        private GroupBox mainMenuGroupBox;
        private Button getReportButton;
        private Button openContractsRegistryButton;
        private Button openOrganizationsRegistryButton;
        private Button exitButton;
        private Label userNameLabel;
        private Button changeUserButton;
    }
}