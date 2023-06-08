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
            applyFilterButton = new Button();
            clearFilterButton = new Button();
            filterAttributeLabel = new Label();
            filterAttributeComboBox = new ComboBox();
            filterValueLabel = new Label();
            filterValueTextBox = new TextBox();
            addAnimalRecordButton = new Button();
            sortOrderLabel = new Label();
            comboBox1 = new ComboBox();
            sortAttributeLabel = new Label();
            sortAttributeComboBox = new ComboBox();
            sortGroupBox = new GroupBox();
            applySortButton = new Button();
            clearSortButton = new Button();
            viewAnimalCardButton = new Button();
            exportRegistryToExcelButton = new Button();
            deleteAnimalCardButton = new Button();
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
            filterGroupBox.Controls.Add(applyFilterButton);
            filterGroupBox.Controls.Add(clearFilterButton);
            filterGroupBox.Controls.Add(filterAttributeLabel);
            filterGroupBox.Controls.Add(filterAttributeComboBox);
            filterGroupBox.Controls.Add(filterValueLabel);
            filterGroupBox.Controls.Add(filterValueTextBox);
            filterGroupBox.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            filterGroupBox.ForeColor = Color.FromArgb(53, 153, 255);
            filterGroupBox.Location = new Point(747, 99);
            filterGroupBox.Name = "filterGroupBox";
            filterGroupBox.Size = new Size(580, 282);
            filterGroupBox.TabIndex = 4;
            filterGroupBox.TabStop = false;
            filterGroupBox.Text = "Фильтрация:";
            // 
            // applyFilterButton
            // 
            applyFilterButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            applyFilterButton.ForeColor = Color.FromArgb(53, 153, 255);
            applyFilterButton.Location = new Point(16, 160);
            applyFilterButton.Name = "applyFilterButton";
            applyFilterButton.Size = new Size(270, 55);
            applyFilterButton.TabIndex = 15;
            applyFilterButton.Text = "Применить фильтр";
            applyFilterButton.UseVisualStyleBackColor = true;
            applyFilterButton.Click += applyFilterButton_Click;
            // 
            // clearFilterButton
            // 
            clearFilterButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            clearFilterButton.ForeColor = Color.FromArgb(53, 153, 255);
            clearFilterButton.Location = new Point(16, 221);
            clearFilterButton.Name = "clearFilterButton";
            clearFilterButton.Size = new Size(231, 55);
            clearFilterButton.TabIndex = 14;
            clearFilterButton.Text = "Убрать фильтр";
            clearFilterButton.UseVisualStyleBackColor = true;
            clearFilterButton.Click += clearFilterButton_Click;
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
            // addAnimalRecordButton
            // 
            addAnimalRecordButton.ForeColor = Color.FromArgb(53, 153, 255);
            addAnimalRecordButton.Location = new Point(15, 604);
            addAnimalRecordButton.Name = "addAnimalRecordButton";
            addAnimalRecordButton.Size = new Size(163, 86);
            addAnimalRecordButton.TabIndex = 5;
            addAnimalRecordButton.Text = "Добавить карточку";
            addAnimalRecordButton.UseVisualStyleBackColor = true;
            addAnimalRecordButton.Click += addAnimalRecordButton_Click;
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
            comboBox1.Location = new Point(249, 93);
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
            sortGroupBox.Controls.Add(applySortButton);
            sortGroupBox.Controls.Add(clearSortButton);
            sortGroupBox.Controls.Add(sortAttributeLabel);
            sortGroupBox.Controls.Add(sortAttributeComboBox);
            sortGroupBox.Controls.Add(sortOrderLabel);
            sortGroupBox.Controls.Add(comboBox1);
            sortGroupBox.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            sortGroupBox.ForeColor = Color.FromArgb(53, 153, 255);
            sortGroupBox.Location = new Point(747, 402);
            sortGroupBox.Name = "sortGroupBox";
            sortGroupBox.Size = new Size(580, 288);
            sortGroupBox.TabIndex = 15;
            sortGroupBox.TabStop = false;
            sortGroupBox.Text = "Сортировка:";
            // 
            // applySortButton
            // 
            applySortButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            applySortButton.ForeColor = Color.FromArgb(53, 153, 255);
            applySortButton.Location = new Point(16, 166);
            applySortButton.Name = "applySortButton";
            applySortButton.Size = new Size(324, 55);
            applySortButton.TabIndex = 15;
            applySortButton.Text = "Применить сортировку";
            applySortButton.UseVisualStyleBackColor = true;
            applySortButton.Click += applySortButton_Click;
            // 
            // clearSortButton
            // 
            clearSortButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            clearSortButton.ForeColor = Color.FromArgb(53, 153, 255);
            clearSortButton.Location = new Point(16, 227);
            clearSortButton.Name = "clearSortButton";
            clearSortButton.Size = new Size(285, 55);
            clearSortButton.TabIndex = 14;
            clearSortButton.Text = "Убрать сортировку";
            clearSortButton.UseVisualStyleBackColor = true;
            clearSortButton.Click += clearSortButton_Click;
            // 
            // viewAnimalCardButton
            // 
            viewAnimalCardButton.ForeColor = Color.FromArgb(53, 153, 255);
            viewAnimalCardButton.Location = new Point(195, 604);
            viewAnimalCardButton.Name = "viewAnimalCardButton";
            viewAnimalCardButton.Size = new Size(163, 86);
            viewAnimalCardButton.TabIndex = 16;
            viewAnimalCardButton.Text = "Открыть карточку";
            viewAnimalCardButton.UseVisualStyleBackColor = true;
            viewAnimalCardButton.Click += viewAnimalCardButton_Click;
            // 
            // exportRegistryToExcelButton
            // 
            exportRegistryToExcelButton.ForeColor = Color.FromArgb(53, 153, 255);
            exportRegistryToExcelButton.Location = new Point(555, 604);
            exportRegistryToExcelButton.Name = "exportRegistryToExcelButton";
            exportRegistryToExcelButton.Size = new Size(155, 86);
            exportRegistryToExcelButton.TabIndex = 17;
            exportRegistryToExcelButton.Text = "Экспорт в Excel";
            exportRegistryToExcelButton.UseVisualStyleBackColor = true;
            exportRegistryToExcelButton.Click += exportRegistryToExcelButton_Click;
            // 
            // deleteAnimalCardButton
            // 
            deleteAnimalCardButton.ForeColor = Color.FromArgb(53, 153, 255);
            deleteAnimalCardButton.Location = new Point(375, 604);
            deleteAnimalCardButton.Name = "deleteAnimalCardButton";
            deleteAnimalCardButton.Size = new Size(163, 86);
            deleteAnimalCardButton.TabIndex = 18;
            deleteAnimalCardButton.Text = "Удалить карточку";
            deleteAnimalCardButton.UseVisualStyleBackColor = true;
            deleteAnimalCardButton.Click += deleteAnimalCardButton_Click;
            // 
            // AnimalsRegistryForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1368, 735);
            Controls.Add(deleteAnimalCardButton);
            Controls.Add(exportRegistryToExcelButton);
            Controls.Add(viewAnimalCardButton);
            Controls.Add(sortGroupBox);
            Controls.Add(addAnimalRecordButton);
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
        private Button addAnimalRecordButton;
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
        private Button clearSortButton;
        private Button viewAnimalCardButton;
        private Button exportRegistryToExcelButton;
        private Button deleteAnimalCardButton;
        private Button applyFilterButton;
        private Button applySortButton;
    }
}