using Library;
using PIS_final;
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
        public Form parentForm;

        public MainMenuForm(Form parentForm, string userName)
        {
            InitializeComponent();
            this.parentForm = parentForm;
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

        private void changeUserButton_Click(object sender, EventArgs e)
        {
            Authorizer.CurrentUser = null;
            parentForm.Show();
            Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (parentForm.Visible == false)
                Application.Exit();
        }
    }
}
