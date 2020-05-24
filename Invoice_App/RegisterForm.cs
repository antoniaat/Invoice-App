using System;
using System.Data;
using System.Data.SqlClient;
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

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True");
            SqlCommand cmd = new SqlCommand("sp_insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@firstName", firstName.Text);
            cmd.Parameters.AddWithValue("@lastName", lastName.Text);
            cmd.Parameters.AddWithValue("@password", password.Text);
            cmd.Parameters.AddWithValue("@job", job.Text);
            cmd.Parameters.AddWithValue("@phone", phone.Text);
            //int i = cmd.ExecuteNonQuery();
            con.Open();
            con.Close();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
