namespace UI
{
    partial class AnimalsRegistryForm
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
            dataGridView1 = new DataGridView();
            filterGroupBox = new GroupBox();
            clearFilterButton = new Button();
            filterAttributeLabel = new Label();
            filterAttributeComboBox = new ComboBox();
            filterValueLabel = new Label();
            filterValueTextBox = new TextBox();
            authorizeButton = new Button();
            sortOrderLabel = new Label();
            comboBox1 = new ComboBox();
            sortAttributeLabel = new Label();
            sortAttributeComboBox = new ComboBox();
            sortGroupBox = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            filterGroupBox.SuspendLayout();
            sortGroupBox.SuspendLayout();
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
            headerLabel.Size = new Size(377, 62);
            headerLabel.TabIndex = 2;
            headerLabel.Text = "Реестр животных";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(695, 474);
            dataGridView1.TabIndex = 3;
            // 
            // filterGroupBox
            // 
            filterGroupBox.Controls.Add(clearFilterButton);
            filterGroupBox.Controls.Add(filterAttributeLabel);
            filterGroupBox.Controls.Add(filterAttributeComboBox);
            filterGroupBox.Controls.Add(filterValueLabel);
            filterGroupBox.Controls.Add(filterValueTextBox);
            filterGroupBox.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            filterGroupBox.ForeColor = Color.FromArgb(53, 153, 255);
            filterGroupBox.Location = new Point(747, 99);
            filterGroupBox.Name = "filterGroupBox";
            filterGroupBox.Size = new Size(580, 228);
            filterGroupBox.TabIndex = 4;
            filterGroupBox.TabStop = false;
            filterGroupBox.Text = "Фильтрация:";
            // 
            // clearFilterButton
            // 
            clearFilterButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            clearFilterButton.ForeColor = Color.FromArgb(53, 153, 255);
            clearFilterButton.Location = new Point(16, 161);
            clearFilterButton.Name = "clearFilterButton";
            clearFilterButton.Size = new Size(228, 51);
            clearFilterButton.TabIndex = 14;
            clearFilterButton.Text = "Убрать фильтр";
            clearFilterButton.UseVisualStyleBackColor = true;
            // 
            // filterAttributeLabel
            // 
            filterAttributeLabel.AutoSize = true;
            filterAttributeLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            filterAttributeLabel.ForeColor = Color.FromArgb(53, 153, 255);
            filterAttributeLabel.Location = new Point(16, 48);
            filterAttributeLabel.Name = "filterAttributeLabel";
            filterAttributeLabel.Size = new Size(303, 38);
            filterAttributeLabel.TabIndex = 9;
            filterAttributeLabel.Text = "Поле для фильтрации:";
            // 
            // filterAttributeComboBox
            // 
            filterAttributeComboBox.FormattingEnabled = true;
            filterAttributeComboBox.Location = new Point(325, 41);
            filterAttributeComboBox.Name = "filterAttributeComboBox";
            filterAttributeComboBox.Size = new Size(233, 45);
            filterAttributeComboBox.TabIndex = 8;
            // 
            // filterValueLabel
            // 
            filterValueLabel.AutoSize = true;
            filterValueLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            filterValueLabel.ForeColor = Color.FromArgb(53, 153, 255);
            filterValueLabel.Location = new Point(16, 100);
            filterValueLabel.Name = "filterValueLabel";
            filterValueLabel.Size = new Size(360, 38);
            filterValueLabel.TabIndex = 6;
            filterValueLabel.Text = "Значение для фильтрации:";
            // 
            // filterValueTextBox
            // 
            filterValueTextBox.Location = new Point(382, 95);
            filterValueTextBox.Name = "filterValueTextBox";
            filterValueTextBox.Size = new Size(185, 43);
            filterValueTextBox.TabIndex = 7;
            // 
            // authorizeButton
            // 
            authorizeButton.ForeColor = Color.FromArgb(53, 153, 255);
            authorizeButton.Location = new Point(15, 604);
            authorizeButton.Name = "authorizeButton";
            authorizeButton.Size = new Size(163, 86);
            authorizeButton.TabIndex = 5;
            authorizeButton.Text = "Добавить карточку";
            authorizeButton.UseVisualStyleBackColor = true;
            // 
            // sortOrderLabel
            // 
            sortOrderLabel.AutoSize = true;
            sortOrderLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            sortOrderLabel.ForeColor = Color.FromArgb(53, 153, 255);
            sortOrderLabel.Location = new Point(16, 100);
            sortOrderLabel.Name = "sortOrderLabel";
            sortOrderLabel.Size = new Size(227, 38);
            sortOrderLabel.TabIndex = 10;
            sortOrderLabel.Text = "Сортировать по ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(234, 95);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(196, 45);
            comboBox1.TabIndex = 11;
            // 
            // sortAttributeLabel
            // 
            sortAttributeLabel.AutoSize = true;
            sortAttributeLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            sortAttributeLabel.ForeColor = Color.FromArgb(53, 153, 255);
            sortAttributeLabel.Location = new Point(16, 48);
            sortAttributeLabel.Name = "sortAttributeLabel";
            sortAttributeLabel.Size = new Size(298, 38);
            sortAttributeLabel.TabIndex = 13;
            sortAttributeLabel.Text = "Поле для сортировки:";
            // 
            // sortAttributeComboBox
            // 
            sortAttributeComboBox.FormattingEnabled = true;
            sortAttributeComboBox.Location = new Point(320, 41);
            sortAttributeComboBox.Name = "sortAttributeComboBox";
            sortAttributeComboBox.Size = new Size(233, 45);
            sortAttributeComboBox.TabIndex = 12;
            // 
            // sortGroupBox
            // 
            sortGroupBox.Controls.Add(button1);
            sortGroupBox.Controls.Add(sortAttributeLabel);
            sortGroupBox.Controls.Add(sortAttributeComboBox);
            sortGroupBox.Controls.Add(sortOrderLabel);
            sortGroupBox.Controls.Add(comboBox1);
            sortGroupBox.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            sortGroupBox.ForeColor = Color.FromArgb(53, 153, 255);
            sortGroupBox.Location = new Point(747, 345);
            sortGroupBox.Name = "sortGroupBox";
            sortGroupBox.Size = new Size(580, 228);
            sortGroupBox.TabIndex = 15;
            sortGroupBox.TabStop = false;
            sortGroupBox.Text = "Сортировка:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(53, 153, 255);
            button1.Location = new Point(16, 161);
            button1.Name = "button1";
            button1.Size = new Size(270, 51);
            button1.TabIndex = 14;
            button1.Text = "Убрать сортировку";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.ForeColor = Color.FromArgb(53, 153, 255);
            button2.Location = new Point(195, 604);
            button2.Name = "button2";
            button2.Size = new Size(163, 86);
            button2.TabIndex = 16;
            button2.Text = "Открыть карточку";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.ForeColor = Color.FromArgb(53, 153, 255);
            button3.Location = new Point(555, 604);
            button3.Name = "button3";
            button3.Size = new Size(155, 86);
            button3.TabIndex = 17;
            button3.Text = "Экспорт в Excel";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.ForeColor = Color.FromArgb(53, 153, 255);
            button4.Location = new Point(375, 604);
            button4.Name = "button4";
            button4.Size = new Size(163, 86);
            button4.TabIndex = 18;
            button4.Text = "Удалить карточку";
            button4.UseVisualStyleBackColor = true;
            // 
            // AnimalsRegistryForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1368, 735);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(sortGroupBox);
            Controls.Add(authorizeButton);
            Controls.Add(filterGroupBox);
            Controls.Add(dataGridView1);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(53, 153, 255);
            Margin = new Padding(6);
            Name = "AnimalsRegistryForm";
            Text = "Реестр животных";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            filterGroupBox.ResumeLayout(false);
            filterGroupBox.PerformLayout();
            sortGroupBox.ResumeLayout(false);
            sortGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private DataGridView dataGridView1;
        private GroupBox filterGroupBox;
        private Button authorizeButton;
        private Label filterValueLabel;
        private TextBox filterValueTextBox;
        private Label filterAttributeLabel;
        private ComboBox filterAttributeComboBox;
        private ComboBox comboBox1;
        private Label sortOrderLabel;
        private Label sortAttributeLabel;
        private ComboBox sortAttributeComboBox;
        private Button clearFilterButton;
        private GroupBox sortGroupBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}