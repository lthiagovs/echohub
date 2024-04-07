namespace EchoHub.Forms.Interface.Controls
{
    public partial class MessageControl : UserControl
    {

        public int _userID;

        public MessageControl(int userID)
        {
            InitializeComponent();
            _userID = userID;
        }
    }
}
