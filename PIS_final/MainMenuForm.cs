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
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void openAnimalsRegistryButton_Click(object sender, EventArgs e)
        {
            var registry = new AnimalsRegistryForm();
            registry.Show();
        }
    }
}
