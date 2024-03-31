using EchoHub.Forms.Interface.Controls;

namespace EchoHub.Forms.Interface
{
    public partial class MainForm : Form
    {


        private void setContent(Control control)
        {
            this.pnContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            this.pnContent.Controls.Add(control);
        }

        public MainForm()
        {
            InitializeComponent();
            this.setContent(new ServerControl());
        }
    }
}
