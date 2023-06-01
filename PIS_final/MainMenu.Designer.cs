namespace UI
{
    partial class MainMenu
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
            mainMenuGroupBox = new GroupBox();
            button5 = new Button();
            button1 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            welcomeLabel = new Label();
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
            // mainMenuGroupBox
            // 
            mainMenuGroupBox.Controls.Add(button5);
            mainMenuGroupBox.Controls.Add(button1);
            mainMenuGroupBox.Controls.Add(button4);
            mainMenuGroupBox.Controls.Add(button3);
            mainMenuGroupBox.Controls.Add(button2);
            mainMenuGroupBox.Location = new Point(15, 136);
            mainMenuGroupBox.Name = "mainMenuGroupBox";
            mainMenuGroupBox.Size = new Size(301, 527);
            mainMenuGroupBox.TabIndex = 2;
            mainMenuGroupBox.TabStop = false;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.Location = new Point(3, 297);
            button5.Name = "button5";
            button5.Size = new Size(295, 85);
            button5.TabIndex = 5;
            button5.Text = "Генерация отчета";
            button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(3, 209);
            button1.Name = "button1";
            button1.Size = new Size(295, 88);
            button1.TabIndex = 4;
            button1.Text = "Открыть реестр животных";
            button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Bottom;
            button4.Location = new Point(3, 439);
            button4.Name = "button4";
            button4.Size = new Size(295, 85);
            button4.TabIndex = 3;
            button4.Text = "Выход";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.Location = new Point(3, 124);
            button3.Name = "button3";
            button3.Size = new Size(295, 85);
            button3.TabIndex = 2;
            button3.Text = "Открыть реестр контрактов";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(3, 39);
            button2.Name = "button2";
            button2.Size = new Size(295, 85);
            button2.TabIndex = 1;
            button2.Text = "Открыть реестр организаций";
            button2.UseVisualStyleBackColor = true;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            welcomeLabel.Location = new Point(21, 87);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(335, 46);
            welcomeLabel.TabIndex = 3;
            welcomeLabel.Text = "Добро пожаловать, ";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(734, 724);
            Controls.Add(welcomeLabel);
            Controls.Add(mainMenuGroupBox);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(53, 153, 255);
            Margin = new Padding(6);
            Name = "MainMenu";
            Text = "MainMenu";
            mainMenuGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private GroupBox mainMenuGroupBox;
        private Button button2;
        private Button button5;
        private Button button1;
        private Button button4;
        private Button button3;
        private Label welcomeLabel;
    }
}