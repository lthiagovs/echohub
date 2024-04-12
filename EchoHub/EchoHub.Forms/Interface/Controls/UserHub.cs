using EchoHub.Forms.Helper;

namespace EchoHub.Forms.Interface.Controls
{
    public partial class UserHub : UserControl
    {

        public readonly int _id;
        public readonly string _name;

        public UserHub(int id, string name)
        {
            InitializeComponent();
            _id = id;
            _name = name;
            this.txtName.Text = name;

            Image? userImage = ClientHelper.AskUserImage(_id);

            if(userImage!=null)
            {
                this.pbUser.Image = userImage;
                this.pbUser.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }
    }
}
