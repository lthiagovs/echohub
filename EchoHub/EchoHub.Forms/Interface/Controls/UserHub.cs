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
        }
    }
}
