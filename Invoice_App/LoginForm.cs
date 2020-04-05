using System;
using System.Windows.Forms;

namespace Invoice_App
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void DontHaveAnAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var startPageForm = new StartPage();
            startPageForm.TopMost = true;
            startPageForm.Show();

        }
    }
}
