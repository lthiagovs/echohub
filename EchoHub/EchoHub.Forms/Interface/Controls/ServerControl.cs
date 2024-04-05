using EchoHub.Common.Models;
using System.Runtime.InteropServices;

namespace EchoHub.Forms.Interface.Controls
{
    public partial class ServerControl : UserControl
    {

        private int _round = 8;
        private User _user;
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

        private void addChannel(string Name)
        {

            ChannelControl _channelControl = new ChannelControl(Name);
            _channelControl.Location = new Point(0, pnChannel.Controls.Count * _channelControl.Height);
            pnChannel.Controls.Add(_channelControl);

        }

        public ServerControl(User _user)
        {



            InitializeComponent();
            this._user = _user;
            this.txtUserName.Text = _user.Name;

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
            addChannel("Novo Chat");
        }
    }
}