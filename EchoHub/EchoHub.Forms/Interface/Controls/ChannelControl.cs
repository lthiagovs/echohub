namespace EchoHub.Forms.Interface.Controls
{
    public partial class ChannelControl : UserControl
    {
        public int _id;
        private ServerControl _target;
        public ChannelControl(string Name, int _id, ServerControl _target)
        {
            InitializeComponent();
            this.txtName.Text = Name;
            this._id = _id;
            this._target = _target;
        }

        private void txtName_Click(object sender, EventArgs e)
        {

            this._target.setChannel(this);
            this._target.reloadMessages(this._id);

        }
    }
}
