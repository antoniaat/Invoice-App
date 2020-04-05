using System;
using System.Windows.Forms;

namespace Invoice_App
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
            
        }

        private void Mycompany_Click(object sender, EventArgs e)
        {
            var companyForm = new Mycompany();
            companyForm.TopMost = true;
            companyForm.Show();
            
        }

        private void partner_Click(object sender, EventArgs e)
        {
            var partnersForm = new Partners();
            partnersForm.TopMost = true;
            partnersForm.Show();
        }

        private void invoicelist_Click(object sender, EventArgs e)
        {
            var invoiceListForm = new InvoiceList();
            invoiceListForm.TopMost = true;
            invoiceListForm.Show();
        }

        private void addinvoice_Click(object sender, EventArgs e)
        {
            var addInvoiceForm = new MainForm();
            addInvoiceForm.TopMost = true;
            addInvoiceForm.Show();
        }

        private void mainexit_Click(object sender, EventArgs e)
        {
            var loginform = new LoginForm();
            loginform.Show();
            this.Close();
        }
    }
}
