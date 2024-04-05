using EchoHub.Common;
using EchoHub.Common.Models;
using EchoHub.Forms.Core;
using EchoHub.Forms.Interface.Dialogs;
using System.Runtime.InteropServices;

namespace EchoHub.Forms.Interface.Controls
{
    public partial class RegisterControl : UserControl
    {

        private int _round = 8;
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

        public RegisterControl()
        {

            InitializeComponent();
            pnEmail.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnEmail.Width, pnEmail.Height, _round, _round));
            pnPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnPassword.Width, pnPassword.Height, _round, _round));
            pnRepeatPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnRepeatPassword.Width, pnRepeatPassword.Height, _round, _round));
            btnRegister.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRegister.Width, btnRegister.Height, _round, _round));
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (txtPassword.Text.Equals(txtRepeatPassword.Text))
            {


                MessagePackage _send = new MessagePackage();
                _send.Type = MessageType.CreateAccount;
                _send.Informations = new List<string>();
                //Add info
                _send.Informations.Add(txtEmail.Text);
                _send.Informations.Add(txtPassword.Text);
                _send.Informations.Add(txtEmail.Text);

                Client.Send(_send);

                MessagePackage _receive = Client.Listen();

                if (_receive.Type == MessageType.Positive)
                {
                    AdviceDialog _advice = new AdviceDialog("Conta criada com sucesso!");
                    _advice.ShowDialog();
                }
                else
                {
                    AdviceDialog _advice = new AdviceDialog("Erro ao criar conta!");
                    _advice.ShowDialog();
                }


            }

        }
    }
}
