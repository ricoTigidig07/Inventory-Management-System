using System;
using System.Windows.Forms;

namespace AnthonySantosInventoryManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = TextBoxUsername.Text.Trim();
            string password = TextBoxPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                LabelError.Text = "Please enter username and password.";
                return;
            }

            ButtonLogin.Enabled = false;
            LabelError.Text = "";

            try
            {
                bool success = await ApiService.LoginAsync(username, password);

                if (success)
                {
                    InventoryManagementSystemMainScreen main = new InventoryManagementSystemMainScreen();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    LabelError.Text = "Invalid username or password.";
                }
            }
            catch (Exception ex)
            {
                LabelError.Text = "Connection error: " + ex.Message;
            }
            finally
            {
                ButtonLogin.Enabled = true;
            }
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}