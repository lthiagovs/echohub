using EchoHub.Forms.Interface.Controls;
using System.Runtime.InteropServices;

namespace EchoHub.Forms.Interface
{
    public partial class MainForm : Form
    {

        private int _round = 8;
        //Round Borders
        #region
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        #endregion

        private void addServer()
        {

            ServerHub _serverHub = new ServerHub();
            _serverHub.Location = new Point(0, (_serverHub.Height * pnServers.Controls.Count)+20);
            this.pnServers.Controls.Add(_serverHub);

        }

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


            //test
            addServer();

        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

            addServer();

        }
    }
}
