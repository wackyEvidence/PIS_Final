using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm(string userName)
        {
            InitializeComponent();
            userNameLabel.Text = userName;
        }

        private void openAnimalsRegistryButton_Click(object sender, EventArgs e)
        {
            var animalsRegistryForm = new AnimalsRegistryForm();
            animalsRegistryForm.Show();
        }

        private void openOrganizationsRegistryButton_Click(object sender, EventArgs e)
        {

        }

        private void openContractsRegistryButton_Click(object sender, EventArgs e)
        {

        }

        private void getReportButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
