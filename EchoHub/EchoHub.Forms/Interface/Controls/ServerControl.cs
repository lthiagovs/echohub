using EchoHub.Common;
using EchoHub.Common.Models;
using EchoHub.Forms.Core;
using EchoHub.Forms.Interface.Dialogs;
using System.Runtime.InteropServices;

namespace EchoHub.Forms.Interface.Controls
{
    public partial class ServerControl : UserControl
    {

        private int _round = 8;
        private User _user;
        private MainForm _target;
        public ChannelControl _selectedChannel;
        private int _id;

        private bool titleTimerTrigger = false;

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

        private void addUser(int Id, string Name)
        {

            UserHub _userHub = new UserHub(Id,Name);
            _userHub.Location = new Point(0, pnUser.Controls.Count * _userHub.Height);
            pnUser.Controls.Add(_userHub);

        }

        private void reloadUser()
        {
            MessagePackage _send = new MessagePackage();
            _send.Type = MessageType.GetFriends;
            _send.Informations = new List<string>();
            _send.Informations.Add(_id.ToString());

            Client.Send(_send);

            MessagePackage _received = Client.Listen();

            if (_received.Type==MessageType.Positive)
            {

                for(int i = 0;i<_received.Informations.Count;i+=2)
                {

                    addUser(
                        Convert.ToInt32(_received.Informations[i]),
                        _received.Informations[i + 1]
                        );

                }

            }
            else
            {
                AdviceDialog _advice = new AdviceDialog("Falha ao carregar usuarios...");
                _advice.ShowDialog();
            }


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

            ChannelControl _channelControl = new ChannelControl(Name, Id, this);
            _channelControl.Location = new Point(0, pnChannel.Controls.Count * _channelControl.Height);
            pnChannel.Controls.Add(_channelControl);

        }

        public void clearMessages()
        {
            pnMessages.Controls.Clear();
        }

        private void reloadChannels()
        {

            MessagePackage _send = new MessagePackage();
            _send.Informations = new List<string>();
            _send.Informations.Add(_id.ToString());
            _send.Type = MessageType.GetChats;
            Client.Send(_send);

            MessagePackage _receive = Client.Listen();

            if (_receive.Type == MessageType.Positive)
            {

                for (int i = 0; i < _receive.Informations.Count(); i += 2)
                {
                    addChannel(_receive.Informations[i+1], Convert.ToInt32(_receive.Informations[i]));
                }

            }
            else
            {
                AdviceDialog _advice = new AdviceDialog("Não foi possivel carregas os chats...");
                _advice.ShowDialog();
            }

        }

        public void reloadMessages(int chatId)
        {

            MessagePackage _send = new MessagePackage();
            _send.Type = MessageType.GetMessages;
            _send.Informations = new List<string>();
            _send.Informations.Add(chatId.ToString());

            Client.Send(_send);

            MessagePackage _receive = Client.Listen();

            if (_receive.Type == MessageType.Positive)
            {
                foreach (string message in _receive.Informations)
                    addMessage(_user.Name, message);
            }
            else
            {
                AdviceDialog _advice = new AdviceDialog("Erro interno ao carregar as mensagens...");
                _advice.Show();
            }

        }

        public void setChannel(ChannelControl channel)
        {
            this._selectedChannel = channel;
            this.txtChatName.Text = channel.txtName.Text;
            this.pnMessages.Controls.Clear();
        }

        public ServerControl(User _user, MainForm _target, int _id, string Name)
        {



            InitializeComponent();
            this._user = _user;
            this.btnServer.Text = Name;
            this._target = _target;
            this.txtUserName.Text = _user.Name;
            this._id = _id;
            this.reloadChannels();
            this.reloadUser();
            this.setChannel(pnChannel.Controls[0] as ChannelControl);
            this.reloadMessages(_selectedChannel._id);

            this.btnConfig.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnConfig.Width, btnConfig.Height, _round, _round));
            this.btnMic.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnMic.Width, btnMic.Height, _round, _round));
            this.btnPhone.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnPhone.Width, btnPhone.Height, _round, _round));

            //test




        }

        private void txtChat_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                MessagePackage _send = new MessagePackage();
                _send.Informations = new List<string>();
                _send.Informations.Add(_selectedChannel._id.ToString());
                _send.Informations.Add(txtChat.Text);
                _send.Type = MessageType.CreateMessage;

                Client.Send(_send);

                MessagePackage _received = Client.Listen();

                if (_received.Type == MessageType.Positive)
                {
                    addMessage(this._user.Name, txtChat.Text);
                    txtChat.Text = "";
                }
                else
                {
                    AdviceDialog _advice = new AdviceDialog("Erro interno ao enviar a mensagem...");
                    _advice.ShowDialog();
                }

            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            this._target.setContent(new AccountControl(this._user));
        }

        private void btnGif_Click(object sender, EventArgs e)
        {
            reloadMessages(_selectedChannel._id);
        }

        private void btnCreateChat_Click(object sender, EventArgs e)
        {
            MessagePackage _send = new MessagePackage();
            _send.Type = MessageType.CreateChat;
            _send.Informations = new List<string>();
            _send.Informations.Add(_id.ToString());
            _send.Informations.Add("Novo chat");

            Client.Send(_send);

            MessagePackage _received = Client.Listen();

            if (_received.Type == MessageType.Positive)
            {
                addChannel("Novo chat", Convert.ToInt32(_received.Informations[0]));
            }
            else
            {
                AdviceDialog _advice = new AdviceDialog("Erro interno ao criar chat...");
                _advice.ShowDialog();
            }
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            titleTimerTrigger = !titleTimerTrigger;
            titleTimer.Start();
        }

        private void titleTimer_Tick(object sender, EventArgs e)
        {

            if (titleTimerTrigger)
            {
                pnTitle.Size = new Size(pnTitle.Width, pnTitle.Height + 20);
                if (pnTitle.Height >= pnTitle.MaximumSize.Height)
                {
                    //titleTimer.Stop();
                }


            }
            else
            {
                pnTitle.Size = new Size(pnTitle.Width, pnTitle.Height - 20);
                if (pnTitle.Height <= pnTitle.MinimumSize.Height)
                {
                    //titleTimer.Stop();
                }
            }

        }

        private void btnInvite_Click(object sender, EventArgs e)
        {
            InviteDialog _invite = new InviteDialog();
            if(_invite.ShowDialog()== DialogResult.OK)
            {
                MessagePackage _send = new MessagePackage();
                _send.Type = MessageType.GetFriend;
                _send.Informations = new List<string>();
                _send.Informations.Add(_invite.txtEmail.Text);

                Client.Send(_send);
                MessagePackage _received = Client.Listen();

                if(_received.Type==MessageType.Positive)
                {
                    int FriendID = Convert.ToInt32(_received.Informations[0]);
                    string FriendName = _received.Informations[1];
                    _send = new MessagePackage();
                    _send.Type = MessageType.BoundUser;
                    _send.Informations = new List<string>();
                    _send.Informations.Add(FriendID.ToString());
                    _send.Informations.Add(this._id.ToString());

                    Client.Send(_send);
                    _received = Client.Listen();
                    if(_received.Type== MessageType.Positive)
                    {
                        addUser(FriendID, FriendName);
                    }
                    else
                    {
                        AdviceDialog _advice = new AdviceDialog("Este amigo já esta no servidor");
                        _advice.ShowDialog();
                    }


                }
                else
                {
                    AdviceDialog _advice = new AdviceDialog("Amigo não encontrado!");
                    _advice.ShowDialog();
                }

            }

        }
    }
}