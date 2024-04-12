using EchoHub.Common;
using EchoHub.Common.Helper;
using EchoHub.Common.Models;
using EchoHub.Forms.Core;
using EchoHub.Forms.Elements;
using EchoHub.Forms.Helper;
using EchoHub.Forms.Interface.Dialogs;

namespace EchoHub.Forms.Interface.Controls
{
    public partial class ServerControl : UserControl
    {

        private readonly User _user;
        private readonly MainForm _target;
        public ChannelControl _selectedChannel;
        private readonly int _id;
        private Image? _userImg;

        private bool titleTimerTrigger = false;

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

            RoundBorder.Round(btnConfig, 8);
            RoundBorder.Round(btnMic, 8);
            RoundBorder.Round(btnPhone, 8);

            _userImg = ClientHelper.AskUserImage(_user.Id);

            if (_userImg != null)
            {
                this.pbUser.Image = _userImg;
                this.pbUser.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            messagesTimer.Start();


        }

        private void addUser(int Id, string Name)
        {

            UserHub _userHub = new UserHub(Id, Name);
            _userHub.Location = new Point(0, pnUser.Controls.Count * _userHub.Height);
            pnUser.Controls.Add(_userHub);

        }

        private void reloadUser()
        {
            MessagePackage _send = PackageHelper.CreatePackage(MessageType.GetFriends);
            _send.Informations.Add(_id.ToString());

            Client.Send(_send);

            MessagePackage _received = Client.Listen();

            if (PackageHelper.IsPositive(_received))
            {

                for (int i = 0; i < _received.Informations.Count; i += 2)
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

        private void addMessage(string Name, string Content, Image? img, int UserID)
        {
            upScroll();
            MessageControl _messageControl = new MessageControl(UserID, Name, Content, img);
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

        //Fix screen issues when throwing messages
        private void pullScroll()
        {

            using (Control c = new Control() { Parent = this.pnMessages, Dock = DockStyle.Bottom })
            {
                this.pnMessages.ScrollControlIntoView(c);
                c.Parent = null;
            }

        }

        private void upScroll()
        {
            using (Control c = new Control() { Parent = this.pnMessages, Dock = DockStyle.Top })
            {
                this.pnMessages.ScrollControlIntoView(c);
                c.Parent = null;
            }
        }

        private void reloadChannels()
        {

            MessagePackage _send = PackageHelper.CreatePackage(MessageType.GetChats);
            _send.Informations.Add(_id.ToString());
            Client.Send(_send);

            MessagePackage _receive = Client.Listen();

            if (PackageHelper.IsPositive(_receive))
            {

                for (int i = 0; i < _receive.Informations.Count(); i += 2)
                {
                    addChannel(_receive.Informations[i + 1], Convert.ToInt32(_receive.Informations[i]));
                }

            }
            else
            {
                AdviceDialog _advice = new AdviceDialog("Não foi possivel carregas os chats...");
                _advice.ShowDialog();
            }
            pullScroll();

        }

        public void reloadMessages(int chatId)
        {

            clearMessages();
            MessagePackage _send = PackageHelper.CreatePackage(MessageType.GetMessages);
            _send.Informations.Add(chatId.ToString());

            Client.Send(_send);

            MessagePackage _receive = Client.Listen();

            if (PackageHelper.IsPositive(_receive))
            {

                for (int i = 0; i < _receive.Informations.Count(); i += 3)
                {
                    int _messageUserId = Convert.ToInt32(_receive.Informations[i + 2]);
                    Image? userImage = ClientHelper.AskUserImage(_messageUserId);
                    addMessage(_receive.Informations[i + 1], _receive.Informations[i], userImage, _messageUserId);

                }

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

        private void txtChat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && ClientHelper.ValidateMessage(txtChat.Text))
            {

                MessagePackage _send = PackageHelper.CreatePackage(MessageType.CreateMessage);
                _send.Informations.Add(_selectedChannel._id.ToString());
                _send.Informations.Add(this._target._user.Id.ToString());
                _send.Informations.Add(txtChat.Text);

                Client.Send(_send);

                MessagePackage _received = Client.Listen();

                if (PackageHelper.IsPositive(_received))
                {
                    addMessage(this._user.Name, txtChat.Text, _userImg, _target._user.Id);
                    txtChat.Text = "";
                }
                else
                {
                    AdviceDialog _advice = new AdviceDialog("Erro interno ao enviar a mensagem...");
                    _advice.ShowDialog();
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
                pullScroll();

            }


        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Image? userImage = ClientHelper.AskUserImage(this._user.Id);
            this._target.setContent(new AccountControl(this._user, this._target, userImage));
        }

        private void btnCreateChat_Click(object sender, EventArgs e)
        {
            MessagePackage _send = PackageHelper.CreatePackage(MessageType.CreateChat);
            _send.Informations.Add(_id.ToString());
            _send.Informations.Add("Novo chat");
            Client.Send(_send);

            MessagePackage _received = Client.Listen();
            if (PackageHelper.IsPositive(_received))
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
            if (_invite.ShowDialog() == DialogResult.OK)
            {
                MessagePackage _send = PackageHelper.CreatePackage(MessageType.GetFriend);
                _send.Informations.Add(_invite.txtEmail.Text);
                Client.Send(_send);

                MessagePackage _received = Client.Listen();
                if (PackageHelper.IsPositive(_received))
                {
                    int FriendID = Convert.ToInt32(_received.Informations[0]);
                    string FriendName = _received.Informations[1];
                    _send = PackageHelper.CreatePackage(MessageType.BoundUser);
                    _send.Informations.Add(FriendID.ToString());
                    _send.Informations.Add(this._id.ToString());
                    Client.Send(_send);

                    _received = Client.Listen();
                    if (PackageHelper.IsPositive(_received))
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

        //Update Messages in Async
        private List<Common.Models.Message> updateMessagesAsync()
        {
            List<Common.Models.Message> _messages = new List<Common.Models.Message>();
            MessagePackage _send = PackageHelper.CreatePackage(MessageType.GetMessages);
            _send.Informations.Add(_selectedChannel._id.ToString());
            Client.Send(_send);

            MessagePackage _received = Client.Listen();
            int messageNumber = pnMessages.Controls.Count;

            if (PackageHelper.IsPositive(_received))
            {

                for (int i = 0; i < _received.Informations.Count(); i += 3)
                {

                    if (i / 3 >= messageNumber)
                    {
                        Common.Models.Message _message = new Common.Models.Message();
                        _message.Content = _received.Informations[i];
                        _message._User = new User();
                        _message._User.Name = _received.Informations[i + 1];
                        _message.UserID = Convert.ToInt32(_received.Informations[i + 2]);
                        _messages.Add(_message);
                    }

                }

            }

            return _messages;


        }

        private void messagesTimer_Tick(object sender, EventArgs e)
        {

            //Task<List<Common.Models.Message>> update = await updateMessagesAsync();
            List<Common.Models.Message> _messages = updateMessagesAsync();

            foreach (var message in _messages)
            {

                int _messageUserID = message.UserID;
                Image? img = ClientHelper.AskUserImage(_messageUserID);
                addMessage(message._User.Name, message.Content, img, message.UserID);
                pullScroll();

            }


        }

    }
}