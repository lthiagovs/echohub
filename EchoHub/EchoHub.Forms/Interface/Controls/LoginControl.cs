using EchoHub.Common;
using EchoHub.Common.Models;
using EchoHub.Forms.Core;
using EchoHub.Forms.Interface.Dialogs;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace EchoHub.Forms.Interface.Controls
{
    public partial class LoginControl : UserControl
    {

        private int _round = 8;
        private AccountForm _target;

        //Round Borders
        #region
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        #endregion

        public LoginControl(AccountForm _target)
        {
            InitializeComponent();
            pnEmail.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnEmail.Width, pnEmail.Height, _round, _round));
            pnPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnPassword.Width, pnPassword.Height, _round, _round));
            btnLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 20, 20));
            this._target = _target;

        }

        private void OpenMainForm(User _user)
        {
            Application.Run(new MainForm(_user));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            MessagePackage _send = new MessagePackage();
            _send.Type = MessageType.VerifyAccount;
            _send.Informations = new List<string>();
            _send.Informations.Add(txtEmail.Text);
            _send.Informations.Add(txtPassword.Text);

            Client.Send(_send);
            MessagePackage _receive = Client.Listen();

            if(_receive.Type== MessageType.Positive)
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
