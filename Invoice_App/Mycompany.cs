using System.Windows.Forms;

namespace Invoice_App
{
    public partial class Mycompany : Form
    {
        public Mycompany()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            StartPage startPageForm  = new StartPage();
            startPageForm.ShowDialog();
            this.Close();
        }
    }
}
