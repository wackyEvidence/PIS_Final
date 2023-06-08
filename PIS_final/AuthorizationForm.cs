using UI;
using Library;

namespace PIS_final
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*'; 
        }

        private void authorizeButton_Click(object sender, EventArgs e)
        {
            var userLogin = loginTextBox.Text;
            var userPassword = passwordTextBox.Text;
            try
            {
                if (Authorizer.AuthorizeUser(userLogin, userPassword))
                {
                    var menu = new MainMenuForm(Authorizer.CurrentUser.FirstName);
                    menu.Show();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Пожалуйста, проверьте введенные логин и пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}