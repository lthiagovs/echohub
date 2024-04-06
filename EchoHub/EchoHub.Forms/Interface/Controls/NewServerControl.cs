using EchoHub.Common;
using EchoHub.Forms.Core;
using EchoHub.Forms.Interface.Dialogs;

namespace EchoHub.Forms.Interface.Controls
{
    public partial class NewServerControl : UserControl
    {

        private MainForm _target;

        public NewServerControl(MainForm target)
        {
            InitializeComponent();
            _target = target;
        }

        private void btnNewServer_Click(object sender, EventArgs e)
        {

            MessagePackage _send = new MessagePackage();
            _send.Type = MessageType.CreateServer;
            _send.Informations = new List<string>();
            _send.Informations.Add(txtServerName.Text);
            _send.Informations.Add(_target._logged.Email);
            _send.Informations.Add(_target._logged.Password);

            Client.Send(_send);
            MessagePackage _receive = Client.Listen();

            if(_receive.Type == MessageType.Positive)
            {
                this._target.addServer(Convert.ToInt32(_receive.Informations[0]),txtServerName.Text);
                this.txtServerName.Text = "";
                _send = new MessagePackage();
                _send.Type = MessageType.CreateChat;
                _send.Informations = new List<string>();
                _send.Informations.Add(_receive.Informations[0]);
                _send.Informations.Add("Novo chat");
                Client.Send(_send);

                _receive = Client.Listen();
                if(_receive.Type!=MessageType.Positive)
                {
                    AdviceDialog _advice = new AdviceDialog("Erro ao formar servidor.");
                }

            }
            else
            {
                AdviceDialog _advice = new AdviceDialog("Erro interno");
                _advice.ShowDialog();
            }


        }
    }
}
