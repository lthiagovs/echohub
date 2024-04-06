using EchoHub.Common;
using EchoHub.Common.Models;
using EchoHub.Forms.Core;
using EchoHub.Forms.Interface.Controls;
using EchoHub.Forms.Interface.Dialogs;
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

            MessagePackage _send = new MessagePackage();
            _send.Type = MessageType.GetServers;
            _send.Informations = new List<string>();
            _send.Informations.Add(_logged.Id.ToString());

            Client.Send( _send );

            MessagePackage _receive = Client.Listen();

            if(_receive.Type==MessageType.Positive)
            {

                for(int i = 0;i<_receive.Informations.Count;i+=2)
                {
                    addServer(Convert.ToInt32(_receive.Informations[i]), _receive.Informations[i + 1]);
                }

            }
            else
            {
                AdviceDialog _advice = new AdviceDialog("Erro ao carregar os servidores!");
                _advice.ShowDialog();
            }

        }

        public MainForm(User _user)
        {
            InitializeComponent();
            this.setContent(new AccountControl(_user));

            _logged = _user;
            reloadServers();


            //test
            //addServer();

        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

            setContent(new NewServerControl(this));

        }
    }
}
