using EchoHub.Common;
using EchoHub.Common.Helper;
using EchoHub.Common.Models;
using EchoHub.Forms.Core;
using EchoHub.Forms.Elements;
using EchoHub.Forms.Helper;
using EchoHub.Forms.Interface.Controls;
using EchoHub.Forms.Interface.Dialogs;

namespace EchoHub.Forms.Interface
{
    public partial class MainForm : Form
    {

        public readonly User _user;

        public MainForm(User _user)
        {
            InitializeComponent();
            RoundBorder.Round(btnUser, 8);
            RoundBorder.Round(btnCreateServer, 8);
            RoundBorder.Round(btnChangelog, 8);
            RoundBorder.Round(btnNotification, 8);

            this._user = _user;
            Image? userImage = ClientHelper.AskUserImage(this._user.Id);

            this.setContent(new AccountControl(_user, this, userImage));

            reloadServers();
            updateServers.Start();

        }

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

        private void clearContent()
        {
            pnServers.Controls.Clear();
        }

        private void reloadServers()
        {
            clearContent();

            MessagePackage _send = PackageHelper.CreatePackage(MessageType.GetServers);
            _send.Informations.Add(this._user.Id.ToString());

            Client.Send(_send);

            MessagePackage _receive = Client.Listen();

            if (PackageHelper.IsPositive(_receive))
            {

                for (int i = 0; i < _receive.Informations.Count; i += 2)
                {
                    int serverID = Convert.ToInt32(_receive.Informations[i]);
                    Image? serverImage = ClientHelper.AskServerImage(serverID);

                    addServer(serverID, _receive.Informations[i + 1], serverImage);
                }

            }
            else
            {
                AdviceDialog _advice = new AdviceDialog("Erro ao carregar os servidores!");
                _advice.ShowDialog();
            }

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
            this.pnCorner.BackColor = Color.FromArgb(255, 65, 65, 65);
        }

        private void pbLogo_MouseLeave(object sender, EventArgs e)
        {
            this.pnCorner.BackColor = Color.FromArgb(0, 45, 45, 45);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Image? img = null;
            MessagePackage _send = new MessagePackage();
            _send.Type = MessageType.GetUserPhoto;
            _send.Informations = new List<string>();
            _send.Informations.Add(this._user.Id.ToString());

            Client.Send(_send);
            MessagePackage _received = Client.Listen();

            if (_received.Type == MessageType.Positive)
            {
                byte[] _img = Convert.FromBase64String(_received.Informations[0]);
                MemoryStream _mStream = new MemoryStream(_img);
                img = Image.FromStream(_mStream);

            }

            setContent(new AccountControl(this._user, this, img));
        }

        private void btnCreateServer_Click(object sender, EventArgs e)
        {
            setContent(new NewServerControl(this));
        }

        private void btnUser_MouseEnter(object sender, EventArgs e)
        {
            this.btnUser.BackColor = Color.FromArgb(255, 80, 80, 80);
        }

        private void btnUser_MouseLeave(object sender, EventArgs e)
        {
            this.btnUser.BackColor = Color.FromArgb(0, 45, 45, 45);
        }

        private void btnCreateServer_MouseEnter(object sender, EventArgs e)
        {
            this.btnCreateServer.BackColor = Color.FromArgb(255, 80, 80, 80);
        }

        private void btnCreateServer_MouseLeave(object sender, EventArgs e)
        {
            this.btnCreateServer.BackColor = Color.FromArgb(0, 45, 45, 45);
        }

        private void btnNotification_MouseEnter(object sender, EventArgs e)
        {
            this.btnNotification.BackColor = Color.FromArgb(255, 80, 80, 80);
        }

        private void btnChangelog_MouseEnter(object sender, EventArgs e)
        {
            this.btnChangelog.BackColor = Color.FromArgb(255, 80, 80, 80);
        }

        private void btnNotification_MouseLeave(object sender, EventArgs e)
        {
            this.btnNotification.BackColor = Color.FromArgb(0, 45, 45, 45);
        }

        private void btnChangelog_MouseLeave(object sender, EventArgs e)
        {
            this.btnChangelog.BackColor = Color.FromArgb(0, 45, 45, 45);
        }
    }
}
