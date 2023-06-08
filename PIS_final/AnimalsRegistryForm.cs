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

namespace UI
{
    public partial class AnimalsRegistryForm : Form
    {
        private AnimalsRegistry animalsRegistry;
        public AnimalsRegistryForm()
        {
            InitializeComponent();
            animalsRegistry = new AnimalsRegistry(Authorizer.CurrentUser.PermissionManager);
        }

        private void addAnimalRecordButton_Click(object sender, EventArgs e)
        {

        }

        private void viewAnimalCardButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteAnimalCardButton_Click(object sender, EventArgs e)
        {

        }

        private void exportRegistryToExcelButton_Click(object sender, EventArgs e)
        {

        }

        private void applyFilterButton_Click(object sender, EventArgs e)
        {

        }

        private void clearFilterButton_Click(object sender, EventArgs e)
        {

        }

        private void applySortButton_Click(object sender, EventArgs e)
        {

        }

        private void clearSortButton_Click(object sender, EventArgs e)
        {

        }
    }
}
