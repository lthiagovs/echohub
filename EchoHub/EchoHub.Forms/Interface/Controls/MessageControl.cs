namespace EchoHub.Forms.Interface.Controls
{
    public partial class MessageControl : UserControl
    {

        public readonly int _userID;

        public MessageControl(int userID, string Name, string Content, Image? img)
        {
            InitializeComponent();
            _userID = userID;
            this.txtContent.Text = Content;
            this.txtName.Text = Name;

            if(img!=null)
            {
                this.pbUser.Image = img;
                this.pbUser.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }
    }
}
