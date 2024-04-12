using EchoHub.Common;
using EchoHub.Common.Helper;
using EchoHub.Forms.Core;
using EchoHub.Forms.Interface.Dialogs;

namespace EchoHub.Forms.Interface.Controls
{
    public partial class ChannelControl : UserControl
    {
        public readonly int _id;
        private readonly ServerControl _target;
        public ChannelControl(string Name, int Id, ServerControl _target)
        {
            InitializeComponent();
            this.txtName.Text = Name;
            this._id = Id;
            this._target = _target;
        }

        private void txtName_Click(object sender, EventArgs e)
        {

            this._target.setChannel(this);
            this._target.reloadMessages(this._id);

        }

        private void txtName_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 65, 65, 65);
            btnChannel.BackColor = Color.CornflowerBlue;
            btnChannel.BorderStyle = BorderStyle.FixedSingle;
        }

        private void txtName_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 45, 45, 45);
            btnChannel.BackColor = Color.FromArgb(0, 45, 45, 45);
            btnChannel.BorderStyle = BorderStyle.None;
        }

        private void btnChannel_Click(object sender, EventArgs e)
        {
            ChangeDialog _change = new ChangeDialog();
            if(_change.ShowDialog()==DialogResult.OK)
            {
                MessagePackage _send = PackageHelper.CreatePackage(MessageType.ChangeChannel);
                _send.Informations.Add(this._id.ToString());
                _send.Informations.Add(_change.txtChange.Text);

                Client.Send(_send);
                MessagePackage _received = Client.Listen();

                if(PackageHelper.IsPositive(_received))
                {
                    this.txtName.Text = _change.txtChange.Text;
                }
                else
                {
                    AdviceDialog _advice = new AdviceDialog("Erro interno...");
                    _advice.ShowDialog();
                }

            }

        }

        private void btnChannel_MouseEnter(object sender, EventArgs e)
        {
            btnChannel.BackColor = Color.CornflowerBlue;
            btnChannel.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnChannel_MouseLeave(object sender, EventArgs e)
        {
            btnChannel.BackColor = Color.FromArgb(0, 45, 45, 45);
            btnChannel.BorderStyle = BorderStyle.None;
        }
    }
}
