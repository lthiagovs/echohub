using EchoHub.Common;
using EchoHub.Forms.Core;

namespace EchoHub.Forms.Interface.Controls
{
    public partial class UserHub : UserControl
    {

        public int _id;
        public string _name;

        public UserHub(int id, string name)
        {
            InitializeComponent();
            _id = id;
            _name = name;
            this.txtName.Text = name;

            Image? img = null;
            MessagePackage _send = new MessagePackage();
            _send.Type = MessageType.GetUserPhoto;
            _send.Informations = new List<string>();
            _send.Informations.Add(_id.ToString());

            Client.Send(_send);
            MessagePackage _received = Client.Listen();

            if (_received.Type == MessageType.Positive)
            {
                byte[] _img = Convert.FromBase64String(_received.Informations[0]);
                MemoryStream _mStream = new MemoryStream(_img);
                img = Image.FromStream(_mStream);

            }

            if(img!=null)
            {
                this.pbUser.Image = img;
                this.pbUser.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }
    }
}
