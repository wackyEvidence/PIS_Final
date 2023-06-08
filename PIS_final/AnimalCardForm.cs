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
using Library.Models; 

namespace UI
{
    public partial class AnimalCardForm : Form
    {
        private FormMode mode;
        public AnimalCardForm(FormMode formMode, Animal editedAnimal)
        {
            InitializeComponent();
            mode = formMode;
            if (formMode == FormMode.Editing)
            {
                
            }
            else
            {

            }
        }

        private void editAnimalCardButton_Click(object sender, EventArgs e)
        {

        }

        private void applyChangesOrAddAnimalButton_Click(object sender, EventArgs e)
        {

        }
    }
}
