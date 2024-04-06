using EchoHub.Common;
using EchoHub.Common.Models;
using EchoHub.Forms.Core;
using EchoHub.Forms.Interface.Dialogs;
using Microsoft.VisualBasic;
using System.ComponentModel.Design.Serialization;
using System.Drawing.Design;
using System.Runtime.InteropServices;

namespace EchoHub.Forms.Interface.Controls
{
    public partial class ServerControl : UserControl
    {

        private int _round = 8;
        private User _user;
        private MainForm _target;
        private int _id;
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

        private void addUser()
        {

            UserHub _userHub = new UserHub();
            _userHub.Location = new Point(0, pnUser.Controls.Count * _userHub.Height);
            pnUser.Controls.Add(_userHub);

        }

        private void addMessage(string User, string Content)
        {

            MessageControl _messageControl = new MessageControl();
            _messageControl.txtContent.Text = Content;
            _messageControl.txtName.Text = User;
            _messageControl.Location = new Point(0, pnMessages.Controls.Count * _messageControl.Height);
            pnMessages.Controls.Add(_messageControl);

        }

        private void addChannel(string Name, int Id)
        {

            ChannelControl _channelControl = new ChannelControl(Name, Id);
            _channelControl.Location = new Point(0, pnChannel.Controls.Count * _channelControl.Height);
            pnChannel.Controls.Add(_channelControl);

        }

        private void reloadChannels()
        {

            MessagePackage _send = new MessagePackage();
            _send.Informations = new List<string>();
            _send.Informations.Add(_id.ToString());
            _send.Type = MessageType.GetChats;
            Client.Send(_send);

            MessagePackage _receive = Client.Listen();

            if(_receive.Type == MessageType.Positive)
            {

                for(int i = 0;i<_receive.Informations.Count;i+=2)
                {
                    addChannel(_receive.Informations[1], Convert.ToInt32(_receive.Informations[0]));
                }

            }
            else
            {
                AdviceDialog _advice = new AdviceDialog("Não foi possivel carregas os chats...");
                _advice.ShowDialog();
            }

        }

        public ServerControl(User _user, MainForm _target, int _id)
        {



            InitializeComponent();
            this._user = _user;
            this._target = _target;
            this.txtUserName.Text = _user.Name;
            this._id = _id;
            this.reloadChannels();

            this.btnConfig.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnConfig.Width, btnConfig.Height, _round, _round));
            this.btnMic.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnMic.Width, btnMic.Height, _round, _round));
            this.btnPhone.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnPhone.Width, btnPhone.Height, _round, _round));

            //test




        }

        private void txtChat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                addMessage(this._user.Name, txtChat.Text);
                txtChat.Text = "";
            }
        }

        private void btnNewChat_Click(object sender, EventArgs e)
        {

            MessagePackage _send = new MessagePackage();
            _send.Type = MessageType.CreateChat;
            _send.Informations = new List<string>();
            _send.Informations.Add(_id.ToString());
            _send.Informations.Add("Novo chat");

            Client.Send(_send);

            MessagePackage _received = Client.Listen();

            if(_received.Type == MessageType.Positive)
            {
                addChannel("Novo chat", Convert.ToInt32(_received.Informations[0]));
            }
            else
            {
                AdviceDialog _advice = new AdviceDialog("Erro interno ao criar chat...");
                _advice.ShowDialog();
            }

        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            this._target.setContent(new AccountControl(this._user));
        }
    }
}