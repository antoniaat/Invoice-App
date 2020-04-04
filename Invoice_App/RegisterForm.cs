using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_App
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AlreadyRegistered_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show(); 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
