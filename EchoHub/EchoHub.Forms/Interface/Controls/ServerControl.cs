using System.Runtime.InteropServices;

namespace EchoHub.Forms.Interface.Controls
{
    public partial class ServerControl : UserControl
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

        private void addUser()
        {

            UserHub _userHub = new UserHub();
            _userHub.Location = new Point(0,pnUser.Controls.Count*_userHub.Height);
            pnUser.Controls.Add(_userHub);

        }

        private void addMessage()
        {

            MessageControl _messageControl = new MessageControl();
            _messageControl.Location = new Point(0,pnMessages.Controls.Count*_messageControl.Height);
            pnMessages.Controls.Add(_messageControl);

        }

        private void addChannel()
        {

            ChannelControl _channelControl = new ChannelControl();
            _channelControl.Location = new Point(0, pnChannel.Controls.Count * _channelControl.Height+10);
            pnChannel.Controls.Add(_channelControl);

        }

        public ServerControl()
        {



            InitializeComponent();

            this.btnConfig.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnConfig.Width, btnConfig.Height, _round, _round));
            this.btnMic.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnMic.Width, btnMic.Height, _round, _round));
            this.btnPhone.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnPhone.Width, btnPhone.Height, _round, _round));
            //this.pnChat.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnChat.Width, pnChat.Height, _round, _round));
            //this.pnMessage.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnMessage.Width, pnMessage.Height, _round, _round));

            //test
            addUser();
            addUser();
            addMessage();
            addMessage();
            addChannel();
            addChannel();

        }
    }
}