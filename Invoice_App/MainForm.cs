using System.Windows.Forms;

namespace Invoice_App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
