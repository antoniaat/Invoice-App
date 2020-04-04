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

        private void StartPage_Load(object sender, EventArgs e)
        {

        }

        private void Mycompany_Click(object sender, EventArgs e)
        {
            var companyForm = new Mycompany();
            companyForm.Show();
        }

        private void partner_Click(object sender, EventArgs e)
        {
            var partnersForm = new Partners();
            partnersForm.Show();
        }

        private void invoicelist_Click(object sender, EventArgs e)
        {
            var invoiceListForm = new InvoiceList();
            invoiceListForm.Show();
        }

        private void addinvoice_Click(object sender, EventArgs e)
        {
            var addInvoiceForm = new MainForm();
            addInvoiceForm.Show();
        }
    }
}
