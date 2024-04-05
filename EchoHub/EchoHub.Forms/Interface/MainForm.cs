using EchoHub.Common.Models;
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

        public User _logged;

        public void addServer(int ServerId, string Name)
        {

            ServerHub _serverHub = new ServerHub(this, ServerId, Name);
            _serverHub.Location = new Point(0, (_serverHub.Height * pnServers.Controls.Count)+20);
            this.pnServers.Controls.Add(_serverHub);

        }

        public void setContent(Control control)
        {
            this.pnContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            this.pnContent.Controls.Add(control);
        }

        private void reloadServers()
        {



        }

        public MainForm(User _user)
        {
            InitializeComponent();
            this.setContent(new AccountControl());

            _logged = _user;


            //test
            //addServer();

        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

            setContent(new NewServerControl(this));

        }
    }
}
