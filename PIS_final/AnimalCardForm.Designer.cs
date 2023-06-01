namespace UI
{
    partial class AnimalCardForm
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
            animalNicknameLabel = new Label();
            loginLabel = new Label();
            loginTextBox = new TextBox();
            animalPictureBox = new PictureBox();
            label1 = new Label();
            sortAttributeComboBox = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            richTextBox1 = new RichTextBox();
            label8 = new Label();
            checkedListBox1 = new CheckedListBox();
            authorizeButton = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)animalPictureBox).BeginInit();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.FromArgb(53, 153, 255);
            headerLabel.Location = new Point(5, 9);
            headerLabel.Margin = new Padding(6, 0, 6, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(461, 62);
            headerLabel.TabIndex = 3;
            headerLabel.Text = "Карточка животного: ";
            // 
            // animalNicknameLabel
            // 
            animalNicknameLabel.AutoSize = true;
            animalNicknameLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            animalNicknameLabel.ForeColor = Color.FromArgb(53, 153, 255);
            animalNicknameLabel.Location = new Point(438, 9);
            animalNicknameLabel.Margin = new Padding(6, 0, 6, 0);
            animalNicknameLabel.Name = "animalNicknameLabel";
            animalNicknameLabel.Size = new Size(189, 62);
            animalNicknameLabel.TabIndex = 4;
            animalNicknameLabel.Text = "<none>";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.ForeColor = Color.FromArgb(53, 153, 255);
            loginLabel.Location = new Point(5, 96);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(359, 38);
            loginLabel.TabIndex = 5;
            loginLabel.Text = "Регистрационный номер:  ";
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(349, 91);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(150, 43);
            loginTextBox.TabIndex = 6;
            // 
            // animalPictureBox
            // 
            animalPictureBox.BackColor = Color.Gainsboro;
            animalPictureBox.Location = new Point(554, 91);
            animalPictureBox.Name = "animalPictureBox";
            animalPictureBox.Size = new Size(281, 361);
            animalPictureBox.TabIndex = 7;
            animalPictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(53, 153, 255);
            label1.Location = new Point(6, 148);
            label1.Name = "label1";
            label1.Size = new Size(278, 38);
            label1.TabIndex = 8;
            label1.Text = "Населенный пункт:  ";
            // 
            // sortAttributeComboBox
            // 
            sortAttributeComboBox.FormattingEnabled = true;
            sortAttributeComboBox.Location = new Point(266, 141);
            sortAttributeComboBox.Name = "sortAttributeComboBox";
            sortAttributeComboBox.Size = new Size(233, 45);
            sortAttributeComboBox.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(298, 196);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(201, 45);
            comboBox1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(53, 153, 255);
            label2.Location = new Point(6, 203);
            label2.Name = "label2";
            label2.Size = new Size(314, 38);
            label2.TabIndex = 14;
            label2.Text = "Категория животного:  ";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(227, 255);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(57, 45);
            comboBox2.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(53, 153, 255);
            label3.Location = new Point(6, 258);
            label3.Name = "label3";
            label3.Size = new Size(236, 38);
            label3.TabIndex = 16;
            label3.Text = "Пол животного:  ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(53, 153, 255);
            label4.Location = new Point(6, 313);
            label4.Name = "label4";
            label4.Size = new Size(220, 38);
            label4.TabIndex = 18;
            label4.Text = "Год рождения:  ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(217, 308);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(103, 43);
            textBox1.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(53, 153, 255);
            label5.Location = new Point(6, 364);
            label5.Name = "label5";
            label5.Size = new Size(379, 38);
            label5.TabIndex = 20;
            label5.Text = "Номер электронного чипа:  ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(363, 359);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(136, 43);
            textBox2.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(53, 153, 255);
            label6.Location = new Point(6, 414);
            label6.Name = "label6";
            label6.Size = new Size(276, 38);
            label6.TabIndex = 22;
            label6.Text = "Кличка животного:  ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(266, 409);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(233, 43);
            textBox3.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(53, 153, 255);
            label7.Location = new Point(8, 467);
            label7.Name = "label7";
            label7.Size = new Size(262, 38);
            label7.TabIndex = 24;
            label7.Text = "Особые приметы:  ";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(17, 508);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(294, 156);
            richTextBox1.TabIndex = 26;
            richTextBox1.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(53, 153, 255);
            label8.Location = new Point(349, 467);
            label8.Name = "label8";
            label8.Size = new Size(289, 38);
            label8.TabIndex = 27;
            label8.Text = "Призаки владельца:  ";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Ошейник", "Шлейка", "Одежда", "Чип" });
            checkedListBox1.Location = new Point(349, 508);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(306, 156);
            checkedListBox1.TabIndex = 29;
            // 
            // authorizeButton
            // 
            authorizeButton.ForeColor = Color.FromArgb(53, 153, 255);
            authorizeButton.Location = new Point(17, 696);
            authorizeButton.Name = "authorizeButton";
            authorizeButton.Size = new Size(172, 100);
            authorizeButton.TabIndex = 30;
            authorizeButton.Text = "Изменить карточку";
            authorizeButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.ForeColor = Color.FromArgb(53, 153, 255);
            button1.Location = new Point(609, 693);
            button1.Name = "button1";
            button1.Size = new Size(226, 100);
            button1.TabIndex = 31;
            button1.Text = "Сохранить изменения";
            button1.UseVisualStyleBackColor = true;
            // 
            // AnimalCardForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(855, 808);
            Controls.Add(button1);
            Controls.Add(authorizeButton);
            Controls.Add(checkedListBox1);
            Controls.Add(label8);
            Controls.Add(richTextBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(sortAttributeComboBox);
            Controls.Add(label1);
            Controls.Add(animalPictureBox);
            Controls.Add(loginLabel);
            Controls.Add(loginTextBox);
            Controls.Add(animalNicknameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "AnimalCardForm";
            Text = "Карточка животного";
            ((System.ComponentModel.ISupportInitialize)animalPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label animalNicknameLabel;
        private Label loginLabel;
        private TextBox loginTextBox;
        private PictureBox animalPictureBox;
        private Label label1;
        private ComboBox sortAttributeComboBox;
        private ComboBox comboBox1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private RichTextBox richTextBox1;
        private Label label8;
        private CheckedListBox checkedListBox1;
        private Button authorizeButton;
        private Button button1;
    }
}