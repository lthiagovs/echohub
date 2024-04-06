using EchoHub.Common;
using EchoHub.Forms.Core;
using EchoHub.Forms.Interface.Dialogs;
using System.IO;
using System.Text;

namespace EchoHub.Forms.Interface.Controls
{
    public partial class NewServerControl : UserControl
    {

        private MainForm _target;
        private byte[]? _image;

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

            //Server Created
            if (_receive.Type == MessageType.Positive)
            {
                int serverID = Convert.ToInt32(_receive.Informations[0]);
                Image? img = null;
                if(_image!=null)
                {
                    MemoryStream _mStream = new MemoryStream(_image);
                    img = Image.FromStream(_mStream);
                }

                this._target.addServer(serverID, txtServerName.Text, img);

                this.txtServerName.Text = "";
                _send = new MessagePackage();
                _send.Type = MessageType.CreateChat;
                _send.Informations = new List<string>();
                _send.Informations.Add(_receive.Informations[0]);
                _send.Informations.Add("Novo chat");
                Client.Send(_send);
                _receive = Client.Listen();

                //First Chat Created
                if (_receive.Type == MessageType.Positive)
                {
                   
                    //Send Photo
                    if(_image!=null)
                    {

                        _send = new MessagePackage();
                        _send.Informations = new List<string>();
                        _send.Type = MessageType.ChangeServerPhoto;
                        _send.Informations.Add(serverID.ToString());
                        _send.Informations.Add(Convert.ToBase64String(_image));

                        Client.Send(_send);
                        _receive = Client.Listen();

                        //Photo received
                        if (_receive.Type != MessageType.Positive)
                        {
                            AdviceDialog _advice = new AdviceDialog("Erro ao enviar foto.");
                            _advice.ShowDialog();
                        }

                    }

                }
                else
                {
                    AdviceDialog _advice = new AdviceDialog("Erro ao formar servidor.");
                    _advice.ShowDialog();
                }

            }
            else
            {
                AdviceDialog _advice = new AdviceDialog("Erro interno");
                _advice.ShowDialog();
            }


        }

        private void btnChangePhoto_MouseEnter(object sender, EventArgs e)
        {
            this.btnChangePhoto.BackColor = Color.CornflowerBlue;
        }

        private void btnChangePhoto_MouseLeave(object sender, EventArgs e)
        {
            this.btnChangePhoto.BackColor = Color.FromArgb(0, 80, 80, 80);
        }

        private void btnChangePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog _filePicker = new OpenFileDialog();
            _filePicker.Title = "Pick a picture!";
            _filePicker.Filter = "Images (*.png*)|*.png*";
            _filePicker.RestoreDirectory = true;
            DialogResult result = _filePicker.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = _filePicker.FileName;
                try
                {

                    _image = File.ReadAllBytes(file);
                    MemoryStream _mStream = new MemoryStream(_image);
                    Image img = Image.FromStream(_mStream);
                    this.pbServer.Image = img;
                    this.pbServer.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                catch (IOException)
                {
                    AdviceDialog _advice = new AdviceDialog("Erro interno.");
                    _advice.ShowDialog();
                }

            }
        }
    }
}
