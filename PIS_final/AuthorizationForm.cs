using UI;

namespace PIS_final
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void authorizeButton_Click(object sender, EventArgs e)
        {
            var menu = new MainMenuForm();
            menu.Show();
        }
    }
}