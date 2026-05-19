using System;
using System.Windows.Forms;

namespace AnthonySantosInventoryManagementSystem
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private async void ButtonCreate_Click(object sender, EventArgs e)
        {
            string username = TextBoxUsername.Text.Trim();
            string email = TextBoxEmail.Text.Trim();
            string password = TextBoxPassword.Text;
            string confirmPassword = TextBoxConfirmPassword.Text;

            // Validation
            if (string.IsNullOrEmpty(username))
            {
                LabelError.Text = "Username is required.";
                return;
            }
            if (string.IsNullOrEmpty(email))
            {
                LabelError.Text = "Email is required.";
                return;
            }
            if (!email.Contains("@") || !email.Contains("."))
            {
                LabelError.Text = "Please enter a valid email address.";
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                LabelError.Text = "Password is required.";
                return;
            }
            if (password.Length < 6)
            {
                LabelError.Text = "Password must be at least 6 characters.";
                return;
            }
            if (password != confirmPassword)
            {
                LabelError.Text = "Passwords do not match.";
                return;
            }

            ButtonCreate.Enabled = false;
            LabelError.Text = "";

            try
            {
                bool success = await ApiService.RegisterAsync(username, email, password);

                if (success)
                {
                    MessageBox.Show("Account created successfully! Please login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    LabelError.Text = "Registration failed. Username may already exist.";
                }
            }
            catch (Exception ex)
            {
                LabelError.Text = "Connection error: " + ex.Message;
            }
            finally
            {
                ButtonCreate.Enabled = true;
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}