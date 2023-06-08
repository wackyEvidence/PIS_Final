using UI;
using Library;
using System.Runtime.CompilerServices;

namespace PIS_final
{
    public partial class AuthorizationForm : Form
    {
        private TextBox _loginTextBox; 
        private TextBox _passwordTextBox;

        public AuthorizationForm()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';
            _loginTextBox = loginTextBox; 
            _passwordTextBox = passwordTextBox;
            loginTextBox.Text = "AnnaIvanova";
            passwordTextBox.Text = "123456"; 
        }

        private void authorizeButton_Click(object sender, EventArgs e)
        {
            var userLogin = loginTextBox.Text;
            var userPassword = passwordTextBox.Text;
            try
            {
                if (Authorizer.AuthorizeUser(userLogin, userPassword))
                {
                    var menu = new MainMenuForm(this, Authorizer.CurrentUser.FirstName);
                    this.Hide(); // прячем форму авторизации
                    this.ClearTextBoxes(); 
                    menu.Show();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Пожалуйста, проверьте введенные логин и пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextBoxes()
        {
            _loginTextBox.Text = string.Empty; 
            _passwordTextBox.Text = string.Empty;   
        }
    }
}