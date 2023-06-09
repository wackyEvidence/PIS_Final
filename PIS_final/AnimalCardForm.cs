using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;
using Library.Models;
using Library.Registries;
using static System.Net.Mime.MediaTypeNames;

namespace UI
{
    public partial class AnimalCardForm : Form
    {
        private FormMode formMode;
        private AnimalsRegistry animalsRegistry;
        public AnimalCardForm(FormMode formMode, Animal editedAnimal, AnimalsRegistry animalsRegistry)
        {
            InitializeComponent();
            this.formMode = formMode;
            this.animalsRegistry = animalsRegistry;

            if (!animalsRegistry.CanChange)
            {
                editAnimalCardButton.Enabled = false;
                applyChangesOrAddAnimalButton.Enabled = false;
            }

            if (formMode == FormMode.Editing)
            {
                animalNicknameLabel.Text = editedAnimal.Nickname;

                regCardNumberTextBox.Text = editedAnimal.RegCardNumber.ToString();
                regCardNumberTextBox.Enabled = false; 

                locationComboBox.SelectedItem = editedAnimal.Location;
                locationComboBox.Enabled = false; 

                animalCategoryComboBox.SelectedItem = editedAnimal.Category;
                animalCategoryComboBox.Enabled = false;

                animalSexComboBox.SelectedItem = editedAnimal.Sex;
                animalSexComboBox.Enabled = false; 

                animalBirthYearTextBox.Text = editedAnimal.BirthYear.ToString();
                animalBirthYearTextBox.Enabled = false; 

                animalChipNumberTextBox.Text = editedAnimal.ChipNumber.ToString();
                animalChipNumberTextBox.Enabled = false; 

                animalNicknameTextBox.Text = editedAnimal.Nickname;
                animalNicknameTextBox.Enabled = false; 

                distinguishingMarksRichTextBox.Text = editedAnimal.DistinguishingMarks;
                distinguishingMarksRichTextBox.Enabled = false; 

                for (int i = 0; i < editedAnimal.OwnerSigns.Count; i++)
                {
                    var index = (int)editedAnimal.OwnerSigns[i];
                    if (index < 4)
                        ownerSignsCheckedListBox.SetSelected(index, true);
                }

                ownerSignsCheckedListBox.Enabled = false; 

                var image = new Bitmap(editedAnimal.Photo);
                animalPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                animalPictureBox.Image = image;
            }
            else
            {
                headerLabel.Text = "Добавление карточки";
                animalNicknameLabel.Visible = false;
                applyChangesOrAddAnimalButton.Text = "Добавить карточку";
                editAnimalCardButton.Visible = false; 
            }
        }

        private void editAnimalCardButton_Click(object sender, EventArgs e)
        {
            regCardNumberTextBox.Enabled = true;
            locationComboBox.Enabled = true;
            animalCategoryComboBox.Enabled = true;
            animalSexComboBox.Enabled = true;
            animalBirthYearTextBox.Enabled = true;
            animalChipNumberTextBox.Enabled = true;
            animalNicknameTextBox.Enabled = true;
            distinguishingMarksRichTextBox.Enabled = true;
            ownerSignsCheckedListBox.Enabled = true;
        }

        private void applyChangesOrAddAnimalButton_Click(object sender, EventArgs e)
        {
            if(formMode == FormMode.Editing)
            {

            }
            else
            {

            }
        }
    }
}
