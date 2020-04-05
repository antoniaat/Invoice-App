using System;
using System.Windows.Forms;

namespace Invoice_App
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void AlreadyRegistered_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.TopMost = true;
            loginForm.Show();
            this.Hide();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.TopMost = true;
            loginForm.Show();


        }
       
}
}
