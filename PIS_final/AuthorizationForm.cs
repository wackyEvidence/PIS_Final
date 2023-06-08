using UI;
using Library; 

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
            var userLogin = loginTextBox.Text; 
            var userPassword = passwordTextBox.Text;    
            if(Authorizer.AuthorizeUser(userLogin, userPassword))
            {
                var menu = new MainMenuForm();
                menu.Show();
            }
            
        }
    }
}