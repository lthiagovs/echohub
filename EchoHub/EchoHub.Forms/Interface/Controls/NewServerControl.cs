using EchoHub.Common;
using EchoHub.Common.Helper;
using EchoHub.Forms.Core;
using EchoHub.Forms.Helper;
using EchoHub.Forms.Interface.Dialogs;

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

            MessagePackage _send = PackageHelper.CreatePackage(MessageType.CreateServer);
            _send.Informations.Add(txtServerName.Text);
            _send.Informations.Add(_target._user.Email);
            _send.Informations.Add(_target._user.Password);

            Client.Send(_send);
            MessagePackage _receive = Client.Listen();

            //Server Created
            if (PackageHelper.IsPositive(_receive))
            {
                int serverID = Convert.ToInt32(_receive.Informations[0]);
                Image? serverImage = ClientHelper.ByteToImage(_image);

                this._target.addServer(serverID, txtServerName.Text, serverImage);

                this.txtServerName.Text = "";
                _send = PackageHelper.CreatePackage(MessageType.CreateChat);
                _send.Informations.Add(_receive.Informations[0]);
                _send.Informations.Add("Novo chat");
                Client.Send(_send);
                _receive = Client.Listen();

                //First Chat Created
                if (PackageHelper.IsPositive(_receive))
                {
                   
                    //Send Photo
                    if(_image!=null)
                    {

                        _send = PackageHelper.CreatePackage(MessageType.ChangeServerPhoto);
                        _send.Informations.Add(serverID.ToString());
                        _send.Informations.Add(Convert.ToBase64String(_image));

                        Client.Send(_send);
                        _receive = Client.Listen();

                        //Photo received
                        if (!PackageHelper.IsPositive(_receive))
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
