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

        public void addServer(int ServerId, string Name, Image? img)
        {

            ServerHub _serverHub = new ServerHub(this, ServerId, Name, img);
            _serverHub.Location = new Point(0, (_serverHub.Height * pnServers.Controls.Count) + 20);
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
            pnServers.Controls.Clear();
            MessagePackage _send = new MessagePackage();
            _send.Type = MessageType.GetServers;
            _send.Informations = new List<string>();
            _send.Informations.Add(_logged.Id.ToString());

            Client.Send(_send);

            MessagePackage _receive = Client.Listen();

            if (_receive.Type == MessageType.Positive)
            {

                for (int i = 0; i < _receive.Informations.Count; i += 2)
                {
                    int serverID = Convert.ToInt32(_receive.Informations[i]);
                    Image? img = null;

                    //Ask for image
                    _send = new MessagePackage();
                    _send.Type = MessageType.GetServerPhoto;
                    _send.Informations = new List<string>();
                    _send.Informations.Add(serverID.ToString());
                    Client.Send(_send);
                    MessagePackage _receivedImage = Client.Listen();

                    if(_receive.Type==MessageType.Positive)
                    {

                        byte[] _img = Convert.FromBase64String(_receivedImage.Informations[0]);
                        MemoryStream _mStream = new MemoryStream(_img);
                        img = Image.FromStream(_mStream);

                    }

                    addServer(serverID, _receive.Informations[i + 1], img);
                }

            }
            else
            {
                AdviceDialog _advice = new AdviceDialog("Erro ao carregar os servidores!");
                _advice.ShowDialog();
            }

        }

        private void updateServersRealTime()
        {
            MessagePackage _send = new MessagePackage();
            _send.Type = MessageType.GetServers;
            _send.Informations = new List<string>();
            _send.Informations.Add(_logged.Id.ToString());

            Client.Send(_send);

            MessagePackage _receive = Client.Listen();

            if (_receive.Type == MessageType.Positive)
            {

                if (pnServers.Controls.Count != _receive.Informations.Count / 2)
                {
                    pnServers.Controls.Clear();
                    for (int i = 0; i < _receive.Informations.Count; i += 2)
                    {
                        addServer(Convert.ToInt32(_receive.Informations[i]), _receive.Informations[i + 1],null);
                    }
                }

            }

        }

        public MainForm(User _user)
        {
            InitializeComponent();
            _logged = _user;
            Image? img = null;
            MessagePackage _send = new MessagePackage();
            _send.Type = MessageType.GetUserPhoto;
            _send.Informations = new List<string>();
            _send.Informations.Add(this._logged.Id.ToString());

            Client.Send(_send);
            MessagePackage _received = Client.Listen();

            if (_received.Type == MessageType.Positive)
            {
                byte[] _img = Convert.FromBase64String(_received.Informations[0]);
                MemoryStream _mStream = new MemoryStream(_img);
                img = Image.FromStream(_mStream);

            }

            this.setContent(new AccountControl(_user,this,img));

            reloadServers();
            updateServers.Start();

        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

            setContent(new NewServerControl(this));

        }

        private void updateServers_Tick(object sender, EventArgs e)
        {
            //this.updateServersRealTime();
        }

        private void pbLogo_MouseEnter(object sender, EventArgs e)
        {
            this.pnCorner.BackColor = Color.FromArgb(255,65,65,65);
        }

        private void pbLogo_MouseLeave(object sender, EventArgs e)
        {
            this.pnCorner.BackColor = Color.FromArgb(0,45,45,45);
        }
    }
}
