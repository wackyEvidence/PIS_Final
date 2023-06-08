using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;
using Library.Registries;
using Library.Models;
using Library.DBAdapters; 

namespace UI
{
    public partial class AnimalsRegistryForm : Form
    {
        private AnimalsRegistry animalsRegistry;
        private List<Animal> animalsList; 
        private List<Filter> userFilters = new List<Filter>();
        private Sort userSort = new Sort("None", Library.SortOrder.None); 
        private List<string> columnNames = new List<string>() { "Рег. номер\nкарточки", "Населенный пункт", "Категория", "Пол", "Год рождения", "Номер\nэлектронного чипа", "Кличка" };

        private Dictionary<string, string> columnsTranslation = new Dictionary<string, string>()
        {
            { "Рег. номер карточки", "RegCardNumber" },
            { "Населенный пункт", "Location" },
            { "Категория", "Category" },
            { "Пол", "Sex" },
            { "Год рождения", "BirthYear" },
            { "Номер электронного чипа", "ChipNumber"},
            { "Кличка", "Nickname" }
        };
        //private Dictionary<string, string> locationTranslation = new Dictionary<string, string>() { { "Tyumen", "Тюмень" }, { "SaintPetersburg", "Санкт-Петербург" } };
        //private Dictionary<string, string> animalCategoryTranslation = new Dictionary<string, string>() { { "Dog", "Собака" }, { "Cat", "Кошка" } };


        public AnimalsRegistryForm()
        {   
            InitializeComponent();
            animalsRegistry = new AnimalsRegistry(Authorizer.CurrentUser.PermissionManager);
            animalsList = animalsRegistry.GetAnimalsList(new List<Filter>(), userSort);
            ConfigureDataGridView(dataGridView1);
            
            filterAttributeComboBox.DataSource = new List<string>() { "Рег. номер карточки", "Населенный пункт", "Категория", "Пол", "Год рождения", "Номер электронного чипа", "Кличка" }; 
            sortAttributeComboBox.DataSource = new List<string>() { "Рег. номер карточки", "Населенный пункт", "Категория", "Пол", "Год рождения", "Номер электронного чипа", "Кличка" }; 
            filterAttributeComboBox.SelectedItem = null;
            sortAttributeComboBox.SelectedItem = null;

            if (!animalsRegistry.CanChange)
            {
                addAnimalRecordButton.Enabled = false;
                deleteAnimalCardButton.Enabled = false;
            }
        }

        /// <summary>
        /// Настройка видимости и заголовков столбцов 
        /// </summary>
        /// <param name="dataGridView1"></param>
        private void ConfigureDataGridView(DataGridView dataGridView1)
        {
            dataGridView1.DataSource = animalsList;
            dataGridView1.Rows[0].Selected = false;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;

            for (int i = 1; i < 8; i++)
                dataGridView1.Columns[i].HeaderText = columnNames[i - 1];
        }

        private void addAnimalRecordButton_Click(object sender, EventArgs e)
        {
            var animalCardForm = new AnimalCardForm(FormMode.Adding, null);
            animalCardForm.ShowDialog(); 
        }

        private void viewAnimalCardButton_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                var currentRow = dataGridView1.CurrentRow.Index;
                var animalCardForm = new AnimalCardForm(FormMode.Adding, animalsList[currentRow]);
                animalCardForm.ShowDialog();
            }
        }

        private void deleteAnimalCardButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var currentRow = dataGridView1.CurrentRow.Index;
                AnimalsDBAdapter.RemoveAt(currentRow);
                dataGridView1.DataSource = animalsRegistry.GetAnimalsList(userFilters, userSort);
            }
        }

        private void exportRegistryToExcelButton_Click(object sender, EventArgs e)
        {

        }

        private void applyFilterButton_Click(object sender, EventArgs e)
        {
            if (filterAttributeComboBox.SelectedItem == null || string.IsNullOrEmpty(filterValueTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, укажите все необходимые параметры фильтра");
            }
            else
            {
                userFilters.Add(new Filter(filterAttributeComboBox.SelectedItem.ToString(), filterValueTextBox.Text));
                dataGridView1.DataSource = animalsRegistry.GetAnimalsList(userFilters, userSort);
            }
        }

        private void clearFilterButton_Click(object sender, EventArgs e)
        {
            userFilters.Clear();
            dataGridView1.DataSource = animalsRegistry.GetAnimalsList(userFilters, userSort);
        }

        private void applySortButton_Click(object sender, EventArgs e)
        {
            if (sortAttributeComboBox.SelectedItem == null || sortOrderComboBox.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, укажите все необходимые параметры фильтра");
            }
            else
            {
                userSort = new Sort(sortAttributeComboBox.SelectedItem.ToString(), (Library.SortOrder)sortOrderComboBox.SelectedIndex);
                dataGridView1.DataSource = animalsRegistry.GetAnimalsList(userFilters, userSort);
            }
        }

        private void clearSortButton_Click(object sender, EventArgs e)
        {
            userSort = new Sort("None", Library.SortOrder.None);
            dataGridView1.DataSource = animalsRegistry.GetAnimalsList(userFilters, userSort);
        }
    }
}
