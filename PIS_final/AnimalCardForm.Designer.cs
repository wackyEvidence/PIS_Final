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
            regCardNumberValueLabel = new Label();
            regCardNumberTextBox = new TextBox();
            animalPictureBox = new PictureBox();
            locationValueLabel = new Label();
            locationComboBox = new ComboBox();
            animalCategoryComboBox = new ComboBox();
            animalCategoryValueLabel = new Label();
            animalSexComboBox = new ComboBox();
            animalSexValueLabel = new Label();
            animalBirthYearValueLabel = new Label();
            animalBirthYearTextBox = new TextBox();
            animalChipNumberValueLabel = new Label();
            animalChipNumberTextBox = new TextBox();
            animalNicknameValueLabel = new Label();
            animalNicknameTextBox = new TextBox();
            distinguishingMarksValueLabel = new Label();
            distinguishingMarksRichTextBox = new RichTextBox();
            ownerSignsValueLabel = new Label();
            ownerSignsCheckedListBox = new CheckedListBox();
            editAnimalCardButton = new Button();
            applyChangesOrAddAnimalButton = new Button();
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
            // regCardNumberValueLabel
            // 
            regCardNumberValueLabel.AutoSize = true;
            regCardNumberValueLabel.ForeColor = Color.FromArgb(53, 153, 255);
            regCardNumberValueLabel.Location = new Point(5, 96);
            regCardNumberValueLabel.Name = "regCardNumberValueLabel";
            regCardNumberValueLabel.Size = new Size(343, 38);
            regCardNumberValueLabel.TabIndex = 5;
            regCardNumberValueLabel.Text = "Регистрационный номер:";
            // 
            // regCardNumberTextBox
            // 
            regCardNumberTextBox.Location = new Point(349, 93);
            regCardNumberTextBox.Name = "regCardNumberTextBox";
            regCardNumberTextBox.Size = new Size(150, 43);
            regCardNumberTextBox.TabIndex = 6;
            // 
            // animalPictureBox
            // 
            animalPictureBox.BackColor = Color.Gainsboro;
            animalPictureBox.Location = new Point(548, 91);
            animalPictureBox.Name = "animalPictureBox";
            animalPictureBox.Size = new Size(281, 361);
            animalPictureBox.TabIndex = 7;
            animalPictureBox.TabStop = false;
            // 
            // locationValueLabel
            // 
            locationValueLabel.AutoSize = true;
            locationValueLabel.ForeColor = Color.FromArgb(53, 153, 255);
            locationValueLabel.Location = new Point(6, 148);
            locationValueLabel.Name = "locationValueLabel";
            locationValueLabel.Size = new Size(278, 38);
            locationValueLabel.TabIndex = 8;
            locationValueLabel.Text = "Населенный пункт:  ";
            // 
            // locationComboBox
            // 
            locationComboBox.FormattingEnabled = true;
            locationComboBox.Items.AddRange(new object[] { "Тюмень", "Санкт-Петербург" });
            locationComboBox.Location = new Point(266, 141);
            locationComboBox.Name = "locationComboBox";
            locationComboBox.Size = new Size(233, 45);
            locationComboBox.TabIndex = 13;
            // 
            // animalCategoryComboBox
            // 
            animalCategoryComboBox.FormattingEnabled = true;
            animalCategoryComboBox.Items.AddRange(new object[] { "Кот", "Собака" });
            animalCategoryComboBox.Location = new Point(298, 196);
            animalCategoryComboBox.Name = "animalCategoryComboBox";
            animalCategoryComboBox.Size = new Size(201, 45);
            animalCategoryComboBox.TabIndex = 15;
            // 
            // animalCategoryValueLabel
            // 
            animalCategoryValueLabel.AutoSize = true;
            animalCategoryValueLabel.ForeColor = Color.FromArgb(53, 153, 255);
            animalCategoryValueLabel.Location = new Point(6, 203);
            animalCategoryValueLabel.Name = "animalCategoryValueLabel";
            animalCategoryValueLabel.Size = new Size(314, 38);
            animalCategoryValueLabel.TabIndex = 14;
            animalCategoryValueLabel.Text = "Категория животного:  ";
            // 
            // animalSexComboBox
            // 
            animalSexComboBox.FormattingEnabled = true;
            animalSexComboBox.Items.AddRange(new object[] { "Мужской", "Женский" });
            animalSexComboBox.Location = new Point(227, 255);
            animalSexComboBox.Name = "animalSexComboBox";
            animalSexComboBox.Size = new Size(158, 45);
            animalSexComboBox.TabIndex = 17;
            // 
            // animalSexValueLabel
            // 
            animalSexValueLabel.AutoSize = true;
            animalSexValueLabel.ForeColor = Color.FromArgb(53, 153, 255);
            animalSexValueLabel.Location = new Point(6, 258);
            animalSexValueLabel.Name = "animalSexValueLabel";
            animalSexValueLabel.Size = new Size(236, 38);
            animalSexValueLabel.TabIndex = 16;
            animalSexValueLabel.Text = "Пол животного:  ";
            // 
            // animalBirthYearValueLabel
            // 
            animalBirthYearValueLabel.AutoSize = true;
            animalBirthYearValueLabel.ForeColor = Color.FromArgb(53, 153, 255);
            animalBirthYearValueLabel.Location = new Point(6, 313);
            animalBirthYearValueLabel.Name = "animalBirthYearValueLabel";
            animalBirthYearValueLabel.Size = new Size(204, 38);
            animalBirthYearValueLabel.TabIndex = 18;
            animalBirthYearValueLabel.Text = "Год рождения:";
            // 
            // animalBirthYearTextBox
            // 
            animalBirthYearTextBox.Location = new Point(216, 310);
            animalBirthYearTextBox.Name = "animalBirthYearTextBox";
            animalBirthYearTextBox.Size = new Size(103, 43);
            animalBirthYearTextBox.TabIndex = 19;
            // 
            // animalChipNumberValueLabel
            // 
            animalChipNumberValueLabel.AutoSize = true;
            animalChipNumberValueLabel.ForeColor = Color.FromArgb(53, 153, 255);
            animalChipNumberValueLabel.Location = new Point(6, 364);
            animalChipNumberValueLabel.Name = "animalChipNumberValueLabel";
            animalChipNumberValueLabel.Size = new Size(363, 38);
            animalChipNumberValueLabel.TabIndex = 20;
            animalChipNumberValueLabel.Text = "Номер электронного чипа:";
            // 
            // animalChipNumberTextBox
            // 
            animalChipNumberTextBox.Location = new Point(375, 361);
            animalChipNumberTextBox.Name = "animalChipNumberTextBox";
            animalChipNumberTextBox.Size = new Size(136, 43);
            animalChipNumberTextBox.TabIndex = 21;
            // 
            // animalNicknameValueLabel
            // 
            animalNicknameValueLabel.AutoSize = true;
            animalNicknameValueLabel.ForeColor = Color.FromArgb(53, 153, 255);
            animalNicknameValueLabel.Location = new Point(6, 414);
            animalNicknameValueLabel.Name = "animalNicknameValueLabel";
            animalNicknameValueLabel.Size = new Size(260, 38);
            animalNicknameValueLabel.TabIndex = 22;
            animalNicknameValueLabel.Text = "Кличка животного:";
            // 
            // animalNicknameTextBox
            // 
            animalNicknameTextBox.Location = new Point(272, 409);
            animalNicknameTextBox.Name = "animalNicknameTextBox";
            animalNicknameTextBox.Size = new Size(233, 43);
            animalNicknameTextBox.TabIndex = 23;
            // 
            // distinguishingMarksValueLabel
            // 
            distinguishingMarksValueLabel.AutoSize = true;
            distinguishingMarksValueLabel.ForeColor = Color.FromArgb(53, 153, 255);
            distinguishingMarksValueLabel.Location = new Point(8, 467);
            distinguishingMarksValueLabel.Name = "distinguishingMarksValueLabel";
            distinguishingMarksValueLabel.Size = new Size(262, 38);
            distinguishingMarksValueLabel.TabIndex = 24;
            distinguishingMarksValueLabel.Text = "Особые приметы:  ";
            // 
            // distinguishingMarksRichTextBox
            // 
            distinguishingMarksRichTextBox.Location = new Point(17, 508);
            distinguishingMarksRichTextBox.Name = "distinguishingMarksRichTextBox";
            distinguishingMarksRichTextBox.Size = new Size(294, 156);
            distinguishingMarksRichTextBox.TabIndex = 26;
            distinguishingMarksRichTextBox.Text = "";
            // 
            // ownerSignsValueLabel
            // 
            ownerSignsValueLabel.AutoSize = true;
            ownerSignsValueLabel.ForeColor = Color.FromArgb(53, 153, 255);
            ownerSignsValueLabel.Location = new Point(349, 467);
            ownerSignsValueLabel.Name = "ownerSignsValueLabel";
            ownerSignsValueLabel.Size = new Size(289, 38);
            ownerSignsValueLabel.TabIndex = 27;
            ownerSignsValueLabel.Text = "Призаки владельца:  ";
            // 
            // ownerSignsCheckedListBox
            // 
            ownerSignsCheckedListBox.ForeColor = SystemColors.MenuHighlight;
            ownerSignsCheckedListBox.FormattingEnabled = true;
            ownerSignsCheckedListBox.Items.AddRange(new object[] { "Ошейник", "Шлейка", "Одежда", "Чип" });
            ownerSignsCheckedListBox.Location = new Point(349, 508);
            ownerSignsCheckedListBox.Name = "ownerSignsCheckedListBox";
            ownerSignsCheckedListBox.Size = new Size(306, 156);
            ownerSignsCheckedListBox.TabIndex = 29;
            // 
            // editAnimalCardButton
            // 
            editAnimalCardButton.ForeColor = Color.FromArgb(53, 153, 255);
            editAnimalCardButton.Location = new Point(17, 696);
            editAnimalCardButton.Name = "editAnimalCardButton";
            editAnimalCardButton.Size = new Size(172, 100);
            editAnimalCardButton.TabIndex = 30;
            editAnimalCardButton.Text = "Изменить карточку";
            editAnimalCardButton.UseVisualStyleBackColor = true;
            editAnimalCardButton.Click += editAnimalCardButton_Click;
            // 
            // applyChangesOrAddAnimalButton
            // 
            applyChangesOrAddAnimalButton.ForeColor = Color.FromArgb(53, 153, 255);
            applyChangesOrAddAnimalButton.Location = new Point(609, 693);
            applyChangesOrAddAnimalButton.Name = "applyChangesOrAddAnimalButton";
            applyChangesOrAddAnimalButton.Size = new Size(226, 100);
            applyChangesOrAddAnimalButton.TabIndex = 31;
            applyChangesOrAddAnimalButton.Text = "Сохранить изменения";
            applyChangesOrAddAnimalButton.UseVisualStyleBackColor = true;
            applyChangesOrAddAnimalButton.Click += applyChangesOrAddAnimalButton_Click;
            // 
            // AnimalCardForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(855, 808);
            Controls.Add(applyChangesOrAddAnimalButton);
            Controls.Add(editAnimalCardButton);
            Controls.Add(ownerSignsCheckedListBox);
            Controls.Add(ownerSignsValueLabel);
            Controls.Add(distinguishingMarksRichTextBox);
            Controls.Add(distinguishingMarksValueLabel);
            Controls.Add(animalNicknameValueLabel);
            Controls.Add(animalNicknameTextBox);
            Controls.Add(animalChipNumberValueLabel);
            Controls.Add(animalChipNumberTextBox);
            Controls.Add(animalBirthYearValueLabel);
            Controls.Add(animalBirthYearTextBox);
            Controls.Add(animalSexComboBox);
            Controls.Add(animalSexValueLabel);
            Controls.Add(animalCategoryComboBox);
            Controls.Add(animalCategoryValueLabel);
            Controls.Add(locationComboBox);
            Controls.Add(locationValueLabel);
            Controls.Add(animalPictureBox);
            Controls.Add(regCardNumberValueLabel);
            Controls.Add(regCardNumberTextBox);
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
        private Label regCardNumberValueLabel;
        private TextBox regCardNumberTextBox;
        private PictureBox animalPictureBox;
        private Label locationValueLabel;
        private ComboBox locationComboBox;
        private ComboBox animalCategoryComboBox;
        private Label animalCategoryValueLabel;
        private ComboBox animalSexComboBox;
        private Label animalSexValueLabel;
        private Label animalBirthYearValueLabel;
        private TextBox animalBirthYearTextBox;
        private Label animalChipNumberValueLabel;
        private TextBox animalChipNumberTextBox;
        private Label animalNicknameValueLabel;
        private TextBox animalNicknameTextBox;
        private Label distinguishingMarksValueLabel;
        private RichTextBox distinguishingMarksRichTextBox;
        private Label ownerSignsValueLabel;
        private CheckedListBox ownerSignsCheckedListBox;
        private Button editAnimalCardButton;
        private Button applyChangesOrAddAnimalButton;
    }
}