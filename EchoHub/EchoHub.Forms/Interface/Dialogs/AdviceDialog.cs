namespace EchoHub.Forms.Interface.Dialogs
{
    public partial class AdviceDialog : Form
    {
        public AdviceDialog(string text)
        {
            InitializeComponent();
            this.txtAdvice.Text = text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
