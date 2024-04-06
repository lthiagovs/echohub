using EchoHub.Common;
using EchoHub.Common.Models;
using EchoHub.Forms.Core;
using EchoHub.Forms.Interface.Dialogs;

namespace EchoHub.Forms.Interface.Controls
{
    public partial class AccountControl : UserControl
    {
        private User _logged;
        private byte[]? _image;

        public AccountControl(User _user, MainForm _target, Image? img)
        {
            InitializeComponent();
            _logged = _user;
            txtEmail.Text = _user.Email;
            txtName.Text = _user.Name;
            txtPassword.Text = _user.Password;

            if(img != null )
            {
                this.pbUser.Image = img;
                this.pbUser.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            ChangeDialog _change = new ChangeDialog();
            if (_change.ShowDialog() == DialogResult.OK)
            {
                MessagePackage _send = new MessagePackage();
                _send.Type = MessageType.ChangeName;
                _send.Informations = new List<string>();
                _send.Informations.Add(_logged.Id.ToString());
                _send.Informations.Add(_change.txtChange.Text);

                Client.Send(_send);
                MessagePackage _received = Client.Listen();
                AdviceDialog _advice;
                if (_received.Type == MessageType.Positive)
                {
                    _advice = new AdviceDialog("Nome alterado com sucesso!");
                    _logged.Name = _change.txtChange.Text;
                    txtName.Text = _logged.Name;

                }
                else
                {
                    _advice = new AdviceDialog("Erro interno...");
                }

            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

            ChangeDialog _change = new ChangeDialog();
            if (_change.ShowDialog() == DialogResult.OK)
            {
                MessagePackage _send = new MessagePackage();
                _send.Type = MessageType.ChangePassword;
                _send.Informations = new List<string>();
                _send.Informations.Add(_logged.Id.ToString());
                _send.Informations.Add(_change.txtChange.Text);

                Client.Send(_send);
                MessagePackage _received = Client.Listen();
                AdviceDialog _advice;
                if (_received.Type == MessageType.Positive)
                {
                    _advice = new AdviceDialog("Senha alterada com sucesso!");
                    _logged.Password = _change.txtChange.Text;
                    txtPassword.Text = _logged.Password;

                }
                else
                {
                    _advice = new AdviceDialog("Erro interno...");
                }

            }

        }

        private void btnChangePhoto_MouseEnter(object sender, EventArgs e)
        {
            this.btnChangePhoto.BackColor = Color.CornflowerBlue;
        }

        private void btnChangePhoto_MouseLeave(object sender, EventArgs e)
        {
            this.btnChangePhoto.BackColor = Color.FromArgb(0, 55, 55, 55);
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
                    this.pbUser.Image = img;
                    this.pbUser.SizeMode = PictureBoxSizeMode.StretchImage;

                    MessagePackage _send = new MessagePackage();
                    _send.Type = MessageType.ChangeUserPhoto;
                    _send.Informations = new List<string>();
                    _send.Informations.Add(this._logged.Id.ToString());
                    _send.Informations.Add(Convert.ToBase64String(_image));

                    Client.Send(_send);
                    MessagePackage _received = Client.Listen();

                    if(_received.Type!=MessageType.Positive)
                    {
                        AdviceDialog _advice = new AdviceDialog("Erro interno...");
                        _advice.ShowDialog();
                    }

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
