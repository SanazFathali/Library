namespace WinFormsApp1
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void btnsubscribe_Click(object sender, EventArgs e)
        {
            FrmSubscriber frmSubscriber = new FrmSubscriber();
            frmSubscriber.ShowDialog();
           
        }
    }
}