namespace EchoHub.Forms.Interface.Controls
{
    public partial class ChannelControl : UserControl
    {
        private int _id;
        public ChannelControl(string Name, int _id)
        {
            InitializeComponent();
            this.txtName.Text = Name;
            this._id = _id;
        }
    }
}
