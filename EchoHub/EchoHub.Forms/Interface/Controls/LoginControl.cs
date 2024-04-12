using EchoHub.Common;
using EchoHub.Common.Helper;
using EchoHub.Common.Models;
using EchoHub.Forms.Core;
using EchoHub.Forms.Elements;
using EchoHub.Forms.Interface.Dialogs;

namespace EchoHub.Forms.Interface.Controls
{
    public partial class LoginControl : UserControl
    {

        private readonly AccountForm _target;

        public LoginControl(AccountForm _target)
        {
            InitializeComponent();
            RoundBorder.Round(pnEmail, 8);
            RoundBorder.Round(pnPassword, 8);
            RoundBorder.Round(btnLogin, 8);
            this._target = _target;

        }

        private void OpenMainForm(User _user)
        {
            Application.Run(new MainForm(_user));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            MessagePackage _send = PackageHelper.CreatePackage(MessageType.VerifyAccount);
            _send.Informations.Add(txtEmail.Text);
            _send.Informations.Add(txtPassword.Text);

            Client.Send(_send);
            MessagePackage _receive = Client.Listen();

            if(PackageHelper.IsPositive(_receive))
            {
                User _user = new User();
                _user.Email = txtEmail.Text;
                _user.Password = txtPassword.Text;
                _user.Name = _receive.Informations[1];
                _user.Id = Convert.ToInt32(_receive.Informations[0]);

                Thread MainFormThread = new Thread(() => OpenMainForm(_user));
                MainFormThread.SetApartmentState(ApartmentState.STA);
                MainFormThread.Start();

                _target.Dispose();


            }
            else
            {
                AdviceDialog _dialog = new AdviceDialog("Credenciais incorretas!");
                _dialog.ShowDialog();
            }

        }
    }
}
